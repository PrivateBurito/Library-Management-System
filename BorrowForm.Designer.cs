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
            DueDatePicker = new DateTimePicker();
            label2 = new Label();
            label7 = new Label();
            label8 = new Label();
            BorrowGroupBox = new GroupBox();
            ModifyBorrow = new GroupBox();
            StateBox = new ComboBox();
            label9 = new Label();
            BorrowBox = new TextBox();
            ModifyButton = new Button();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)BorrowGrid).BeginInit();
            groupBox1.SuspendLayout();
            BorrowGroupBox.SuspendLayout();
            ModifyBorrow.SuspendLayout();
            SuspendLayout();
            // 
            // BorrowGrid
            // 
            BorrowGrid.AllowUserToAddRows = false;
            BorrowGrid.AllowUserToDeleteRows = false;
            BorrowGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BorrowGrid.Location = new Point(23, 32);
            BorrowGrid.Name = "BorrowGrid";
            BorrowGrid.Size = new Size(422, 141);
            BorrowGrid.TabIndex = 1;
            BorrowGrid.CellClick += BorrowGrid_CellClick;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Segoe UI", 9F);
            AddButton.Location = new Point(97, 123);
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
            groupBox1.Location = new Point(451, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(255, 141);
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
            NameBox.Font = new Font("Segoe UI", 9F);
            NameBox.Location = new Point(78, 25);
            NameBox.Name = "NameBox";
            NameBox.PlaceholderText = "User";
            NameBox.Size = new Size(91, 23);
            NameBox.TabIndex = 10;
            // 
            // BookBox
            // 
            BookBox.Font = new Font("Segoe UI", 9F);
            BookBox.Location = new Point(78, 54);
            BookBox.Name = "BookBox";
            BookBox.PlaceholderText = "Book";
            BookBox.Size = new Size(91, 23);
            BookBox.TabIndex = 11;
            // 
            // SelectUserButton
            // 
            SelectUserButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectUserButton.Location = new Point(175, 25);
            SelectUserButton.Name = "SelectUserButton";
            SelectUserButton.Size = new Size(91, 23);
            SelectUserButton.TabIndex = 12;
            SelectUserButton.Text = "Select User";
            SelectUserButton.UseVisualStyleBackColor = true;
            SelectUserButton.Click += SelectUserButton_Click;
            // 
            // SelectBookButton
            // 
            SelectBookButton.Font = new Font("Segoe UI", 9F);
            SelectBookButton.Location = new Point(175, 54);
            SelectBookButton.Name = "SelectBookButton";
            SelectBookButton.Size = new Size(91, 23);
            SelectBookButton.TabIndex = 13;
            SelectBookButton.Text = "Select Book";
            SelectBookButton.UseVisualStyleBackColor = true;
            SelectBookButton.Click += SelectBookButton_Click;
            // 
            // DueDatePicker
            // 
            DueDatePicker.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DueDatePicker.Location = new Point(78, 83);
            DueDatePicker.Name = "DueDatePicker";
            DueDatePicker.Size = new Size(188, 23);
            DueDatePicker.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(6, 29);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 15;
            label2.Text = "Username:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(6, 58);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 16;
            label7.Text = "Book ID:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(6, 87);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 17;
            label8.Text = "Due Date:";
            // 
            // BorrowGroupBox
            // 
            BorrowGroupBox.Controls.Add(label2);
            BorrowGroupBox.Controls.Add(label8);
            BorrowGroupBox.Controls.Add(NameBox);
            BorrowGroupBox.Controls.Add(AddButton);
            BorrowGroupBox.Controls.Add(label7);
            BorrowGroupBox.Controls.Add(BookBox);
            BorrowGroupBox.Controls.Add(SelectUserButton);
            BorrowGroupBox.Controls.Add(DueDatePicker);
            BorrowGroupBox.Controls.Add(SelectBookButton);
            BorrowGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BorrowGroupBox.Location = new Point(24, 188);
            BorrowGroupBox.Name = "BorrowGroupBox";
            BorrowGroupBox.Size = new Size(275, 168);
            BorrowGroupBox.TabIndex = 18;
            BorrowGroupBox.TabStop = false;
            BorrowGroupBox.Text = "Add Borrow";
            // 
            // ModifyBorrow
            // 
            ModifyBorrow.Controls.Add(StateBox);
            ModifyBorrow.Controls.Add(label9);
            ModifyBorrow.Controls.Add(BorrowBox);
            ModifyBorrow.Controls.Add(ModifyButton);
            ModifyBorrow.Controls.Add(label11);
            ModifyBorrow.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ModifyBorrow.Location = new Point(328, 188);
            ModifyBorrow.Name = "ModifyBorrow";
            ModifyBorrow.Size = new Size(178, 168);
            ModifyBorrow.TabIndex = 19;
            ModifyBorrow.TabStop = false;
            ModifyBorrow.Text = "Modify Borrow";
            // 
            // StateBox
            // 
            StateBox.Font = new Font("Segoe UI", 9F);
            StateBox.FormattingEnabled = true;
            StateBox.Location = new Point(78, 55);
            StateBox.Name = "StateBox";
            StateBox.Size = new Size(91, 23);
            StateBox.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(6, 29);
            label9.Name = "label9";
            label9.Size = new Size(68, 15);
            label9.TabIndex = 15;
            label9.Text = "Borrow ID:";
            // 
            // BorrowBox
            // 
            BorrowBox.Font = new Font("Segoe UI", 9F);
            BorrowBox.Location = new Point(78, 25);
            BorrowBox.Name = "BorrowBox";
            BorrowBox.PlaceholderText = "Borrow ID";
            BorrowBox.Size = new Size(91, 23);
            BorrowBox.TabIndex = 10;
            // 
            // ModifyButton
            // 
            ModifyButton.Font = new Font("Segoe UI", 9F);
            ModifyButton.Location = new Point(78, 87);
            ModifyButton.Name = "ModifyButton";
            ModifyButton.Size = new Size(91, 23);
            ModifyButton.TabIndex = 2;
            ModifyButton.Text = "Modify";
            ModifyButton.UseVisualStyleBackColor = true;
            ModifyButton.Click += ModifyButton_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(6, 58);
            label11.Name = "label11";
            label11.Size = new Size(40, 15);
            label11.TabIndex = 16;
            label11.Text = "State:";
            // 
            // BorrowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 381);
            Controls.Add(ModifyBorrow);
            Controls.Add(BorrowGroupBox);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(BorrowGrid);
            Name = "BorrowForm";
            Text = "BorrowForm";
            Load += BorrowForm_Load;
            ((System.ComponentModel.ISupportInitialize)BorrowGrid).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            BorrowGroupBox.ResumeLayout(false);
            BorrowGroupBox.PerformLayout();
            ModifyBorrow.ResumeLayout(false);
            ModifyBorrow.PerformLayout();
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
        private DateTimePicker DueDatePicker;
        private Label label2;
        private Label label7;
        private Label label8;
        private GroupBox BorrowGroupBox;
        private GroupBox ModifyBorrow;
        private Label label9;
        private TextBox BorrowBox;
        private Button ModifyButton;
        private Label label11;
        private ComboBox StateBox;
    }
}