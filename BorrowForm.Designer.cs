namespace Library_Management
{
    partial class BorrowForm
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
            BorrowGrid = new DataGridView();
            AddButton = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            IDLabel = new Label();
            AuthorLabel = new Label();
            BookNameLabel = new Label();
            YearPublishedLabel = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            NameBox = new TextBox();
            BookBox = new TextBox();
            SelectUserButton = new Button();
            SelectBookButton = new Button();
            QuantityBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)BorrowGrid).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BorrowGrid
            // 
            BorrowGrid.AllowUserToAddRows = false;
            BorrowGrid.AllowUserToDeleteRows = false;
            BorrowGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BorrowGrid.Location = new Point(23, 32);
            BorrowGrid.Name = "BorrowGrid";
            BorrowGrid.Size = new Size(333, 141);
            BorrowGrid.TabIndex = 1;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(154, 257);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(91, 23);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 3;
            label1.Text = "Borrows";
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
            groupBox1.Controls.Add(label6);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(373, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(333, 141);
            groupBox1.TabIndex = 9;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 19);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 0;
            label6.Text = "Name:";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(23, 199);
            NameBox.Name = "NameBox";
            NameBox.PlaceholderText = "User";
            NameBox.Size = new Size(125, 23);
            NameBox.TabIndex = 10;
            // 
            // BookBox
            // 
            BookBox.Location = new Point(23, 228);
            BookBox.Name = "BookBox";
            BookBox.PlaceholderText = "Book";
            BookBox.Size = new Size(125, 23);
            BookBox.TabIndex = 11;
            // 
            // SelectUserButton
            // 
            SelectUserButton.Location = new Point(154, 198);
            SelectUserButton.Name = "SelectUserButton";
            SelectUserButton.Size = new Size(91, 23);
            SelectUserButton.TabIndex = 12;
            SelectUserButton.Text = "Select User";
            SelectUserButton.UseVisualStyleBackColor = true;
            SelectUserButton.Click += SelectUserButton_Click;
            // 
            // SelectBookButton
            // 
            SelectBookButton.Location = new Point(154, 228);
            SelectBookButton.Name = "SelectBookButton";
            SelectBookButton.Size = new Size(91, 23);
            SelectBookButton.TabIndex = 13;
            SelectBookButton.Text = "Select Book";
            SelectBookButton.UseVisualStyleBackColor = true;
            SelectBookButton.Click += SelectBookButton_Click;
            // 
            // QuantityBox
            // 
            QuantityBox.Location = new Point(23, 257);
            QuantityBox.Name = "QuantityBox";
            QuantityBox.PlaceholderText = "Quantity";
            QuantityBox.Size = new Size(100, 23);
            QuantityBox.TabIndex = 14;
            // 
            // BorrowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 314);
            Controls.Add(QuantityBox);
            Controls.Add(SelectBookButton);
            Controls.Add(SelectUserButton);
            Controls.Add(BookBox);
            Controls.Add(NameBox);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(AddButton);
            Controls.Add(BorrowGrid);
            Name = "BorrowForm";
            Text = "BorrowForm";
            Load += BorrowForm_Load;
            ((System.ComponentModel.ISupportInitialize)BorrowGrid).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView BorrowGrid;
        private Button AddButton;
        private Label label1;
        private GroupBox groupBox1;
        private Label IDLabel;
        private Label AuthorLabel;
        private Label BookNameLabel;
        private Label YearPublishedLabel;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private TextBox NameBox;
        private TextBox BookBox;
        private Button SelectUserButton;
        private Button SelectBookButton;
        private TextBox QuantityBox;
    }
}