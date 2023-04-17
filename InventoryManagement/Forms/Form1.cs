using InventoryManagement.Forms;
using InventoryManagement.Items;
using InventoryManagement.SerializerDeserializer;
using System.ComponentModel.Design.Serialization;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace InventoryManagement
{
    public partial class MainWindow : Form
    {
        private Store store;
        public MainWindow()
        {
            WelcomeWindow welcome = new();
            welcome.ShowDialog();

            if (welcome.CanCreate)
            {
                InitializeComponent();
                itemsDataGridView.AllowUserToAddRows = false;

                store = welcome.store;
                store.Name = welcome.store.Name;
                this.Text = store.Name;

                //store.AddShelf(new Shelf("s1", "sf1", Category.Meat, 40));
                //store.AddShelf(new Shelf("s2", "sf2", Category.Meat, 40));
                //store.AddShelf(new Shelf("s3", "sf3", Category.Meat, 40));
                //store.AddShelf(new Shelf("s4", "sf4", Category.Meat, 40));
                //store.AddShelf(new Shelf("s5", "sf5", Category.Meat, 40));
                //LoadShelfs();
            }
            else { Environment.Exit(0); }


        }



        private void addItemButton_Click(object sender, EventArgs e)
        {
            if (check(false))
            {
                AddEditItem add = new(store[searchShelfComboBox.SelectedIndex].Capacity);
                add.ShowDialog();
                if (add.NewItem != null)
                {
                    Item item = add.NewItem;
                    store[searchShelfComboBox.SelectedIndex].Add(item);
                    LoadItems();
                    LoadProgressBar();
                }
            }
        }

        private void editItemButton_Click(object sender, EventArgs e)
        {
            if (check(true))
            {
                Item item = store[searchShelfComboBox.SelectedIndex][itemsDataGridView.CurrentCell.RowIndex];
                AddEditItem edit = new(item, store[searchShelfComboBox.SelectedIndex].Capacity);
                edit.ShowDialog();
                if (!edit.NewItem.Equals(item) && edit.NewItem != null)
                {
                    store[searchShelfComboBox.SelectedIndex].ReplaceItem(itemsDataGridView.CurrentCell.RowIndex, edit.NewItem);
                    LoadItems();
                    LoadProgressBar();
                }
            }

        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {

            if (check(true))
            {
                if (store[searchShelfComboBox.SelectedIndex].ItemsCount != 0)
                {
                    store[searchShelfComboBox.SelectedIndex].Delete(itemsDataGridView.CurrentCell.RowIndex);
                    LoadItems();
                    LoadProgressBar();
                }
            }
        }

        private bool check(bool needSelectRow)
        {
            if (store.Count == 0)
            {
                MessageBox.Show("Shelf list is empty");
                return false;
            }


            if (searchShelfComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please, select shelf");
                return false;
            }



            if (needSelectRow == true && itemsDataGridView.CurrentCell == null)
            {
                MessageBox.Show("Please, select item");
                return false;
            }
            return true;
        }




        private void addShelfButton_Click(object sender, EventArgs e)
        {
            AddShelf addShelf = new();
            addShelf.ShowDialog();
            if (addShelf.NewShelf != null)
            {
                store.AddShelf(addShelf.NewShelf);
                LoadShelfs();
                searchShelfComboBox.SelectedItem = addShelf.NewShelf.Name;
            }
        }
        private void deleteShelfButton_Click(object sender, EventArgs e)
        {
            if (store.Count == 0) MessageBox.Show("Shelf list is emtpy");
            if (searchShelfComboBox.SelectedItem == null) MessageBox.Show("Please, select shelf");
            else
            {
                DialogResult result = MessageBox.Show("You really want to delete this shelf?",
                    "Delete shelf", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int i = searchShelfComboBox.SelectedIndex;
                    store.DeleteShelf(i);
                    searchShelfComboBox.SelectedItem = null;
                    LoadShelfs();
                }
            }
        }






        private void searchShelfComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadItems();
            LoadProgressBar();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (store.Count != 0 && searchShelfComboBox.SelectedItem != null)
            {
                itemsDataGridView.Rows.Clear();
                Shelf shelf = store[searchShelfComboBox.SelectedIndex];
                for (int i = 0; i < shelf.ItemsCount; i++)
                {
                    if (shelf[i].Id.Contains(searchTextBox.Text) || shelf[i].Name.Contains(searchTextBox.Text))
                    {
                        itemsDataGridView.Rows.Add(shelf[i].Id, shelf[i].Name, shelf[i].Price, shelf[i].Quantity, shelf[i].Category, shelf[i].Description);

                    }
                }

            }


        }

        private void shelfInfoButton_Click(object sender, EventArgs e)
        {
            ShelfInfo si = new(store[searchShelfComboBox.SelectedIndex]);
            si.ShowDialog();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (store.IsEmpty())
            {
                MessageBox.Show("Store is empty");
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Save items";
                saveFileDialog.Filter = "items (*.items)|*.items|All files (*.*)|*.*";
                saveFileDialog.ShowDialog();
                if (saveFileDialog.FileName != "")
                {
                    ItemWriter.WriteToFile(store, saveFileDialog.FileName);
                    MessageBox.Show("Data saved");
                }


            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Load data";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    store = ItemReader.ReadFile(openFileDialog.FileName);
                    Reload();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }


        }

        private void Reload()
        {
            LoadShelfs();
            LoadItems();
            LoadProgressBar();
        }

        private void LoadShelfs()
        {
            searchShelfComboBox.Items.Clear();
            if (store.Count != 0)
            {
                for (int i = 0; i < store.Count; i++)
                {
                    searchShelfComboBox.Items.Add(store[i].Name);
                }

            }
        }

        private void LoadItems()
        {
            if (store.Count != 0)
            {
                itemsDataGridView.Rows.Clear();
                Shelf shelf = store[searchShelfComboBox.SelectedIndex];

                {
                    if (shelf != null)
                    {
                        for (int i = 0; i < shelf.ItemsCount; i++)
                        {
                            itemsDataGridView.Rows.Add(shelf[i].Id, shelf[i].Name, shelf[i].Price, shelf[i].Quantity, shelf[i].Category, shelf[i].Description);
                        }
                    }
                }


            }

        }

        private void LoadProgressBar()
        {
            if (searchShelfComboBox.SelectedItem != null)
            {
                int index = searchShelfComboBox.SelectedIndex;
                Shelf shelf = store[index];
                shelfProgressBar.Maximum = shelf.Capacity;
                shelfProgressBar.Value = shelf.ItemsCount;
                shelfName.Text = shelf.Name;
                shelfProgress.Text = shelf.ShelfLoad + " / " + shelf.Capacity;
            }
            else
            {
                shelfProgressBar.Maximum = 0;
                shelfProgressBar.Value = 0;
                shelfName.Text = "";
                shelfProgress.Text = "0 / 0";
            }
        }
    }
}