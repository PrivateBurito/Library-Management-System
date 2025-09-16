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
    public partial class AddToInvetoryForm : Form
    {
        string connectionString = "Host=localhost;Port=5432;Database=librarymanage;Username=postgres;Password=12345678;";

        public AddToInvetoryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
                DataGridViewCell clickedCell = BookGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                object cellValue = clickedCell.Value;
                BookTextBox.Text = cellValue.ToString();
            }
        }
    }
}
