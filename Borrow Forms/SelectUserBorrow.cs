using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management.Borrow_Forms
{

    public partial class SelectUserBorrow : Form
    {
        string connectionString = "Host=localhost;Port=5432;Database=librarymanage;Username=postgres;Password=12345678;";

        public string userReturned
        {
            get;
            set;
        }

        public SelectUserBorrow()
        {

            InitializeComponent();
        }

        private void SelectUserBorrow_Load(object sender, EventArgs e)
        {
            updateDataGrid();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
        }

        private void updateInfoLabels(string userIDString)
        {
            using (Npgsql.NpgsqlConnection connection = new Npgsql.NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM users WHERE username = @username";
                try
                {
                    using (Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("username", userIDString);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string? username = reader["username"].ToString();
                                string? firstName = reader["first_name"].ToString();
                                string? middleName = reader["middle_name"].ToString();
                                string? lastName = reader["last_name"].ToString();
                                string? email = reader["email"].ToString();

                                UsernameLabel.Text = username;
                                FirstNameLabel.Text = firstName;
                                MiddleNameLabel.Text = middleName;
                                LastNameLabel.Text = lastName;
                                EmailLabel.Text = email;
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

        private void updateDataGrid()
        {
            BindingSource bindingSource = new BindingSource();
            string borrowsQuery = "SELECT username, first_name, middle_name, last_name, email FROM users";

            using (Npgsql.NpgsqlConnection connection = new Npgsql.NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Npgsql.NpgsqlDataAdapter adapter = new Npgsql.NpgsqlDataAdapter(borrowsQuery, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    bindingSource.DataSource = dataTable;

                    UserGrid.DataSource = dataTable;
                    DataGridViewColumn column = new DataGridViewColumn();
                    column.MinimumWidth = 10;
                    column.FillWeight = 30;
                    UserGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    UserGrid.Columns["username"].HeaderText = "Username";
                    UserGrid.Columns["first_name"].HeaderText = "First Name";
                    UserGrid.Columns["middle_name"].HeaderText = "Middle Name";
                    UserGrid.Columns["last_name"].HeaderText = "Last Name";
                    UserGrid.Columns["email"].HeaderText = "Email";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UserGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell clickedCellUsernmae = UserGrid.Rows[e.RowIndex].Cells[0];

                object cellValueUsername = clickedCellUsernmae.Value;
                string? cellValueUsernameString = cellValueUsername.ToString();       
                if (string.IsNullOrEmpty(cellValueUsernameString)) { return; }

                userReturned = cellValueUsernameString;
                updateInfoLabels(cellValueUsernameString);
            }
        }
    }
}
