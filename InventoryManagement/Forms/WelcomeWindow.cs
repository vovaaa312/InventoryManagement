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
    public partial class WelcomeWindow : Form
    {

        public Store store { get; set; } = null;

        public bool CanCreate => store != null;
        public WelcomeWindow()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            if (check(name)) {

                store = new Store(name);
                Close();
            }
            else MessageBox.Show("It must be at least 3 characters.");

        }

        private bool check(string name)
        {
            return name.Length >= 3;
        }
    }
}
