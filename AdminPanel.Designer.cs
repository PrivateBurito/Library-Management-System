namespace Library_Management
{
    partial class AdminPanel
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
            AddBooksButton = new Button();
            AddInventoryButton = new Button();
            SuspendLayout();
            // 
            // AddBooksButton
            // 
            AddBooksButton.Location = new Point(63, 199);
            AddBooksButton.Name = "AddBooksButton";
            AddBooksButton.Size = new Size(75, 75);
            AddBooksButton.TabIndex = 0;
            AddBooksButton.Text = "Add Books";
            AddBooksButton.UseVisualStyleBackColor = true;
            AddBooksButton.Click += AddBooksButton_Click;
            // 
            // AddInventoryButton
            // 
            AddInventoryButton.Location = new Point(173, 199);
            AddInventoryButton.Name = "AddInventoryButton";
            AddInventoryButton.Size = new Size(75, 75);
            AddInventoryButton.TabIndex = 1;
            AddInventoryButton.Text = "Add to Inventory";
            AddInventoryButton.UseVisualStyleBackColor = true;
            AddInventoryButton.Click += AddInventoryButton_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 286);
            Controls.Add(AddInventoryButton);
            Controls.Add(AddBooksButton);
            Name = "AdminPanel";
            Text = "AdminPanel";
            ResumeLayout(false);
        }

        #endregion

        private Button AddBooksButton;
        private Button AddInventoryButton;
    }
}