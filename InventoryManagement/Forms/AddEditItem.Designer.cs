namespace InventoryManagement.Forms
{
    partial class AddEditItem
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
            idTextBox = new TextBox();
            label2 = new Label();
            nameTextBox = new TextBox();
            label3 = new Label();
            priceNumeric = new NumericUpDown();
            label4 = new Label();
            quantityNumeric = new NumericUpDown();
            label5 = new Label();
            categoryComboBox = new ComboBox();
            label6 = new Label();
            descriptionTextBox = new TextBox();
            okButton = new Button();
            ((System.ComponentModel.ISupportInitialize)priceNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quantityNumeric).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(28, 21);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(12, 43);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(206, 25);
            idTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 110);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(206, 25);
            nameTextBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(239, 90);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 0;
            label3.Text = "Price:";
            // 
            // priceNumeric
            // 
            priceNumeric.Location = new Point(239, 110);
            priceNumeric.Name = "priceNumeric";
            priceNumeric.Size = new Size(206, 25);
            priceNumeric.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(239, 23);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 0;
            label4.Text = "Quantity:";
            // 
            // quantityNumeric
            // 
            quantityNumeric.Location = new Point(239, 44);
            quantityNumeric.Name = "quantityNumeric";
            quantityNumeric.Size = new Size(206, 25);
            quantityNumeric.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 155);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 0;
            label5.Text = "Category:";
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(12, 175);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(206, 25);
            categoryComboBox.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(239, 155);
            label6.Name = "label6";
            label6.Size = new Size(92, 21);
            label6.TabIndex = 0;
            label6.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(239, 175);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(206, 25);
            descriptionTextBox.TabIndex = 1;
            // 
            // okButton
            // 
            okButton.Location = new Point(127, 210);
            okButton.Name = "okButton";
            okButton.Size = new Size(206, 26);
            okButton.TabIndex = 4;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // AddEditItem
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 248);
            Controls.Add(okButton);
            Controls.Add(categoryComboBox);
            Controls.Add(quantityNumeric);
            Controls.Add(priceNumeric);
            Controls.Add(descriptionTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(idTextBox);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "AddEditItem";
            Text = "AddEditItem";
            ((System.ComponentModel.ISupportInitialize)priceNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantityNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox idTextBox;
        private Label label2;
        private TextBox nameTextBox;
        private Label label3;
        private NumericUpDown priceNumeric;
        private Label label4;
        private NumericUpDown quantityNumeric;
        private Label label5;
        private ComboBox categoryComboBox;
        private Label label6;
        private TextBox descriptionTextBox;
        private Button okButton;
    }
}