using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void txtBoxAppleSupply_TextChanged(object sender, EventArgs e)
        {
            // Ensure the value is a valid integer and update the inventory
            if (int.TryParse(txtBoxAppleSupply.Text, out int supply))
            {
                InventoryManager.FruitSupplies["Apple"] = supply;
            }
        }

        private void btnAddApple_Click(object sender, EventArgs e)
        {
            // Ensure the value is a valid integer and update the inventory
            if (int.TryParse(txtBoxAppleSupply.Text, out int supply))
            {
                InventoryManager.FruitSupplies["Apple"] += supply;
            }
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            // Initialize the text boxes with current inventory values
            txtBoxAppleSupply.Text = InventoryManager.FruitSupplies["Apple"].ToString();
            txtBoxBananaSupply.Text = InventoryManager.FruitSupplies["Banana"].ToString();
            txtBoxGrapesSupply.Text = InventoryManager.FruitSupplies["Grapes"].ToString();
            txtBoxMangoSupply.Text = InventoryManager.FruitSupplies["Mango"].ToString();
            txtBoxPineappleSupply.Text = InventoryManager.FruitSupplies["Pineapple"].ToString();
            txtBoxOrangeSupply.Text = InventoryManager.FruitSupplies["Orange"].ToString();
            txtBoxStrawberrySupply.Text = InventoryManager.FruitSupplies["Strawberry"].ToString();
            txtBoxSugarappleSupply.Text = InventoryManager.FruitSupplies["Sugar Apple"].ToString();
            txtBoxWatermelonSupply.Text = InventoryManager.FruitSupplies["Watermelon"].ToString();
        }

        private void btnAddBanana_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxBananaSupply.Text, out int supply))
            {
                InventoryManager.FruitSupplies["Banana"] += supply;
            }
        }

        private void txtBoxBananaSupply_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxBananaSupply.Text, out int supply))
            {
                InventoryManager.FruitSupplies["Banana"] = supply;
            }
        }

        private void btnAddGrapes_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxGrapesSupply.Text, out int supply))
            {
                InventoryManager.FruitSupplies["Grapes"] += supply;
            }
        }

        private void txtBoxGrapesSupply_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxGrapesSupply.Text, out int supply))
            {
                InventoryManager.FruitSupplies["Grapes"] = supply;
            }
        }

        private void btnAddMango_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxMangoSupply.Text, out int supply))
            {
                InventoryManager.FruitSupplies["Mango"] += supply;
            }
        }

        private void txtBoxMangoSupply_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxMangoSupply.Text, out int supply))
            {
                InventoryManager.FruitSupplies["Mango"] = supply;
            }
        }

        private void btnAddPineapple_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxPineappleSupply.Text, out int supply))
            {
                InventoryManager.FruitSupplies["Pineapple"] += supply;
            }
        }

        private void txtBoxPineappleSupply_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxPineappleSupply.Text, out int supply))
            {
                InventoryManager.FruitSupplies["Pineapple"] = supply;
            }
        }

        private void btnAddOrange_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxOrangeSupply.Text, out int supply))
            {
                InventoryManager.FruitSupplies["Orange"] += supply;
            }
        }

        private void txtBoxOrangeSupply_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxOrangeSupply.Text, out int supply))
            {
                InventoryManager.FruitSupplies["Orange"] = supply;
            }
        }

        private void btnAddStrawberry_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxStrawberrySupply.Text, out int supply))
            {
                InventoryManager.FruitSupplies["Strawberry"] += supply;
            }
        }

        private void txtBoxStrawberrySupply_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxStrawberrySupply.Text, out int supply))
            {
                InventoryManager.FruitSupplies["Strawberry"] = supply;
            }
        }

        private void btnAddSugarapple_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxSugarappleSupply.Text, out int supply))
            {
                InventoryManager.FruitSupplies["Sugar Apple"] += supply;
            }
        }

        private void txtBoxSugarappleSupply_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxSugarappleSupply.Text, out int supply))
            {
                InventoryManager.FruitSupplies["Sugar Apple"] = supply;
            }
        }

        private void btnAddWatermelon_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxWatermelonSupply.Text, out int supply))
            {
                InventoryManager.FruitSupplies["Watermelon"] += supply;
            }
        }

        private void txtBoxWatermelonSupply_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxWatermelonSupply.Text, out int supply))
            {
                InventoryManager.FruitSupplies["Watermelon"] = supply;
            }
        }
    }
}
