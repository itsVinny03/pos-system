namespace FinalProject
{
    partial class SalesHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewSalesHistory = new DataGridView();
            label1 = new Label();
            btnPrint = new Button();
            PrintPreviewDialog = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSalesHistory).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSalesHistory
            // 
            dataGridViewSalesHistory.BackgroundColor = Color.White;
            dataGridViewSalesHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSalesHistory.Location = new Point(120, 58);
            dataGridViewSalesHistory.Name = "dataGridViewSalesHistory";
            dataGridViewSalesHistory.RowTemplate.Height = 25;
            dataGridViewSalesHistory.Size = new Size(625, 316);
            dataGridViewSalesHistory.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(350, 19);
            label1.Name = "label1";
            label1.Size = new Size(178, 27);
            label1.TabIndex = 1;
            label1.Text = "Sales History";
            // 
            // btnPrint
            // 
            btnPrint.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrint.Location = new Point(772, 376);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(80, 43);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += button1_Click;
            // 
            // PrintPreviewDialog
            // 
            
            // 
            // SalesHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(864, 422);
            ControlBox = false;
            Controls.Add(btnPrint);
            Controls.Add(label1);
            Controls.Add(dataGridViewSalesHistory);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SalesHistory";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSalesHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewSalesHistory;
        private Label label1;
        private Button btnPrint;
        private System.Drawing.Printing.PrintDocument PrintPreviewDialog;
    }
}