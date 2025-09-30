namespace Library_Management.Borrow_Forms
{
    partial class SelectBookBorrow
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
            BookGrid = new DataGridView();
            groupBox1 = new GroupBox();
            IDLabel = new Label();
            AuthorLabel = new Label();
            BookNameLabel = new Label();
            YearPublishedLabel = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            OkButton = new Button();
            ((System.ComponentModel.ISupportInitialize)BookGrid).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BookGrid
            // 
            BookGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookGrid.Location = new Point(12, 12);
            BookGrid.Name = "BookGrid";
            BookGrid.Size = new Size(420, 253);
            BookGrid.TabIndex = 0;
            BookGrid.CellClick += BookGrid_CellClick;
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
            groupBox1.Location = new Point(438, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(231, 107);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            // 
            // OkButton
            // 
            OkButton.DialogResult = DialogResult.OK;
            OkButton.Location = new Point(594, 242);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(75, 23);
            OkButton.TabIndex = 10;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = true;
            // 
            // SelectBookBorrow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 277);
            Controls.Add(OkButton);
            Controls.Add(groupBox1);
            Controls.Add(BookGrid);
            Name = "SelectBookBorrow";
            Text = "SelectBookBorrow";
            Load += SelectBookBorrow_Load;
            ((System.ComponentModel.ISupportInitialize)BookGrid).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView BookGrid;
        private GroupBox groupBox1;
        private Label IDLabel;
        private Label AuthorLabel;
        private Label BookNameLabel;
        private Label YearPublishedLabel;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button OkButton;
    }
}