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
            dataGridView1 = new DataGridView();
            BookDropDown = new ComboBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(94, 251);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Add Book";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(554, 176);
            dataGridView1.TabIndex = 1;
            // 
            // BookDropDown
            // 
            BookDropDown.FormattingEnabled = true;
            BookDropDown.Items.AddRange(new object[] { "item1", "item2" });
            BookDropDown.Location = new Point(27, 222);
            BookDropDown.Name = "BookDropDown";
            BookDropDown.Size = new Size(121, 23);
            BookDropDown.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 222);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Quantity";
            textBox1.Size = new Size(77, 23);
            textBox1.TabIndex = 4;
            // 
            // AddToInvetoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 338);
            Controls.Add(textBox1);
            Controls.Add(BookDropDown);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "AddToInvetoryForm";
            Text = "AddToInvetoryForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private ComboBox BookDropDown;
        private TextBox textBox1;
    }
}