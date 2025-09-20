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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Host=localhost;Port=5432;Database=librarymanage;Username=postgres;Password=12345678;";
            using (Npgsql.NpgsqlConnection connection = new Npgsql.NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string pword = PasswordBox.Text.Trim();
                    string query = "INSERT INTO users (username, password_hash, first_name, middle_name, last_name, is_admin, email) " +
                        " VALUES (@username, crypt('" + pword + "', gen_salt('bf', 10)), @fName, @mName, @lName, @admin, @email)";

                    using (Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", UsernameBox.Text.Trim());
                        command.Parameters.AddWithValue("@fName", FirstNameBox.Text.Trim());
                        command.Parameters.AddWithValue("@mName", MidNameBox.Text.Trim());
                        command.Parameters.AddWithValue("@lName", LastNameBox.Text.Trim());
                        command.Parameters.AddWithValue("@admin", false);
                        command.Parameters.AddWithValue("@email", EmailBox.Text.Trim());

                        command.ExecuteNonQuery();

                        MessageBox.Show("Success");
                        this.Close();
                    }
                }
                catch (Npgsql.NpgsqlException ex)
                {
                    MessageBox.Show("Error connecting to PostgeSQL: " + ex.Message);
                }
            }
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
