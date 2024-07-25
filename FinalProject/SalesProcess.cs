using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class SalesProcess : Form
    {
        private List<FruitItem> fruits;
        private const string CartFilePath = "cartItems.json";

        public SalesProcess()
        {
            InitializeComponent();
        }

        private void SalesProcess_Load(object sender, EventArgs e)
        {
            // Initialize the fruits list
            fruits = new List<FruitItem>
            {
                new FruitItem("Apple", 20.00m),
                new FruitItem("Banana", 15.00m),
                new FruitItem("Grapes", 150.00m),
                new FruitItem("Mango", 25.00m),
                new FruitItem("Pineapple", 40.00m),
                new FruitItem("Orange", 15.00m),
                new FruitItem("Strawberry", 300.00m),
                new FruitItem("Sugar Apple", 30.00m),
                new FruitItem("Watermelon", 120.00m)
            };

            // Ensure DataGridView is properly initialized
            if (dataGridViewItems == null)
            {
                MessageBox.Show("DataGridView is not initialized.");
                return;
            }

            // Add columns to DataGridView if not already added
            if (dataGridViewItems.Columns.Count == 0)
            {
                dataGridViewItems.Columns.Add("Name", "Name");
                dataGridViewItems.Columns.Add("Price", "Price");
                dataGridViewItems.Columns.Add("Quantity", "Quantity");
                dataGridViewItems.Columns.Add("TotalPrice", "Total Price");
            }

            // Set button click events
            btnApple.Click += (s, ea) => AddToCart("Apple");
            btnBanana.Click += (s, ea) => AddToCart("Banana");
            btnGrapes.Click += (s, ea) => AddToCart("Grapes");
            btnMango.Click += (s, ea) => AddToCart("Mango");
            btnPineapple.Click += (s, ea) => AddToCart("Pineapple");
            btnOrange.Click += (s, ea) => AddToCart("Orange");
            btnStrawberry.Click += (s, ea) => AddToCart("Strawberry");
            btnSugarapple.Click += (s, ea) => AddToCart("Sugar Apple");
            btnWatermelon.Click += (s, ea) => AddToCart("Watermelon");

            // Set remove button click events
            btnRemoveApple.Click += (s, ea) => RemoveFromCart("Apple");
            btnRemoveBanana.Click += (s, ea) => RemoveFromCart("Banana");
            btnRemoveGrapes.Click += (s, ea) => RemoveFromCart("Grapes");
            btnRemoveMango.Click += (s, ea) => RemoveFromCart("Mango");
            btnRemovePineapple.Click += (s, ea) => RemoveFromCart("Pineapple");
            btnRemoveOrange.Click += (s, ea) => RemoveFromCart("Orange");
            btnRemoveStrawberry.Click += (s, ea) => RemoveFromCart("Strawberry");
            btnRemoveSugarapple.Click += (s, ea) => RemoveFromCart("Sugar Apple");
            btnRemoveWatermelon.Click += (s, ea) => RemoveFromCart("Watermelon");

            // Set search button click event
            btnSearch.Click += btnSearch_Click;

            // Set search bar text changed event
            searchBar.TextChanged += searchBar_TextChanged;

            // Load cart items from file
            LoadCartItems();
        }

        private void AddToCart(string fruitName)
        {
            if (InventoryManager.FruitSupplies[fruitName] > 0)
            {
                // Find the fruit
                var fruit = fruits.Find(f => f.Name == fruitName);
                if (fruit != null)
                {
                    // Find existing row
                    var existingRow = dataGridViewItems.Rows
                        .Cast<DataGridViewRow>()
                        .FirstOrDefault(r => r.Cells["Name"].Value != null && r.Cells["Name"].Value.ToString() == fruitName);

                    if (existingRow != null)
                    {
                        var quantityCell = existingRow.Cells["Quantity"];
                        var totalPriceCell = existingRow.Cells["TotalPrice"];

                        // Handle null values for quantityCell
                        int quantity = quantityCell.Value != null ? (int)quantityCell.Value : 0;
                        quantity++;
                        quantityCell.Value = quantity;
                        totalPriceCell.Value = quantity * fruit.Price;
                    }
                    else
                    {
                        // Add new row with default values
                        dataGridViewItems.Rows.Add(fruit.Name, fruit.Price, 1, fruit.Price);
                    }

                    // Decrease inventory
                    InventoryManager.FruitSupplies[fruitName]--;
                }
                else
                {
                    MessageBox.Show($"Fruit '{fruitName}' not found.");
                }
            }
            else
            {
                MessageBox.Show($"{fruitName} is out of stock.");
            }
        }

        private void RemoveFromCart(string fruitName)
        {
            // Find and remove the row corresponding to the fruit
            var rowToRemove = dataGridViewItems.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.Cells["Name"].Value != null && r.Cells["Name"].Value.ToString() == fruitName);

            if (rowToRemove != null)
            {
                var quantity = (int)rowToRemove.Cells["Quantity"].Value;
                if (quantity > 1)
                {
                    rowToRemove.Cells["Quantity"].Value = quantity - 1;
                    rowToRemove.Cells["TotalPrice"].Value = (quantity - 1) * (decimal)rowToRemove.Cells["Price"].Value;
                }
                else
                {
                    dataGridViewItems.Rows.Remove(rowToRemove);
                }

                // Increase inventory
                InventoryManager.FruitSupplies[fruitName]++;
            }
            else
            {
                MessageBox.Show($"Fruit '{fruitName}' not found in cart.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get the search term from the search bar
            string searchTerm = searchBar.Text.Trim().ToLower();

            // Create a mapping of controls to fruit names
            var controlMapping = new Dictionary<Control, string>
            {
                { pictureBoxApple, "Apple" },
                { pictureBoxBanana, "Banana" },
                { pictureBoxGrapes, "Grapes" },
                { pictureBoxMango, "Mango" },
                { pictureBoxPineapple, "Pineapple" },
                { pictureBoxOrange, "Orange" },
                { pictureBoxStrawberry, "Strawberry" },
                { pictureBoxSugarapple, "Sugar Apple" },
                { pictureBoxWatermelon, "Watermelon" },

                { btnApple, "Apple" },
                { btnBanana, "Banana" },
                { btnGrapes, "Grapes" },
                { btnMango, "Mango" },
                { btnPineapple, "Pineapple" },
                { btnOrange, "Orange" },
                { btnStrawberry, "Strawberry" },
                { btnSugarapple, "Sugar Apple" },
                { btnWatermelon, "Watermelon" },

                { btnRemoveApple, "Apple" },
                { btnRemoveBanana, "Banana" },
                { btnRemoveGrapes, "Grapes" },
                { btnRemoveMango, "Mango" },
                { btnRemovePineapple, "Pineapple" },
                { btnRemoveOrange, "Orange" },
                { btnRemoveStrawberry, "Strawberry" },
                { btnRemoveSugarapple, "Sugar Apple" },
                { btnRemoveWatermelon, "Watermelon" },

                { priceApple, "Apple" },
                { priceBanana, "Banana" },
                { priceGrapes, "Grapes" },
                { priceMango, "Mango" },
                { pricePineapple, "Pineapple" },
                { priceOrange, "Orange" },
                { priceStrawberry, "Strawberry" },
                { priceSugarapple, "Sugar Apple" },
                { priceWatermelon, "Watermelon" }
            };

            // Iterate through each control and show/hide based on the search term
            foreach (var entry in controlMapping)
            {
                var control = entry.Key;
                var fruitName = entry.Value;

                if (fruitName.ToLower().Contains(searchTerm))
                {
                    control.Visible = true;
                }
                else
                {
                    control.Visible = false;
                }
            }
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void SalesProcess_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save cart items to file
            SaveCartItems();
        }

        private void SaveCartItems()
        {
            var cartItems = dataGridViewItems.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["Name"].Value != null)
                .Select(r => new CartItem(
                    r.Cells["Name"].Value.ToString(),
                    (decimal)r.Cells["Price"].Value,
                    (int)r.Cells["Quantity"].Value
                ))
                .ToList();

            var json = JsonSerializer.Serialize(cartItems);
            File.WriteAllText(CartFilePath, json);
        }

        private void LoadCartItems()
        {
            if (File.Exists(CartFilePath))
            {
                var json = File.ReadAllText(CartFilePath);
                var cartItems = JsonSerializer.Deserialize<List<CartItem>>(json);

                foreach (var item in cartItems)
                {
                    dataGridViewItems.Rows.Add(item.Name, item.Price, item.Quantity, item.TotalPrice);

                    // Decrease inventory accordingly
                    InventoryManager.FruitSupplies[item.Name] -= item.Quantity;
                }
            }
        }

        private void buttonAddtocart_Click(object sender, EventArgs e)
        {
            // Collect data from dataGridViewItems
            var cartItems = dataGridViewItems.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["Name"].Value != null)
                .Select(r => new CartItem(
                    r.Cells["Name"].Value.ToString(),
                    (decimal)r.Cells["Price"].Value,
                    (int)r.Cells["Quantity"].Value
                ))
                .ToList();

            // Open Checkout form and pass the collected data
            var checkoutForm = new Checkout(cartItems);
            checkoutForm.ShowDialog();
        }
    }
}
