namespace Library_Management.Borrow_Forms
{
    partial class SelectUserBorrow
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
            OkButton = new Button();
            UserGrid = new DataGridView();
            groupBox1 = new GroupBox();
            EmailLabel = new Label();
            label1 = new Label();
            LastNameLabel = new Label();
            FirstNameLabel = new Label();
            UsernameLabel = new Label();
            MiddleNameLabel = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)UserGrid).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // OkButton
            // 
            OkButton.DialogResult = DialogResult.OK;
            OkButton.Location = new Point(594, 242);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(75, 23);
            OkButton.TabIndex = 0;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // UserGrid
            // 
            UserGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserGrid.Location = new Point(12, 12);
            UserGrid.Name = "UserGrid";
            UserGrid.Size = new Size(420, 253);
            UserGrid.TabIndex = 2;
            UserGrid.CellClick += UserGrid_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(EmailLabel);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(LastNameLabel);
            groupBox1.Controls.Add(FirstNameLabel);
            groupBox1.Controls.Add(UsernameLabel);
            groupBox1.Controls.Add(MiddleNameLabel);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(438, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(231, 107);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected User Information";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 9F);
            EmailLabel.Location = new Point(103, 79);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(36, 15);
            EmailLabel.TabIndex = 9;
            EmailLabel.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 79);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 8;
            label1.Text = "Email:";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Segoe UI", 9F);
            LastNameLabel.Location = new Point(102, 64);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(63, 15);
            LastNameLabel.TabIndex = 7;
            LastNameLabel.Text = "Last Name";
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI", 9F);
            FirstNameLabel.Location = new Point(102, 34);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(64, 15);
            FirstNameLabel.TabIndex = 6;
            FirstNameLabel.Text = "First Name";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI", 9F);
            UsernameLabel.Location = new Point(102, 19);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(60, 15);
            UsernameLabel.TabIndex = 5;
            UsernameLabel.Text = "Username";
            // 
            // MiddleNameLabel
            // 
            MiddleNameLabel.AutoSize = true;
            MiddleNameLabel.Font = new Font("Segoe UI", 9F);
            MiddleNameLabel.Location = new Point(102, 49);
            MiddleNameLabel.Name = "MiddleNameLabel";
            MiddleNameLabel.Size = new Size(79, 15);
            MiddleNameLabel.TabIndex = 4;
            MiddleNameLabel.Text = "Middle Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 64);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 3;
            label5.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 49);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 2;
            label4.Text = "Middle Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 34);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 1;
            label3.Text = "First Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 19);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 0;
            label6.Text = "Username:";
            // 
            // SelectUserBorrow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 277);
            Controls.Add(groupBox1);
            Controls.Add(UserGrid);
            Controls.Add(OkButton);
            Name = "SelectUserBorrow";
            Text = "SelectUserBorrow";
            Load += SelectUserBorrow_Load;
            ((System.ComponentModel.ISupportInitialize)UserGrid).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button OkButton;
        private DataGridView UserGrid;
        private GroupBox groupBox1;
        private Label LastNameLabel;
        private Label FirstNameLabel;
        private Label UsernameLabel;
        private Label MiddleNameLabel;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label1;
        private Label EmailLabel;
    }
}