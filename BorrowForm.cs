using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using Library_Management.Borrow_Forms;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Management
{
    public partial class BorrowForm : Form
    {
        string connectionString = "Host=localhost;Port=5432;Database=librarymanage;Username=postgres;Password=12345678;";
        string inventoryIDString = "";
        string selectedInventoryString = "";

        private BluetoothListener listener;
        private BluetoothClient bluetoothClient;
        private NetworkStream networkStream;
        private Thread listenThread;
        private bool running = false;
        public BorrowForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            inventoryIDString = getInvetoryID(BookBox.Text);
            using (Npgsql.NpgsqlConnection connection = new Npgsql.NpgsqlConnection(connectionString))
            {
                connection.Open();
                string current_state = "due";
                string user_IDString = "";
                int user_IDInt = 0;
                string insertQuery = "INSERT INTO borrows(user_id, username, inventory_id, current_state, date_due) VALUES (" +
                    "@user_id, @username, @inventory_id, @current_state, @date_due)";
                string userIDQuery = "SELECT id FROM users WHERE username = @username";
                try
                {
                    // get user_id from username
                    using (Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand(userIDQuery, connection))
                    {
                        command.Parameters.AddWithValue("username", NameBox.Text.Trim());
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user_IDString = reader["id"].ToString();
                                user_IDInt = int.Parse(user_IDString);
                            }
                        }
                    }
                    int inventory_IDInt = int.Parse(inventoryIDString);

                    using (Npgsql.NpgsqlCommand command1 = new Npgsql.NpgsqlCommand(insertQuery, connection))
                    {
                        command1.Parameters.AddWithValue("user_id", user_IDInt);
                        command1.Parameters.AddWithValue("username", NameBox.Text.Trim());
                        command1.Parameters.AddWithValue("inventory_id", inventory_IDInt);
                        command1.Parameters.AddWithValue("current_state", current_state);
                        command1.Parameters.AddWithValue("date_due", DueDatePicker.Value);

                        command1.ExecuteNonQuery();

                        decreaseQuantityOfBook(inventory_IDInt);
                        updateDataGrid();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }


            }
        }

        private void updateDataGrid()
        {
            BindingSource bindingSource = new BindingSource();
            string borrowsQuery = "SELECT id, username, current_state, date_added, date_due FROM borrows";

            using (Npgsql.NpgsqlConnection connection = new Npgsql.NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Npgsql.NpgsqlDataAdapter adapter = new Npgsql.NpgsqlDataAdapter(borrowsQuery, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    bindingSource.DataSource = dataTable;

                    BorrowGrid.DataSource = dataTable;
                    DataGridViewColumn column = new DataGridViewColumn();
                    column.MinimumWidth = 10;
                    column.FillWeight = 30;
                    BorrowGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {
            StartBluetoothServer();
            updateDataGrid();
            string[] states = { "due", "overdue", "returned" };
            StateBox.Items.AddRange(states);
        }

        private void updateInfoLabels(string barcodeIDString)
        {

            using (Npgsql.NpgsqlConnection connection = new Npgsql.NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM books WHERE barcode_id = @barcode_id";
                try
                {
                    int barcodeID = int.Parse(barcodeIDString);
                    using (Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("barcode_id", barcodeID);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string? bookName = reader["name"].ToString();
                                string? author = reader["author"].ToString();
                                string? year = reader["year"].ToString();

                                BookNameLabel.Text = bookName;
                                AuthorLabel.Text = author;
                                YearPublishedLabel.Text = year;
                                IDLabel.Text = barcodeIDString;
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SelectUserButton_Click(object sender, EventArgs e)
        {
            SelectUserBorrow selectUserBorrow = new SelectUserBorrow();
            if (selectUserBorrow.ShowDialog() == DialogResult.OK)
            {
                NameBox.Text = selectUserBorrow.userReturned;
            }
            selectUserBorrow.Dispose();
        }

        private void SelectBookButton_Click(object sender, EventArgs e)
        {
            SelectBookBorrow selectBookBorrow = new SelectBookBorrow();
            if (selectBookBorrow.ShowDialog() == DialogResult.OK)
            {
                string barcodeIDReturn = selectBookBorrow.barcodeIDReturn;
                BookBox.Text = barcodeIDReturn;
                updateInfoLabels(barcodeIDReturn);
            }
            selectBookBorrow.Dispose();
        }

        private string getBookID(string barcode)
        {
            return "";
        }

        private string getInvetoryID(string barcodeIDString)
        {
            string inventoryReturn = "";
            string query = "SELECT id FROM inventory WHERE barcode_id = @barcode_id";
            using (Npgsql.NpgsqlConnection connection = new Npgsql.NpgsqlConnection(connectionString))
            {
                try
                {
                    int barcodeID = int.Parse(barcodeIDString);
                    connection.Open();
                    using (Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("barcode_id", barcodeID);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                inventoryReturn = reader["id"].ToString();
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            return inventoryReturn;
        }

        private void decreaseQuantityOfBook(int inventory_id)
        {
            using (Npgsql.NpgsqlConnection connection = new Npgsql.NpgsqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string addQuantityQuery = "UPDATE inventory SET quantity = quantity - @quantity " +
                        "WHERE id = @id";
                    using (Npgsql.NpgsqlCommand comm1 = new Npgsql.NpgsqlCommand(addQuantityQuery, connection))
                    {
                        comm1.Parameters.AddWithValue("quantity", 1);
                        comm1.Parameters.AddWithValue("id", inventory_id);

                        comm1.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void increaseQuantityOfBook(string inventoryIDString)
        {
            using (Npgsql.NpgsqlConnection connection2 = new Npgsql.NpgsqlConnection(connectionString))
            {
                connection2.Open();
                try
                {
                    string addQuantityQuery = "UPDATE inventory SET quantity = quantity + @quantity " +
                        "WHERE id = @id";
                    using (Npgsql.NpgsqlCommand comm1 = new Npgsql.NpgsqlCommand(addQuantityQuery, connection2))
                    {
                        int inventoryID = int.Parse(inventoryIDString);
                        comm1.Parameters.AddWithValue("quantity", 1);
                        comm1.Parameters.AddWithValue("id", inventoryID);

                        comm1.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            int idInt = int.Parse(BorrowBox.Text.Trim());
            using (Npgsql.NpgsqlConnection connection = new Npgsql.NpgsqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string query = "UPDATE borrows SET current_state = @new_state WHERE id = @id";
                    using (Npgsql.NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("new_state", StateBox.Text.Trim());
                        command.Parameters.AddWithValue("id", idInt);

                        command.ExecuteNonQuery();
                        updateDataGrid();
                    }
                    if (StateBox.SelectedIndex == 2)
                    {
                        increaseQuantityOfBook(selectedInventoryString);
                    }
                }
                catch (PostgresException ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void BorrowGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell clickedCell = BorrowGrid.Rows[e.RowIndex].Cells[0];

                object cellValue = clickedCell.Value;
                string? cellValueString = cellValue.ToString();
                if (string.IsNullOrEmpty(cellValueString)) { return; }
                BorrowGrid.Text = cellValueString;
                BorrowBox.Text = cellValueString;

                string query = "SELECT inventory_id FROM borrows WHERE id = @id";
                string query2 = "SELECT book_id FROM inventory WHERE id = @id";
                string inventoryIDString = "";

                using (Npgsql.NpgsqlConnection connection = new Npgsql.NpgsqlConnection(connectionString))
                {
                    try
                    {
                        int borrowID = int.Parse(cellValueString);
                        connection.Open();
                        // get inventory id
                        using (Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("id", borrowID);
                            using (var reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    inventoryIDString = reader["inventory_id"].ToString();
                                    selectedInventoryString = inventoryIDString;
                                }

                            }
                        }
                        // get book id
                        using (Npgsql.NpgsqlCommand command1 = new NpgsqlCommand(query2, connection))
                        {
                            int inventoryID = int.Parse(inventoryIDString);
                            command1.Parameters.AddWithValue("id", inventoryID);
                            using (var reader = command1.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string bookID = reader["book_id"].ToString();
                                    updateInfoLabels(bookID);
                                }

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private Guid mUUID = BluetoothService.SerialPort;

        private void StartBluetoothServer()
        {
            Thread bluetoothServerThread = new Thread(new ThreadStart(ServerConnectThread));
            bluetoothServerThread.Start();
        }
        private void ServerConnectThread()
        {
            BluetoothListener blueListener = new BluetoothListener(mUUID);
            blueListener.Start();
            Invoke((MethodInvoker)delegate { bluetoothStatusUpdate("Bluetooth Started."); });

            // Loop to accept multiple connections or handle a single connection
            while (true)
            {
                BluetoothClient conn = blueListener.AcceptBluetoothClient(); // Blocks until a client connects
                Invoke((MethodInvoker)delegate { bluetoothStatusUpdate("A client has connected."); }); // Update UI on main thread

                Stream mStream = conn.GetStream();
                byte[] buffer = new byte[1024]; // Adjust buffer size as needed
                int bytesRead;

                try
                {
                    while ((bytesRead = mStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        // Process received data (e.g., convert to string, update UI)
                        string receivedData = System.Text.Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        //Invoke((MethodInvoker)delegate { bluetoothStatusUpdate("Writing from stream..."); });
                        Invoke((MethodInvoker)delegate { UpdateUI(receivedData); });
                    }
                }
                catch (IOException ex)
                {
                    Invoke((MethodInvoker)delegate { bluetoothStatusUpdate("Error reading stream: " + ex.Message); });
                }
                finally
                {
                    mStream.Close();
                    conn.Close();
                }
            }
        }

        private void UpdateUI(string message)
        {
            // Method to safely update UI elements from a background thread
            // e.g., yourTextBox.AppendText(message + Environment.NewLine);
            BookBox.Text = message;
        }
        private void bluetoothStatusUpdate(string message)
        {
            bluetoothStatusLabel.Text = message;
        }

    }
}
