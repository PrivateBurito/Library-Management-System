using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management.Borrow_Forms
{

    public partial class SelectUserBorrow : Form
    {
        public string userReturned {
            get;
            set;
        }

        public SelectUserBorrow()
        {

            InitializeComponent();
        }

        private void SelectUserBorrow_Load(object sender, EventArgs e)
        {

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            userReturned = NameBox.Text.Trim();
        }
    }
}
