using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class AddToInvetoryForm : Form
    {
        string connectionString = "Host=localhost;Port=5432;Database=librarymanage;Username=postgres;Password=12345678;";

        public AddToInvetoryForm()
        {
            InitializeComponent();
        }

        private void updateInventoryGrid()
        {
            BindingSource bindingSource = new BindingSource();
            string query = "SELECT * FROM inventory";
            using (Npgsql.NpgsqlConnection connection = new Npgsql.NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Npgsql.NpgsqlDataAdapter adapter = new Npgsql.NpgsqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    bindingSource.DataSource = dataTable;

                    InventoryGrid.DataSource = dataTable;
                    DataGridViewColumn column = new DataGridViewColumn();
                    column.MinimumWidth = 10;
                    column.FillWeight = 30;
                    InventoryGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void updateBookGrid()
        {
            BindingSource bindingSource = new BindingSource();
            string query = "SELECT * FROM books";
            using (Npgsql.NpgsqlConnection connection = new Npgsql.NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Npgsql.NpgsqlDataAdapter adapter = new Npgsql.NpgsqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    bindingSource.DataSource = dataTable;

                    BookGrid.DataSource = dataTable;
                    DataGridViewColumn column = new DataGridViewColumn();
                    column.MinimumWidth = 10;
                    column.FillWeight = 30;
                    BookGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AddToInvetoryForm_Load(object sender, EventArgs e)
        {
            updateInventoryGrid();
            updateBookGrid();
        }

        private void BookGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell clickedCell = BookGrid.Rows[e.RowIndex].Cells[0];

                object cellValue = clickedCell.Value;
                string? cellValueString = cellValue.ToString();
                if (string.IsNullOrEmpty(cellValueString)) { return; }
                BookTextBox.Text = cellValueString;

                updateInfoLabels(cellValueString);
            }
        }

        private void updateInfoLabels(string bookIDString)
        {
            int bookID = int.Parse(bookIDString);
            using (Npgsql.NpgsqlConnection connection = new Npgsql.NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM books WHERE id = @id";
                try
                {
                    using (Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("id", bookID);
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
                                IDLabel.Text = bookIDString;
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

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            using (Npgsql.NpgsqlConnection connection = new Npgsql.NpgsqlConnection(connectionString))
            {
                int quantityInt = int.Parse(QuantityBox.Text);
                int book_idInt = int.Parse(BookTextBox.Text);
                connection.Open();
                try
                {
                    string addBookQuery = "INSERT INTO inventory(quantity, book_id) VALUES (" +
                        "@quantity, @book_id)";
                    string getDetailsQuery = "SELECT * FROM books WHERE id = @id";

                    // Add books to inventory
                    using (Npgsql.NpgsqlCommand comm1 = new Npgsql.NpgsqlCommand(addBookQuery, connection))
                    {
                        comm1.Parameters.AddWithValue("quantity", quantityInt);
                        comm1.Parameters.AddWithValue("book_id", book_idInt);
                        comm1.ExecuteNonQuery();
                        updateInventoryGrid();
                    }

                    // shows the book name in success message
                    using (Npgsql.NpgsqlCommand comm2 = new Npgsql.NpgsqlCommand(getDetailsQuery, connection))
                    {
                        comm2.Parameters.AddWithValue("id", book_idInt);
                        using (var reader = comm2.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string? bookName = reader["name"].ToString();
                                MessageBox.Show("Added " + bookName);
                            }
                        }
                    }
                }
                catch (PostgresException ex)
                {
                    // Detects the unique restraint on book_id
                    if (ex.SqlState == "23505")
                    {
                        increaseQuantityOfBook(book_idInt, quantityInt);
                    }
                }
            }
        }

        private void increaseQuantityOfBook(int book_id, int quantity)
        {
            using (Npgsql.NpgsqlConnection connection = new Npgsql.NpgsqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string addQuantityQuery = "UPDATE inventory SET quantity = quantity + @quantity " +
                        "WHERE book_id = @book_id";
                    using (Npgsql.NpgsqlCommand comm1 = new Npgsql.NpgsqlCommand(addQuantityQuery, connection))
                    {
                        comm1.Parameters.AddWithValue("quantity", quantity);
                        comm1.Parameters.AddWithValue("book_id", book_id);

                        comm1.ExecuteNonQuery();
                        updateInventoryGrid();

                        MessageBox.Show("Added " + quantity + " books.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteBookButton_Click(object sender, EventArgs e)
        {
            using (Npgsql.NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    int book_idInt = int.Parse(BookTextBox.Text.Trim());
                    int quantityInt = int.Parse(QuantityBox.Text.Trim());
                    bool hasRemainingQuantity = false;
                    string errorMessage = "";
                    string selectQuery = "SELECT * FROM inventory WHERE book_id = @book_id";
                    string subtractBookQuery = "UPDATE inventory SET quantity = quantity - @quantity " +
                        "WHERE book_id = @book_id";
                    using (Npgsql.NpgsqlCommand comm2 = new NpgsqlCommand(selectQuery, connection))
                    {
                        int? remainingAmount = 0;
                        comm2.Parameters.AddWithValue("book_id", book_idInt);
                        using (var reader = comm2.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string? x = reader["quantity"].ToString();
                                int? quantityInv = 0;
                                if (x == null)
                                {
                                    x = "0";
                                }
                                else
                                {
                                    quantityInv = int.Parse(x);
                                }

                                remainingAmount = quantityInv - quantityInt;
                            }
                        }
                        if (remainingAmount > 0)
                        {
                            hasRemainingQuantity = true;
                        }
                        else if (remainingAmount < 0)
                        {
                            hasRemainingQuantity = false;
                            errorMessage = "Quantity to be deleted exceeds current stock.";
                        }
                        else if (remainingAmount == 0)
                        {
                            // handle delete here
                            hasRemainingQuantity = false;
                            errorMessage = "Book will be deleted from inventory.";
                        }
                    }
                    if (hasRemainingQuantity == true)
                    {
                        using (Npgsql.NpgsqlCommand comm1 = new NpgsqlCommand(subtractBookQuery, connection))
                        {
                            comm1.Parameters.AddWithValue("quantity", quantityInt);
                            comm1.Parameters.AddWithValue("book_id", book_idInt);

                            comm1.ExecuteNonQuery();
                            updateInventoryGrid();
                            MessageBox.Show("Removed " + quantityInt + " books from inventory.");
                        }
                    }
                    else
                    {
                        MessageBox.Show(errorMessage);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void InventoryGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell clickedCell = InventoryGrid.Rows[e.RowIndex].Cells[2];

                object cellValue = clickedCell.Value;
                string? cellValueString = cellValue.ToString();
                if (string.IsNullOrEmpty(cellValueString)) { return; }
                BookTextBox.Text = cellValueString;

                updateInfoLabels(cellValueString);
            }
        }
    }
}
