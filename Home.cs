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
    public partial class Home : Form
    {
        string connectionString = "Host=localhost;Port=5432;Database=librarymanage;Username=postgres;Password=12345678;";
        int userID = 1;
        string? username = "";
        public Home(string userID)
        {
            this.userID = int.Parse(userID);
            InitializeComponent();
        }

        private void AddBooksButton_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            accessUserID();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Close();
        }

        private void accessUserID()
        {

            using (Npgsql.NpgsqlConnection conn = new Npgsql.NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE id = @id";
                try
                {
                    using (Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("id", userID);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                username = reader["username"].ToString();
                                if (username is null)
                                {
                                    MessageBox.Show("Something went wrong!");
                                }
                                WelcomeLabel.Text = "Welcome back, " + username;
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
}
