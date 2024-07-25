namespace FinalProject
{
    partial class frmFinalProject
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinalProject));
            panel1 = new Panel();
            btnLogout = new Button();
            btnReportAnalysis = new Button();
            btnReportSales = new Button();
            btnManageSales = new Button();
            btnSalesHistory = new Button();
            btnInventory = new Button();
            btnSalesProcess = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            pnlContent = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnReportAnalysis);
            panel1.Controls.Add(btnReportSales);
            panel1.Controls.Add(btnManageSales);
            panel1.Controls.Add(btnSalesHistory);
            panel1.Controls.Add(btnInventory);
            panel1.Controls.Add(btnSalesProcess);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(148, 485);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(-2, 415);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(147, 38);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnReportAnalysis
            // 
            btnReportAnalysis.Location = new Point(-2, 373);
            btnReportAnalysis.Margin = new Padding(3, 2, 3, 2);
            btnReportAnalysis.Name = "btnReportAnalysis";
            btnReportAnalysis.Size = new Size(147, 38);
            btnReportAnalysis.TabIndex = 6;
            btnReportAnalysis.Text = "Report and Analysis";
            btnReportAnalysis.UseVisualStyleBackColor = true;
            // 
            // btnReportSales
            // 
            btnReportSales.Location = new Point(-2, 331);
            btnReportSales.Margin = new Padding(3, 2, 3, 2);
            btnReportSales.Name = "btnReportSales";
            btnReportSales.Size = new Size(147, 38);
            btnReportSales.TabIndex = 5;
            btnReportSales.Text = "Report in Sales";
            btnReportSales.UseVisualStyleBackColor = true;
            // 
            // btnManageSales
            // 
            btnManageSales.Location = new Point(-2, 289);
            btnManageSales.Margin = new Padding(3, 2, 3, 2);
            btnManageSales.Name = "btnManageSales";
            btnManageSales.Size = new Size(147, 38);
            btnManageSales.TabIndex = 4;
            btnManageSales.Text = "Manage Sales";
            btnManageSales.UseVisualStyleBackColor = true;
            // 
            // btnSalesHistory
            // 
            btnSalesHistory.Location = new Point(-2, 247);
            btnSalesHistory.Margin = new Padding(3, 2, 3, 2);
            btnSalesHistory.Name = "btnSalesHistory";
            btnSalesHistory.Size = new Size(147, 38);
            btnSalesHistory.TabIndex = 3;
            btnSalesHistory.Text = "Sales History";
            btnSalesHistory.UseVisualStyleBackColor = true;
            btnSalesHistory.Click += btnSalesHistory_Click;
            // 
            // btnInventory
            // 
            btnInventory.Location = new Point(-2, 205);
            btnInventory.Margin = new Padding(3, 2, 3, 2);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(147, 38);
            btnInventory.TabIndex = 2;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnSalesProcess
            // 
            btnSalesProcess.Location = new Point(-2, 163);
            btnSalesProcess.Margin = new Padding(3, 2, 3, 2);
            btnSalesProcess.Name = "btnSalesProcess";
            btnSalesProcess.Size = new Size(147, 38);
            btnSalesProcess.TabIndex = 1;
            btnSalesProcess.Text = "Order Product";
            btnSalesProcess.UseVisualStyleBackColor = true;
            btnSalesProcess.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(3, 8);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 103);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PeachPuff;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(148, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(877, 50);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(315, 8);
            label1.Name = "label1";
            label1.Size = new Size(224, 28);
            label1.TabIndex = 0;
            label1.Text = "Nature's Delight";
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Bottom;
            pnlContent.Location = new Point(148, 49);
            pnlContent.Margin = new Padding(3, 2, 3, 2);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(877, 436);
            pnlContent.TabIndex = 2;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // frmFinalProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 485);
            Controls.Add(pnlContent);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmFinalProject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nature's Delight";
            Load += frmFinalProject_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLogout;
        private Button btnReportAnalysis;
        private Button btnReportSales;
        private Button btnManageSales;
        private Button btnSalesHistory;
        private Button btnInventory;
        private Button btnSalesProcess;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private Panel pnlContent;
    }
}