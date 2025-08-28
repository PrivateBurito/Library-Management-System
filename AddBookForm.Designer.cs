namespace Library_Management
{
    partial class AddBookForm
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
            dataGridView1 = new DataGridView();
            DeleteButton = new Button();
            addBooksButton = new Button();
            deleteIDBox = new TextBox();
            BookCountLabel = new Label();
            NameBox = new TextBox();
            YearBox = new TextBox();
            AuthorBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(197, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(489, 235);
            dataGridView1.TabIndex = 15;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(65, 248);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 17;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // addBooksButton
            // 
            addBooksButton.Location = new Point(65, 164);
            addBooksButton.Name = "addBooksButton";
            addBooksButton.Size = new Size(75, 23);
            addBooksButton.TabIndex = 10;
            addBooksButton.Text = "Add";
            addBooksButton.UseVisualStyleBackColor = true;
            addBooksButton.Click += addBooksButton_Click;
            // 
            // deleteIDBox
            // 
            deleteIDBox.Location = new Point(52, 219);
            deleteIDBox.Name = "deleteIDBox";
            deleteIDBox.PlaceholderText = "Enter ID";
            deleteIDBox.Size = new Size(100, 23);
            deleteIDBox.TabIndex = 16;
            // 
            // BookCountLabel
            // 
            BookCountLabel.AutoSize = true;
            BookCountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BookCountLabel.Location = new Point(29, 29);
            BookCountLabel.Name = "BookCountLabel";
            BookCountLabel.Size = new Size(146, 21);
            BookCountLabel.TabIndex = 11;
            BookCountLabel.Text = "Books Registered: 0";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(52, 63);
            NameBox.Name = "NameBox";
            NameBox.PlaceholderText = "Name";
            NameBox.Size = new Size(100, 23);
            NameBox.TabIndex = 12;
            // 
            // YearBox
            // 
            YearBox.Location = new Point(52, 135);
            YearBox.Name = "YearBox";
            YearBox.PlaceholderText = "Year Pub.";
            YearBox.Size = new Size(100, 23);
            YearBox.TabIndex = 14;
            // 
            // AuthorBox
            // 
            AuthorBox.Location = new Point(52, 99);
            AuthorBox.Name = "AuthorBox";
            AuthorBox.PlaceholderText = "Author";
            AuthorBox.Size = new Size(100, 23);
            AuthorBox.TabIndex = 13;
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 327);
            Controls.Add(dataGridView1);
            Controls.Add(DeleteButton);
            Controls.Add(addBooksButton);
            Controls.Add(deleteIDBox);
            Controls.Add(BookCountLabel);
            Controls.Add(NameBox);
            Controls.Add(YearBox);
            Controls.Add(AuthorBox);
            Name = "AddBookForm";
            Text = "Add Book";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button DeleteButton;
        private Button addBooksButton;
        private TextBox deleteIDBox;
        private Label BookCountLabel;
        private TextBox NameBox;
        private TextBox YearBox;
        private TextBox AuthorBox;
    }
}