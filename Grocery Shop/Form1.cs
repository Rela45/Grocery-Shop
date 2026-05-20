namespace Grocery_Shop
{
    public partial class ShoppingList : Form
    {
        string[] units = { "kg", "g", "L", "ml", "pcs" };
        List<string> shoppingList = new List<string>();
        public ShoppingList()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult userResponse = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (userResponse == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ShoppingList_Load(object sender, EventArgs e)
        {
            comboUnits.Items.AddRange(units);
            comboUnits.SelectedIndex = 0;

            //datasource

            lbxShoppingList.DataSource = shoppingList;
            lblError.Enabled = false;
        }

        void UpdateGUI()
        {
            lbxShoppingList.DataSource = null;
            lbxShoppingList.DataSource = shoppingList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string itemDescription = tbxItemDescription.Text;
            double amount = 0;
            bool amountOK = double.TryParse(tbxAmount.Text, out amount);
            string unit = comboUnits.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(itemDescription) && 
                !string.IsNullOrEmpty(unit)&& amountOK)
            {
                RemoveErrorNotifier();
                string item = $"{itemDescription} - {amount} {unit}";
                shoppingList.Add(item);
                UpdateGUI();
            }
            else
            {
                lblError.Enabled = true;
                lblError.BackColor = Color.Red;
                lblError.Text = "Please Insert Valid Information";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lbxShoppingList.SelectedIndex;

            if (index != -1)
            {
                RemoveErrorNotifier();
                DialogResult deleteConfirmation = MessageBox.Show(
                    "Are you sure to delete the selected item?",
                    "Delete Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);
                if (deleteConfirmation == DialogResult.Yes)
                {
                    shoppingList.RemoveAt(index);
                    UpdateGUI();
                }
                
            }
            else
            {
                lblError.Enabled = true;
                lblError.BackColor = Color.Red;
                lblError.Text = "Please Select at least one item to delete from the list.";
            }
        }



        void RemoveErrorNotifier()
        {
            lblError.Enabled = false;
            lblError.BackColor = Color.Transparent;
        }

        private void lbxShoppingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveErrorNotifier();
        }
    }
}
