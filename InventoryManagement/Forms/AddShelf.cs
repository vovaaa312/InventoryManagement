using InventoryManagement.Items;
using System.Text.RegularExpressions;



namespace InventoryManagement.Forms
{
    public partial class AddShelf : Form
    {

        public Shelf NewShelf { get; set; }
        public AddShelf()
        {
            InitializeComponent();
            categoryComboBox.DataSource = CategoryInfo.Items;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string id = idTtextBox.Text;
            string name = nameTextBox.Text;
            Category category = (Category)categoryComboBox.SelectedValue;
            int capacity = (int)capacityUpDown.Value;
            if (check(id, name, category, capacity))
            {

                NewShelf = new Shelf(id, name, category, capacity);
                Close();
            }
        }

        private bool check(string id, string name, Category category, int capacity)
        {
            string message = "";
            if (name == null || name == "" || name.Length < 2) message += "Wrong name value\n";
            if (category == null) message += "Wrong category value\n";
            if (capacity <= 0) message += "Wrong capacity value\n";
            if (!Regex.IsMatch(id, @"^(?=.*[a-zA-Z])(?=.*\d).+$"))
            {
                // ID not contains at least one letter and one number
                message += "ID must contain at least one letter and one number\n";
            }
            if (message != "")
            {
                MessageBox.Show(message);
                return false;
            }



            return true;
        }
    }
}
