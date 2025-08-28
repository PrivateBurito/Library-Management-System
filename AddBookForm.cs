using Npgsql;
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
    public partial class AddBookForm : Form
    {
        string connectionString = "Host=localhost;Port=5432;Database=librarymanage;Username=postgres;Password=12345678;";

        public AddBookForm()
        {
            InitializeComponent();
        }

        private void addBooksButton_Click(object sender, EventArgs e)
        {
            using (Npgsql.NpgsqlConnection conn = new Npgsql.NpgsqlConnection(connectionString))
            {
                conn.Open();

                try
                {
                    Random random = new Random();
                    int idString = generateUniqueID();
                    int yearInt = int.Parse(YearBox.Text);
                    string query = "INSERT INTO books(id, name, author, year) VALUES (" +
                        "@id, @name, @author, @year)";

                    using (Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idString);
                        cmd.Parameters.AddWithValue("@name", NameBox.Text);
                        cmd.Parameters.AddWithValue("@author", AuthorBox.Text);
                        cmd.Parameters.AddWithValue("@year", yearInt);

                        MessageBox.Show("Added " + NameBox.Text);
                        cmd.ExecuteNonQuery();
                        updateGridData();
                        updateCounter();
                    }
                }
                catch (PostgresException ex)
                {
                    MessageBox.Show("Something wen't wrong in PostgreSQL:" + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to PostgreSQL: " + ex.Message);
                }

            }
        }

        private int generateUniqueID()
        {
            Random random = new Random();
            int idGen = random.Next(10000000, 100000000);
            int idString = idGen;

            try
            {
                using (Npgsql.NpgsqlConnection connection = new Npgsql.NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM books WHERE id = @id ";

                    using (Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", idString);

                        int matchCount = Convert.ToInt32(command.ExecuteScalar());
                        if (matchCount > 0)
                        {
                            idString = generateUniqueID();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return idString;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            updateGridData();
            updateCounter();
        }

        private void updateCounter()
        {
            using (Npgsql.NpgsqlConnection connection = new Npgsql.NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM books";

                using (Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand(query, connection))
                {
                    long rowCount = (long)command.ExecuteScalar()!;
                    BookCountLabel.Text = "Books Registered: " + rowCount;
                }
            }
        }
        private void updateGridData()
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

                    dataGridView1.DataSource = dataTable;
                    DataGridViewColumn column = new DataGridViewColumn();
                    column.MinimumWidth = 10;
                    column.FillWeight = 30;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int idForDeletion = int.Parse(deleteIDBox.Text);
            try
            {
                using (Npgsql.NpgsqlConnection connection = new Npgsql.NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM books WHERE id = @id";
                    using (Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", idForDeletion);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Succesfully deleted.");

                        updateCounter();
                        updateGridData();
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
