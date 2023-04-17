namespace InventoryManagement
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            itemsDataGridView = new DataGridView();
            IdColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            PriceColumn = new DataGridViewTextBoxColumn();
            QuantityColumn = new DataGridViewTextBoxColumn();
            CategoryColumn = new DataGridViewTextBoxColumn();
            DescriptionColumn = new DataGridViewTextBoxColumn();
            addItemButton = new Button();
            deleteItemButton = new Button();
            editItemButton = new Button();
            searchTextBox = new TextBox();
            searchShelfComboBox = new ComboBox();
            label1 = new Label();
            addShelfButton = new Button();
            deleteShelfButton = new Button();
            shelfProgressBar = new ProgressBar();
            shelfName = new Label();
            shelfInfoButton = new Button();
            shelfProgress = new Label();
            saveButton = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)itemsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // itemsDataGridView
            // 
            itemsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            itemsDataGridView.Columns.AddRange(new DataGridViewColumn[] { IdColumn, NameColumn, PriceColumn, QuantityColumn, CategoryColumn, DescriptionColumn });
            itemsDataGridView.Location = new Point(8, 58);
            itemsDataGridView.Name = "itemsDataGridView";
            itemsDataGridView.RowTemplate.Height = 25;
            itemsDataGridView.Size = new Size(996, 583);
            itemsDataGridView.TabIndex = 0;
            // 
            // IdColumn
            // 
            IdColumn.HeaderText = "ID";
            IdColumn.MinimumWidth = 50;
            IdColumn.Name = "IdColumn";
            IdColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Name";
            NameColumn.MinimumWidth = 150;
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            NameColumn.Width = 200;
            // 
            // PriceColumn
            // 
            PriceColumn.HeaderText = "Price";
            PriceColumn.MinimumWidth = 100;
            PriceColumn.Name = "PriceColumn";
            PriceColumn.ReadOnly = true;
            // 
            // QuantityColumn
            // 
            QuantityColumn.HeaderText = "Quantity";
            QuantityColumn.MinimumWidth = 100;
            QuantityColumn.Name = "QuantityColumn";
            QuantityColumn.ReadOnly = true;
            // 
            // CategoryColumn
            // 
            CategoryColumn.HeaderText = "Category";
            CategoryColumn.MinimumWidth = 120;
            CategoryColumn.Name = "CategoryColumn";
            CategoryColumn.ReadOnly = true;
            CategoryColumn.Width = 150;
            // 
            // DescriptionColumn
            // 
            DescriptionColumn.HeaderText = "Description";
            DescriptionColumn.MinimumWidth = 300;
            DescriptionColumn.Name = "DescriptionColumn";
            DescriptionColumn.ReadOnly = true;
            DescriptionColumn.Width = 400;
            // 
            // addItemButton
            // 
            addItemButton.Location = new Point(1010, 121);
            addItemButton.Name = "addItemButton";
            addItemButton.Size = new Size(112, 26);
            addItemButton.TabIndex = 1;
            addItemButton.Text = "Add item";
            addItemButton.UseVisualStyleBackColor = true;
            addItemButton.Click += addItemButton_Click;
            // 
            // deleteItemButton
            // 
            deleteItemButton.Location = new Point(1010, 187);
            deleteItemButton.Name = "deleteItemButton";
            deleteItemButton.Size = new Size(112, 26);
            deleteItemButton.TabIndex = 2;
            deleteItemButton.Text = "Delete item";
            deleteItemButton.UseVisualStyleBackColor = true;
            deleteItemButton.Click += deleteItemButton_Click;
            // 
            // editItemButton
            // 
            editItemButton.Location = new Point(1010, 154);
            editItemButton.Name = "editItemButton";
            editItemButton.Size = new Size(112, 26);
            editItemButton.TabIndex = 3;
            editItemButton.Text = "Edit item";
            editItemButton.UseVisualStyleBackColor = true;
            editItemButton.Click += editItemButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(10, 19);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(725, 25);
            searchTextBox.TabIndex = 4;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // searchShelfComboBox
            // 
            searchShelfComboBox.FormattingEnabled = true;
            searchShelfComboBox.Location = new Point(792, 19);
            searchShelfComboBox.Name = "searchShelfComboBox";
            searchShelfComboBox.Size = new Size(212, 25);
            searchShelfComboBox.TabIndex = 6;
            searchShelfComboBox.SelectedIndexChanged += searchShelfComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(741, 23);
            label1.Name = "label1";
            label1.Size = new Size(36, 17);
            label1.TabIndex = 7;
            label1.Text = "Shelf";
            // 
            // addShelfButton
            // 
            addShelfButton.Location = new Point(1009, 249);
            addShelfButton.Name = "addShelfButton";
            addShelfButton.Size = new Size(113, 26);
            addShelfButton.TabIndex = 9;
            addShelfButton.Text = "Add shelf";
            addShelfButton.UseVisualStyleBackColor = true;
            addShelfButton.Click += addShelfButton_Click;
            // 
            // deleteShelfButton
            // 
            deleteShelfButton.Location = new Point(1010, 313);
            deleteShelfButton.Name = "deleteShelfButton";
            deleteShelfButton.Size = new Size(113, 26);
            deleteShelfButton.TabIndex = 12;
            deleteShelfButton.Text = "Delete shelf";
            deleteShelfButton.UseVisualStyleBackColor = true;
            deleteShelfButton.Click += deleteShelfButton_Click;
            // 
            // shelfProgressBar
            // 
            shelfProgressBar.Location = new Point(137, 647);
            shelfProgressBar.Name = "shelfProgressBar";
            shelfProgressBar.Size = new Size(202, 19);
            shelfProgressBar.TabIndex = 13;
            // 
            // shelfName
            // 
            shelfName.AutoSize = true;
            shelfName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            shelfName.Location = new Point(8, 647);
            shelfName.Name = "shelfName";
            shelfName.Size = new Size(43, 17);
            shelfName.TabIndex = 14;
            shelfName.Text = "Name";
            // 
            // shelfInfoButton
            // 
            shelfInfoButton.Location = new Point(1009, 281);
            shelfInfoButton.Name = "shelfInfoButton";
            shelfInfoButton.Size = new Size(113, 26);
            shelfInfoButton.TabIndex = 12;
            shelfInfoButton.Text = "Shelf Info";
            shelfInfoButton.UseVisualStyleBackColor = true;
            shelfInfoButton.Click += shelfInfoButton_Click;
            // 
            // shelfProgress
            // 
            shelfProgress.AutoSize = true;
            shelfProgress.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            shelfProgress.Location = new Point(68, 647);
            shelfProgress.Name = "shelfProgress";
            shelfProgress.Size = new Size(63, 17);
            shelfProgress.TabIndex = 15;
            shelfProgress.Text = "Progress:";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(1009, 376);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(113, 26);
            saveButton.TabIndex = 12;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1010, 409);
            button1.Name = "button1";
            button1.Size = new Size(113, 26);
            button1.TabIndex = 12;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += loadButton_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 678);
            Controls.Add(shelfProgress);
            Controls.Add(shelfName);
            Controls.Add(shelfProgressBar);
            Controls.Add(button1);
            Controls.Add(saveButton);
            Controls.Add(shelfInfoButton);
            Controls.Add(deleteShelfButton);
            Controls.Add(addShelfButton);
            Controls.Add(label1);
            Controls.Add(searchShelfComboBox);
            Controls.Add(searchTextBox);
            Controls.Add(editItemButton);
            Controls.Add(deleteItemButton);
            Controls.Add(addItemButton);
            Controls.Add(itemsDataGridView);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainWindow";
            Text = "Main Window";
            ((System.ComponentModel.ISupportInitialize)itemsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView itemsDataGridView;
        private Button addItemButton;
        private Button deleteItemButton;
        private Button editItemButton;
        private TextBox searchTextBox;
        private ComboBox searchShelfComboBox;
        private Label label1;
        private Button addShelfButton;
        private Button deleteShelfButton;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn PriceColumn;
        private DataGridViewTextBoxColumn QuantityColumn;
        private DataGridViewTextBoxColumn CategoryColumn;
        private DataGridViewTextBoxColumn DescriptionColumn;
        private ProgressBar shelfProgressBar;
        private Label shelfName;
        private Button shelfInfoButton;
        private Label shelfProgress;
        private Button saveButton;
        private Button button1;
    }
}