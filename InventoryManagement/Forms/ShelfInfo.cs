using InventoryManagement.Items;


namespace InventoryManagement.Forms
{
    public partial class ShelfInfo : Form
    {
        public ShelfInfo(Shelf shelf)
        {
            if (shelf == null)
            {
                return;
            }
            InitializeComponent();
            idLabel.Text = shelf.Id;
            nameLabel.Text = shelf.Name;
            capacityLabel.Text = shelf.Capacity.ToString();
            countLabel.Text = shelf.ShelfLoad.ToString();
            categoryLabel.Text = shelf.shelfCategory.ToString();

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
