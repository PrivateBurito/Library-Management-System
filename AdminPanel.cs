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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AddBooksButton_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.ShowDialog();
        }

        private void AddInventoryButton_Click(object sender, EventArgs e)
        {
            AddToInvetoryForm addToInvetoryForm = new AddToInvetoryForm();
            addToInvetoryForm.ShowDialog();
        }
    }
}
