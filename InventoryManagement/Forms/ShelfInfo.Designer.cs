namespace InventoryManagement.Forms
{
    partial class ShelfInfo
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
            okButton = new Button();
            idLabel = new Label();
            nameLabel = new Label();
            countLabel = new Label();
            capacityLabel = new Label();
            categoryLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 23);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 59);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(19, 98);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 0;
            label3.Text = "Count:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(19, 139);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 0;
            label4.Text = "Capacity:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(19, 182);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 0;
            label5.Text = "Category:";
            // 
            // okButton
            // 
            okButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            okButton.Location = new Point(19, 233);
            okButton.Name = "okButton";
            okButton.Size = new Size(230, 21);
            okButton.TabIndex = 1;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            idLabel.Location = new Point(136, 23);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(0, 25);
            idLabel.TabIndex = 0;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(136, 59);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(0, 25);
            nameLabel.TabIndex = 0;
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            countLabel.Location = new Point(136, 98);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(0, 25);
            countLabel.TabIndex = 0;
            // 
            // capacityLabel
            // 
            capacityLabel.AutoSize = true;
            capacityLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            capacityLabel.Location = new Point(136, 139);
            capacityLabel.Name = "capacityLabel";
            capacityLabel.Size = new Size(0, 25);
            capacityLabel.TabIndex = 0;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            categoryLabel.Location = new Point(136, 182);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(0, 25);
            categoryLabel.TabIndex = 0;
            // 
            // ShelfInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 266);
            Controls.Add(okButton);
            Controls.Add(categoryLabel);
            Controls.Add(label5);
            Controls.Add(capacityLabel);
            Controls.Add(label4);
            Controls.Add(countLabel);
            Controls.Add(label3);
            Controls.Add(nameLabel);
            Controls.Add(label2);
            Controls.Add(idLabel);
            Controls.Add(label1);
            Name = "ShelfInfo";
            Text = "ShelfInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button okButton;
        private Label idLabel;
        private Label nameLabel;
        private Label countLabel;
        private Label capacityLabel;
        private Label categoryLabel;
    }
}