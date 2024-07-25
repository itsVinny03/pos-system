using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace FinalProject
{
   
    public partial class SalesHistory : Form
    {
        private static List<Sale> sales = new List<Sale>();
        private PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;

        public SalesHistory()
        {
            InitializeComponent();

            // Initialize PrintDocument and PrintPreviewDialog
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            printPreviewDialog = new PrintPreviewDialog
            {
                Document = printDocument
            };

            // Add columns to dataGridViewSalesHistory if not already added
            if (dataGridViewSalesHistory.Columns.Count == 0)
            {
                dataGridViewSalesHistory.Columns.Add("Date", "Date");
                dataGridViewSalesHistory.Columns.Add("Items", "Items");
                dataGridViewSalesHistory.Columns.Add("TotalAmount", "Total Amount");
                dataGridViewSalesHistory.Columns.Add("PaymentMethod", "Payment Method");
                dataGridViewSalesHistory.Columns.Add("Payment", "Payment");
                dataGridViewSalesHistory.Columns.Add("Change", "Change");
            }

            // Load existing sales into the data grid
            foreach (var sale in sales)
            {
                AddSaleToGrid(sale);
            }
        }

        public static void AddSale(Sale sale)
        {
            sales.Add(sale);
        }

        private void AddSaleToGrid(Sale sale)
        {
            string itemsDescription = string.Join(", ", sale.Items.Select(i => $"{i.Name} x{i.Quantity}"));
            dataGridViewSalesHistory.Rows.Add(
                sale.Date.ToString("dddd"),
                itemsDescription,
                sale.TotalAmount.ToString("C"),
                sale.PaymentMethod,
                sale.Payment.ToString("C"),
                sale.Change.ToString("C"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int x = 10; // X position for columns
            int y = 10; // Y position for rows
            int rowHeight = 30; // Height of each row
            int columnWidth = 100; // Width of each column
            int headerHeight = 30; // Height of the header row

            Font font = new Font("Arial", 10);
            Brush brush = Brushes.Black;

            // Print header row
            foreach (DataGridViewColumn column in dataGridViewSalesHistory.Columns)
            {
                e.Graphics.DrawString(column.HeaderText, font, brush, x, y);
                x += columnWidth;
            }

            y += headerHeight;
            x = 10;

            // Print rows
            foreach (DataGridViewRow row in dataGridViewSalesHistory.Rows)
            {
                if (row.IsNewRow) continue;

                x = 10;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    string cellText = cell.Value?.ToString() ?? string.Empty;

                    // Split the text into lines that fit the column width
                    var textLines = SplitTextIntoLines(cellText, font, columnWidth);
                    foreach (var line in textLines)
                    {
                        e.Graphics.DrawString(line, font, brush, x, y);
                        y += font.Height; // Move down for the next line
                    }

                    // Move to next column
                    x += columnWidth;
                }
                y += rowHeight; // Move down for the next row
            }
        }

        private List<string> SplitTextIntoLines(string text, Font font, int maxWidth)
        {
            var lines = new List<string>();
            var words = text.Split(' ');

            string currentLine = string.Empty;

            foreach (var word in words)
            {
                string testLine = currentLine + word + " ";

                if (TextRenderer.MeasureText(testLine, font).Width > maxWidth)
                {
                    if (currentLine.Length > 0)
                    {
                        lines.Add(currentLine.TrimEnd());
                        currentLine = word + " ";
                    }
                    else
                    {
                        lines.Add(word);
                    }
                }
                else
                {
                    currentLine = testLine;
                }
            }

            if (currentLine.Length > 0)
            {
                lines.Add(currentLine.TrimEnd());
            }

            return lines;
        }

      
    }
    public class Sale
    {
        public DateTime Date { get; set; }
        public List<CartItem> Items { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentMethod { get; set; }
        public decimal Payment { get; set; }
        public decimal Change { get; set; }
    }
}

