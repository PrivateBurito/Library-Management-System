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
            NameBox = new TextBox();
            SuspendLayout();
            // 
            // OkButton
            // 
            OkButton.DialogResult = DialogResult.OK;
            OkButton.Location = new Point(441, 242);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(75, 23);
            OkButton.TabIndex = 0;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(212, 122);
            NameBox.Name = "NameBox";
            NameBox.PlaceholderText = "Name";
            NameBox.Size = new Size(100, 23);
            NameBox.TabIndex = 1;
            // 
            // SelectUserBorrow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 277);
            Controls.Add(NameBox);
            Controls.Add(OkButton);
            Name = "SelectUserBorrow";
            Text = "SelectUserBorrow";
            Load += SelectUserBorrow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OkButton;
        private TextBox NameBox;
    }
}