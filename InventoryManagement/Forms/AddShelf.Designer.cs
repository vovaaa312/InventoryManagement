namespace InventoryManagement.Forms
{
    partial class AddShelf
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
            nameTextBox = new TextBox();
            categoryComboBox = new ComboBox();
            label1 = new Label();
            okButton = new Button();
            label2 = new Label();
            capacityUpDown = new NumericUpDown();
            label3 = new Label();
            idTtextBox = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)capacityUpDown).BeginInit();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(8, 86);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(205, 23);
            nameTextBox.TabIndex = 0;
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(8, 135);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(205, 23);
            categoryComboBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(8, 63);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // okButton
            // 
            okButton.Location = new Point(9, 213);
            okButton.Name = "okButton";
            okButton.Size = new Size(205, 23);
            okButton.TabIndex = 4;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(9, 112);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 5;
            label2.Text = "Category:";
            // 
            // capacityUpDown
            // 
            capacityUpDown.Location = new Point(8, 184);
            capacityUpDown.Name = "capacityUpDown";
            capacityUpDown.Size = new Size(205, 23);
            capacityUpDown.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(8, 161);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 5;
            label3.Text = "Capacity:";
            // 
            // idTtextBox
            // 
            idTtextBox.Location = new Point(8, 37);
            idTtextBox.Name = "idTtextBox";
            idTtextBox.Size = new Size(205, 23);
            idTtextBox.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(8, 14);
            label4.Name = "label4";
            label4.Size = new Size(27, 20);
            label4.TabIndex = 2;
            label4.Text = "ID:";
            // 
            // AddShelf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(225, 257);
            Controls.Add(capacityUpDown);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(okButton);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(categoryComboBox);
            Controls.Add(idTtextBox);
            Controls.Add(nameTextBox);
            Name = "AddShelf";
            Text = "AddShelf";
            ((System.ComponentModel.ISupportInitialize)capacityUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private ComboBox categoryComboBox;
        private Label label1;
        private Button okButton;
        private Label label2;
        private NumericUpDown capacityUpDown;
        private Label label3;
        private TextBox idTtextBox;
        private Label label4;
    }
}