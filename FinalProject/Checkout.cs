using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Checkout : Form
    {
        private decimal totalAmount = 0m;
        private List<CartItem> cartItems;

        public Checkout(List<CartItem> cartItems)
        {
            InitializeComponent();
            this.cartItems = cartItems;

            // Add columns to dataGridViewItems2 if not already added
            if (dataGridViewItems2.Columns.Count == 0)
            {
                dataGridViewItems2.Columns.Add("Name", "Name");
                dataGridViewItems2.Columns.Add("Price", "Price");
                dataGridViewItems2.Columns.Add("Quantity", "Quantity");
                dataGridViewItems2.Columns.Add("TotalPrice", "Total Price");
            }

            // Populate dataGridViewItems2 with cartItems data
            foreach (var item in cartItems)
            {
                dataGridViewItems2.Rows.Add(item.Name, item.Price, item.Quantity, item.TotalPrice);
                totalAmount += item.TotalPrice;
            }

            // Display total amount
            txtBoxTotalAmount.Text = totalAmount.ToString("C");
        }

        private void btn10_Click(object sender, EventArgs e) => AddToPayment(10);
        private void btn20_Click(object sender, EventArgs e) => AddToPayment(20);
        private void btn30_Click(object sender, EventArgs e) => AddToPayment(30);
        private void btn40_Click(object sender, EventArgs e) => AddToPayment(40);
        private void btn50_Click(object sender, EventArgs e) => AddToPayment(50);
        private void btn60_Click(object sender, EventArgs e) => AddToPayment(60);
        private void btn70_Click(object sender, EventArgs e) => AddToPayment(70);
        private void btn80_Click(object sender, EventArgs e) => AddToPayment(80);
        private void btn90_Click(object sender, EventArgs e) => AddToPayment(90);
        private void btn100_Click(object sender, EventArgs e) => AddToPayment(100);

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtBoxPayment.Text = string.Empty;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtBoxPayment.Text, out decimal payment))
            {
                if (payment >= totalAmount)
                {
                    decimal change = payment - totalAmount;
                    txtBoxChange.Text = change.ToString("C");
                }
                else
                {
                    MessageBox.Show("Payment insufficient");
                }
            }
            else
            {
                MessageBox.Show("Invalid payment amount");
            }
        }

            private void btnCheckout2_Click(object sender, EventArgs e)
            {
            if (decimal.TryParse(txtBoxPayment.Text, out decimal payment))
            {
                if (payment >= totalAmount)
                {
                    string paymentMethod = GetSelectedPaymentMethod();
                    decimal change = payment - totalAmount;
                    txtBoxChange.Text = change.ToString("C");

                    Sale sale = new Sale
                    {
                        Date = DateTime.Now,
                        Items = cartItems,
                        TotalAmount = totalAmount,
                        PaymentMethod = paymentMethod,
                        Payment = payment,
                        Change = change
                    };

                    SalesHistory.AddSale(sale);

                    // Display thank you message
                    MessageBox.Show("Thank you for ordering");

                    // Close the Checkout form
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Payment insufficient");
                }
            }
            else
            {
                MessageBox.Show("Invalid payment amount");
            }
        }

        private string GetSelectedPaymentMethod()
        {
            if (rdbtnCash.Checked) return "Cash";
            if (rdbtnGcash.Checked) return "Gcash";
            if (rdbtnCard.Checked) return "Card";
            return "Unknown";
        }

        private void AddToPayment(decimal amount)
        {
            if (decimal.TryParse(txtBoxPayment.Text, out decimal currentPayment))
            {
                txtBoxPayment.Text = (currentPayment + amount).ToString();
            }
            else
            {
                txtBoxPayment.Text = amount.ToString();
            }
        }

        private void txtBoxPayment_TextChanged(object sender, EventArgs e) { }
        private void txtBoxChange_TextChanged(object sender, EventArgs e) { }
        private void rdbtnCash_CheckedChanged(object sender, EventArgs e) { }
        private void rdbtnGcash_CheckedChanged(object sender, EventArgs e) { }
        private void rdbtnCard_CheckedChanged(object sender, EventArgs e) { }
    }
}
