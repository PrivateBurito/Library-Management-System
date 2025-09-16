namespace Library_Management
{
    partial class AddToInvetoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            InventoryGrid = new DataGridView();
            textBox1 = new TextBox();
            BookGrid = new DataGridView();
            BookTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)InventoryGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BookGrid).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(172, 261);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Add Book";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // InventoryGrid
            // 
            InventoryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InventoryGrid.Location = new Point(320, 12);
            InventoryGrid.Name = "InventoryGrid";
            InventoryGrid.Size = new Size(271, 176);
            InventoryGrid.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 222);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Quantity";
            textBox1.Size = new Size(77, 23);
            textBox1.TabIndex = 4;
            // 
            // BookGrid
            // 
            BookGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookGrid.Location = new Point(27, 12);
            BookGrid.Name = "BookGrid";
            BookGrid.Size = new Size(271, 176);
            BookGrid.TabIndex = 6;
            BookGrid.CellClick += BookGrid_CellClick;
            // 
            // BookTextBox
            // 
            BookTextBox.Location = new Point(27, 222);
            BookTextBox.Name = "BookTextBox";
            BookTextBox.PlaceholderText = "Input Book ID Here";
            BookTextBox.Size = new Size(139, 23);
            BookTextBox.TabIndex = 7;
            // 
            // AddToInvetoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 338);
            Controls.Add(BookTextBox);
            Controls.Add(BookGrid);
            Controls.Add(textBox1);
            Controls.Add(InventoryGrid);
            Controls.Add(button1);
            Name = "AddToInvetoryForm";
            Text = "Add to Inventory";
            Load += AddToInvetoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)InventoryGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)BookGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView InventoryGrid;
        private TextBox textBox1;
        private Label label1;
        private DataGridView BookGrid;
        private TextBox BookTextBox;
    }
}