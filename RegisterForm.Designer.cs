namespace Library_Management
{
    partial class RegisterForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            FirstNameBox = new TextBox();
            MidNameBox = new TextBox();
            LastNameBox = new TextBox();
            UsernameBox = new TextBox();
            PasswordBox = new TextBox();
            RegisterButton = new Button();
            BackButton = new Button();
            EmailBox = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 45);
            label1.Name = "label1";
            label1.Size = new Size(278, 30);
            label1.TabIndex = 0;
            label1.Text = "Enter registration credentials";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 91);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 1;
            label2.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 247);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 2;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(54, 169);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 3;
            label4.Text = "Last Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(54, 130);
            label5.Name = "label5";
            label5.Size = new Size(107, 21);
            label5.TabIndex = 4;
            label5.Text = "Middle Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(54, 286);
            label6.Name = "label6";
            label6.Size = new Size(79, 21);
            label6.TabIndex = 5;
            label6.Text = "Password:";
            // 
            // FirstNameBox
            // 
            FirstNameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FirstNameBox.Location = new Point(173, 87);
            FirstNameBox.Name = "FirstNameBox";
            FirstNameBox.PlaceholderText = "Juan";
            FirstNameBox.Size = new Size(224, 29);
            FirstNameBox.TabIndex = 0;
            // 
            // MidNameBox
            // 
            MidNameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MidNameBox.Location = new Point(173, 126);
            MidNameBox.Name = "MidNameBox";
            MidNameBox.PlaceholderText = "C.";
            MidNameBox.Size = new Size(224, 29);
            MidNameBox.TabIndex = 1;
            // 
            // LastNameBox
            // 
            LastNameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LastNameBox.Location = new Point(173, 165);
            LastNameBox.Name = "LastNameBox";
            LastNameBox.PlaceholderText = "Cruz";
            LastNameBox.Size = new Size(224, 29);
            LastNameBox.TabIndex = 2;
            // 
            // UsernameBox
            // 
            UsernameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameBox.Location = new Point(173, 243);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.PlaceholderText = "MyUsername";
            UsernameBox.Size = new Size(224, 29);
            UsernameBox.TabIndex = 4;
            // 
            // PasswordBox
            // 
            PasswordBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordBox.Location = new Point(173, 282);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PlaceholderText = "Example.,123";
            PasswordBox.Size = new Size(224, 29);
            PasswordBox.TabIndex = 5;
            // 
            // RegisterButton
            // 
            RegisterButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegisterButton.Location = new Point(322, 326);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(75, 23);
            RegisterButton.TabIndex = 6;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackButton.Location = new Point(58, 326);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 7;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // EmailBox
            // 
            EmailBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailBox.Location = new Point(173, 204);
            EmailBox.Name = "EmailBox";
            EmailBox.PlaceholderText = "example@email.com";
            EmailBox.Size = new Size(224, 29);
            EmailBox.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(54, 208);
            label7.Name = "label7";
            label7.Size = new Size(51, 21);
            label7.TabIndex = 14;
            label7.Text = "Email:";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 408);
            Controls.Add(label7);
            Controls.Add(EmailBox);
            Controls.Add(BackButton);
            Controls.Add(RegisterButton);
            Controls.Add(PasswordBox);
            Controls.Add(UsernameBox);
            Controls.Add(LastNameBox);
            Controls.Add(MidNameBox);
            Controls.Add(FirstNameBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "Register";
            FormClosed += RegisterForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox FirstNameBox;
        private TextBox MidNameBox;
        private TextBox LastNameBox;
        private TextBox UsernameBox;
        private TextBox PasswordBox;
        private Button RegisterButton;
        private Button BackButton;
        private TextBox EmailBox;
        private Label label7;
    }
}