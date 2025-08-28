using System.Data;

namespace Library_Management
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string usernameInput = UsernameBox.Text.Trim();
            string passwordInput = PasswordBox.Text.Trim();
            string connectionString = "Host=localhost;Port=5432;Database=librarymanage;Username=postgres;Password=12345678;";
            using (Npgsql.NpgsqlConnection connection = new Npgsql.NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id, username, password_hash FROM users " +
                        "WHERE username =  @username AND" +
                        " password_hash = crypt(@password, password_hash)";
                    using (Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("username", usernameInput);
                        command.Parameters.AddWithValue("password", passwordInput);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string? userLoggedIn = "0";
                                userLoggedIn = reader["id"].ToString();
                                if (userLoggedIn == null)
                                {
                                    MessageBox.Show("Something went wrong!");
                                    return;
                                } else
                                {
                                    Home home = new Home(userLoggedIn);
                                    home.Show();
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid credentials.");
                            }
                        }
                    }
                }
                catch (Npgsql.NpgsqlException ex)
                {
                    MessageBox.Show("Error connecting to PostgeSQL: " + ex.Message);
                }
            }
        }
    }
}
