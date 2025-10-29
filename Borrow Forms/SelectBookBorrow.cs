using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management.Borrow_Forms
{
    public partial class SelectBookBorrow : Form
    {
        string connectionString = "Host=localhost;Port=5432;Database=librarymanage;Username=postgres;Password=12345678;";
        public string barcodeIDReturn { get; set; }
        public SelectBookBorrow()
        {
            InitializeComponent();
        }

        private void SelectBookBorrow_Load(object sender, EventArgs e)
        {
            updateBookGrid();
        }

        private void updateInfoLabels(string barcode_idString)
        {
            int barcode_id = int.Parse(barcode_idString);
            using (Npgsql.NpgsqlConnection connection = new Npgsql.NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT name, author, year FROM books WHERE barcode_id = @barcode_id";
                try
                {
                    using (Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("barcode_id", barcode_id);
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
                                IDLabel.Text = barcode_idString;
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

        private void BookGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell clickedCell = BookGrid.Rows[e.RowIndex].Cells[0];

                object cellValue = clickedCell.Value;
                string? cellValueString = cellValue.ToString();
                if (string.IsNullOrEmpty(cellValueString)) { return; }
                BookGrid.Text = cellValueString;
                barcodeIDReturn = cellValueString;
                updateInfoLabels(cellValueString);
            }
        }

        private void updateBookGrid()
        {
            BindingSource bindingSource = new BindingSource();
            string query = "SELECT barcode_id, name, quantity FROM inventory";
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
    }
}
