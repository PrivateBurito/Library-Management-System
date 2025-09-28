using Library_Management.Borrow_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class BorrowForm : Form
    {
        string connectionString = "Host=localhost;Port=5432;Database=librarymanage;Username=postgres;Password=12345678;";
        public BorrowForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void updateDataGrid()
        {
            BindingSource bindingSource = new BindingSource();
            string borrowsQuery = "SELECT * FROM borrows";

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
            updateDataGrid();
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
                
            }
            selectBookBorrow.Dispose();
        }
    }
}
