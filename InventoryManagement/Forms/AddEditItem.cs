using InventoryManagement.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Forms
{
    public partial class AddEditItem : Form
    {

        public Item NewItem = null;

        private Category category;

        private int capacity;
        public AddEditItem(int ShelfCapacity, Category category)
        {
            Initialize();
            this.capacity = ShelfCapacity;
            this.category = category;
        }

        public AddEditItem(Item item, int ShelfCapacity, Category category) :this(ShelfCapacity, category)
        {
            idTextBox.Text = item.Id;
            nameTextBox.Text = item.Name;
            priceNumeric.Value = item.Price;
            quantityNumeric.Value = item.Quantity;
            categoryComboBox.SelectedItem = item.Category;
            descriptionTextBox.Text = item.Description;

        }

        private void Initialize()
        {
            InitializeComponent();
            categoryComboBox.DataSource = CategoryInfo.Items;

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            string name = nameTextBox.Text;
            int price = (int)priceNumeric.Value;
            int quantity = (int)quantityNumeric.Value;
            Category category = (Category)categoryComboBox.SelectedItem;
            if (check(id, name, price, quantity, category) == "OK")
            {
                NewItem = new Item(id, name, category, price, quantity, descriptionTextBox.Text);
                Close();
            }
        }

        private string check(string id, string name, int price, int quantity, Category category)
        {
            string message = "";
            if (id == null || id == "") message += "Wrong id value! Id cannot be null\n";
            if (name == null || name == "") message += "Wrong name value! Name cannot be null\n";
            if (price <= 0) message += "Wrong price value! Price cannot be less or equal 0\n";
            if (quantity <= 0) message += "Wrong quantity value! Quantity cannot be less or equal 0\n";
            if (quantity > capacity)message+= "Wrong quantity value! Quantity > capacity 0\n";
            if (category != this.category && category != Category.None) message += category +"!="+this.category; 
            if (message != "")
            {
                MessageBox.Show(message);
                return message;
            }
            else return "OK";
        }


    }
}
