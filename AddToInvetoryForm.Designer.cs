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
            AddBookButton = new Button();
            InventoryGrid = new DataGridView();
            QuantityBox = new TextBox();
            BookGrid = new DataGridView();
            BookTextBox = new TextBox();
            groupBox1 = new GroupBox();
            IDLabel = new Label();
            AuthorLabel = new Label();
            BookNameLabel = new Label();
            YearPublishedLabel = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            DeleteBookButton = new Button();
            ((System.ComponentModel.ISupportInitialize)InventoryGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BookGrid).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // AddBookButton
            // 
            AddBookButton.Location = new Point(172, 251);
            AddBookButton.Name = "AddBookButton";
            AddBookButton.Size = new Size(75, 23);
            AddBookButton.TabIndex = 0;
            AddBookButton.Text = "Add Book";
            AddBookButton.UseVisualStyleBackColor = true;
            AddBookButton.Click += AddBookButton_Click;
            // 
            // InventoryGrid
            // 
            InventoryGrid.AllowUserToAddRows = false;
            InventoryGrid.AllowUserToDeleteRows = false;
            InventoryGrid.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            InventoryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InventoryGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            InventoryGrid.Location = new Point(313, 39);
            InventoryGrid.Name = "InventoryGrid";
            InventoryGrid.Size = new Size(271, 149);
            InventoryGrid.TabIndex = 1;
            InventoryGrid.CellClick += InventoryGrid_CellClick;
            // 
            // QuantityBox
            // 
            QuantityBox.Location = new Point(172, 222);
            QuantityBox.Name = "QuantityBox";
            QuantityBox.PlaceholderText = "Quantity";
            QuantityBox.Size = new Size(77, 23);
            QuantityBox.TabIndex = 4;
            // 
            // BookGrid
            // 
            BookGrid.AllowUserToAddRows = false;
            BookGrid.AllowUserToDeleteRows = false;
            BookGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            BookGrid.Location = new Point(20, 39);
            BookGrid.Name = "BookGrid";
            BookGrid.Size = new Size(271, 149);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(IDLabel);
            groupBox1.Controls.Add(AuthorLabel);
            groupBox1.Controls.Add(BookNameLabel);
            groupBox1.Controls.Add(YearPublishedLabel);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(313, 194);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(271, 132);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected Book Information";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Segoe UI", 9F);
            IDLabel.Location = new Point(102, 66);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(17, 15);
            IDLabel.TabIndex = 7;
            IDLabel.Text = "id";
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.Font = new Font("Segoe UI", 9F);
            AuthorLabel.Location = new Point(102, 36);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(42, 15);
            AuthorLabel.TabIndex = 6;
            AuthorLabel.Text = "author";
            // 
            // BookNameLabel
            // 
            BookNameLabel.AutoSize = true;
            BookNameLabel.Font = new Font("Segoe UI", 9F);
            BookNameLabel.Location = new Point(102, 19);
            BookNameLabel.Name = "BookNameLabel";
            BookNameLabel.Size = new Size(64, 15);
            BookNameLabel.TabIndex = 5;
            BookNameLabel.Text = "bookname";
            // 
            // YearPublishedLabel
            // 
            YearPublishedLabel.AutoSize = true;
            YearPublishedLabel.Font = new Font("Segoe UI", 9F);
            YearPublishedLabel.Location = new Point(102, 51);
            YearPublishedLabel.Name = "YearPublishedLabel";
            YearPublishedLabel.Size = new Size(50, 15);
            YearPublishedLabel.TabIndex = 4;
            YearPublishedLabel.Text = "yearpub";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 66);
            label5.Name = "label5";
            label5.Size = new Size(23, 15);
            label5.TabIndex = 3;
            label5.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 51);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 2;
            label4.Text = "Year Published:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 36);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 1;
            label3.Text = "Author:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 21);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 9;
            label1.Text = "Registered Books";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(313, 21);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 10;
            label6.Text = "Inventory";
            // 
            // DeleteBookButton
            // 
            DeleteBookButton.Location = new Point(172, 280);
            DeleteBookButton.Name = "DeleteBookButton";
            DeleteBookButton.Size = new Size(75, 23);
            DeleteBookButton.TabIndex = 11;
            DeleteBookButton.Text = "Delete";
            DeleteBookButton.UseVisualStyleBackColor = true;
            DeleteBookButton.Click += DeleteBookButton_Click;
            // 
            // AddToInvetoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 338);
            Controls.Add(DeleteBookButton);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(BookTextBox);
            Controls.Add(BookGrid);
            Controls.Add(QuantityBox);
            Controls.Add(InventoryGrid);
            Controls.Add(AddBookButton);
            Name = "AddToInvetoryForm";
            Text = "Add to Inventory";
            Load += AddToInvetoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)InventoryGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)BookGrid).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddBookButton;
        private DataGridView InventoryGrid;
        private TextBox QuantityBox;
        private Label BookNameLabel;
        private DataGridView BookGrid;
        private TextBox BookTextBox;
        private GroupBox groupBox1;
        private Label YearPublishedLabel;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label AuthorLabel;
        private Label IDLabel;
        private Label label1;
        private Label label6;
        private Button DeleteBookButton;
    }
}