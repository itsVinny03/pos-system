namespace FinalProject
{
    partial class Checkout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkout));
            dataGridViewItems2 = new DataGridView();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtBoxTotalAmount = new TextBox();
            lvlTotalAmount = new Label();
            txtBoxPayment = new TextBox();
            btn10 = new Button();
            lblPayment = new Label();
            btn20 = new Button();
            btn30 = new Button();
            btn40 = new Button();
            btn50 = new Button();
            btn60 = new Button();
            btn70 = new Button();
            btn80 = new Button();
            btn90 = new Button();
            btn100 = new Button();
            btnDelete = new Button();
            btnEnter = new Button();
            lblChange = new Label();
            txtBoxChange = new TextBox();
            lvlModeOfPayment = new Label();
            rdbtnCash = new RadioButton();
            rdbtnGcash = new RadioButton();
            rdbtnCard = new RadioButton();
            btnCheckout2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewItems2
            // 
            dataGridViewItems2.BackgroundColor = Color.White;
            dataGridViewItems2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItems2.Location = new Point(34, 65);
            dataGridViewItems2.Name = "dataGridViewItems2";
            dataGridViewItems2.RowTemplate.Height = 25;
            dataGridViewItems2.Size = new Size(250, 324);
            dataGridViewItems2.TabIndex = 0;
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(104, 27);
            label1.Name = "label1";
            label1.Size = new Size(134, 28);
            label1.TabIndex = 50;
            label1.Text = "Fruit Cart";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 56);
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // txtBoxTotalAmount
            // 
            txtBoxTotalAmount.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxTotalAmount.Location = new Point(478, 28);
            txtBoxTotalAmount.Name = "txtBoxTotalAmount";
            txtBoxTotalAmount.Size = new Size(190, 34);
            txtBoxTotalAmount.TabIndex = 52;
           
            // 
            // lvlTotalAmount
            // 
            lvlTotalAmount.AutoSize = true;
            lvlTotalAmount.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lvlTotalAmount.Location = new Point(299, 28);
            lvlTotalAmount.Name = "lvlTotalAmount";
            lvlTotalAmount.Size = new Size(134, 28);
            lvlTotalAmount.TabIndex = 53;
            lvlTotalAmount.Text = "Total Amount:";
            // 
            // txtBoxPayment
            // 
            txtBoxPayment.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxPayment.Location = new Point(420, 99);
            txtBoxPayment.Name = "txtBoxPayment";
            txtBoxPayment.Size = new Size(269, 34);
            txtBoxPayment.TabIndex = 54;
            txtBoxPayment.TextChanged += txtBoxPayment_TextChanged;
            // 
            // btn10
            // 
            btn10.Location = new Point(400, 154);
            btn10.Name = "btn10";
            btn10.Size = new Size(53, 44);
            btn10.TabIndex = 55;
            btn10.Text = "10";
            btn10.UseVisualStyleBackColor = true;
            btn10.Click += btn10_Click;
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblPayment.Location = new Point(313, 99);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(91, 28);
            lblPayment.TabIndex = 56;
            lblPayment.Text = "Payment:";
            // 
            // btn20
            // 
            btn20.Location = new Point(459, 154);
            btn20.Name = "btn20";
            btn20.Size = new Size(53, 44);
            btn20.TabIndex = 57;
            btn20.Text = "20";
            btn20.UseVisualStyleBackColor = true;
            btn20.Click += btn20_Click;
            // 
            // btn30
            // 
            btn30.Location = new Point(518, 154);
            btn30.Name = "btn30";
            btn30.Size = new Size(53, 44);
            btn30.TabIndex = 58;
            btn30.Text = "30";
            btn30.UseVisualStyleBackColor = true;
            btn30.Click += btn30_Click;
            // 
            // btn40
            // 
            btn40.Location = new Point(577, 154);
            btn40.Name = "btn40";
            btn40.Size = new Size(53, 44);
            btn40.TabIndex = 59;
            btn40.Text = "40";
            btn40.UseVisualStyleBackColor = true;
            btn40.Click += btn40_Click;
            // 
            // btn50
            // 
            btn50.Location = new Point(636, 154);
            btn50.Name = "btn50";
            btn50.Size = new Size(53, 44);
            btn50.TabIndex = 60;
            btn50.Text = "50";
            btn50.UseVisualStyleBackColor = true;
            btn50.Click += btn50_Click;
            // 
            // btn60
            // 
            btn60.Location = new Point(400, 204);
            btn60.Name = "btn60";
            btn60.Size = new Size(53, 44);
            btn60.TabIndex = 61;
            btn60.Text = "60";
            btn60.UseVisualStyleBackColor = true;
            btn60.Click += btn60_Click;
            // 
            // btn70
            // 
            btn70.Location = new Point(459, 204);
            btn70.Name = "btn70";
            btn70.Size = new Size(53, 44);
            btn70.TabIndex = 62;
            btn70.Text = "70";
            btn70.UseVisualStyleBackColor = true;
            btn70.Click += btn70_Click;
            // 
            // btn80
            // 
            btn80.Location = new Point(518, 204);
            btn80.Name = "btn80";
            btn80.Size = new Size(53, 44);
            btn80.TabIndex = 63;
            btn80.Text = "80";
            btn80.UseVisualStyleBackColor = true;
            btn80.Click += btn80_Click;
            // 
            // btn90
            // 
            btn90.Location = new Point(577, 204);
            btn90.Name = "btn90";
            btn90.Size = new Size(53, 44);
            btn90.TabIndex = 64;
            btn90.Text = "90";
            btn90.UseVisualStyleBackColor = true;
            btn90.Click += btn90_Click;
            // 
            // btn100
            // 
            btn100.Location = new Point(636, 204);
            btn100.Name = "btn100";
            btn100.Size = new Size(53, 44);
            btn100.TabIndex = 65;
            btn100.Text = "100";
            btn100.UseVisualStyleBackColor = true;
            btn100.Click += btn100_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(695, 99);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(72, 79);
            btnDelete.TabIndex = 66;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(695, 184);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(72, 64);
            btnEnter.TabIndex = 67;
            btnEnter.Text = "ENTER";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblChange.Location = new Point(342, 257);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(82, 28);
            lblChange.TabIndex = 68;
            lblChange.Text = "Change:";
            // 
            // txtBoxChange
            // 
            txtBoxChange.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxChange.Location = new Point(430, 257);
            txtBoxChange.Name = "txtBoxChange";
            txtBoxChange.Size = new Size(190, 34);
            txtBoxChange.TabIndex = 69;
            txtBoxChange.TextChanged += txtBoxChange_TextChanged;
            // 
            // lvlModeOfPayment
            // 
            lvlModeOfPayment.AutoSize = true;
            lvlModeOfPayment.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lvlModeOfPayment.Location = new Point(342, 306);
            lvlModeOfPayment.Name = "lvlModeOfPayment";
            lvlModeOfPayment.Size = new Size(174, 28);
            lvlModeOfPayment.TabIndex = 70;
            lvlModeOfPayment.Text = "Mode Of Payment:";
            // 
            // rdbtnCash
            // 
            rdbtnCash.AutoSize = true;
            rdbtnCash.Location = new Point(523, 320);
            rdbtnCash.Name = "rdbtnCash";
            rdbtnCash.Size = new Size(51, 19);
            rdbtnCash.TabIndex = 71;
            rdbtnCash.TabStop = true;
            rdbtnCash.Text = "Cash";
            rdbtnCash.UseVisualStyleBackColor = true;
            rdbtnCash.CheckedChanged += rdbtnCash_CheckedChanged;
            // 
            // rdbtnGcash
            // 
            rdbtnGcash.AutoSize = true;
            rdbtnGcash.Location = new Point(523, 345);
            rdbtnGcash.Name = "rdbtnGcash";
            rdbtnGcash.Size = new Size(57, 19);
            rdbtnGcash.TabIndex = 72;
            rdbtnGcash.TabStop = true;
            rdbtnGcash.Text = "Gcash";
            rdbtnGcash.UseVisualStyleBackColor = true;
            rdbtnGcash.CheckedChanged += rdbtnGcash_CheckedChanged;
            // 
            // rdbtnCard
            // 
            rdbtnCard.AutoSize = true;
            rdbtnCard.Location = new Point(523, 370);
            rdbtnCard.Name = "rdbtnCard";
            rdbtnCard.Size = new Size(50, 19);
            rdbtnCard.TabIndex = 73;
            rdbtnCard.TabStop = true;
            rdbtnCard.Text = "Card";
            rdbtnCard.UseVisualStyleBackColor = true;
            rdbtnCard.CheckedChanged += rdbtnCard_CheckedChanged;
            // 
            // btnCheckout2
            // 
            btnCheckout2.Location = new Point(690, 322);
            btnCheckout2.Name = "btnCheckout2";
            btnCheckout2.Size = new Size(103, 64);
            btnCheckout2.TabIndex = 74;
            btnCheckout2.Text = "CHECKOUT";
            btnCheckout2.UseVisualStyleBackColor = true;
            btnCheckout2.Click += btnCheckout2_Click;
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(805, 392);
            ControlBox = false;
            Controls.Add(btnCheckout2);
            Controls.Add(rdbtnCard);
            Controls.Add(rdbtnGcash);
            Controls.Add(rdbtnCash);
            Controls.Add(lvlModeOfPayment);
            Controls.Add(txtBoxChange);
            Controls.Add(lblChange);
            Controls.Add(btnEnter);
            Controls.Add(btnDelete);
            Controls.Add(btn100);
            Controls.Add(btn90);
            Controls.Add(btn80);
            Controls.Add(btn70);
            Controls.Add(btn60);
            Controls.Add(btn50);
            Controls.Add(btn40);
            Controls.Add(btn30);
            Controls.Add(btn20);
            Controls.Add(lblPayment);
            Controls.Add(btn10);
            Controls.Add(txtBoxPayment);
            Controls.Add(lvlTotalAmount);
            Controls.Add(txtBoxTotalAmount);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(dataGridViewItems2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Checkout";
            Text = "Checkout";
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewItems2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtBoxTotalAmount;
        private Label lvlTotalAmount;
        private TextBox txtBoxPayment;
        private Button btn10;
        private Label lblPayment;
        private Button btn20;
        private Button btn30;
        private Button btn40;
        private Button btn50;
        private Button btn60;
        private Button btn70;
        private Button btn80;
        private Button btn90;
        private Button btn100;
        private Button btnDelete;
        private Button btnEnter;
        private Label lblChange;
        private TextBox txtBoxChange;
        private Label lvlModeOfPayment;
        private RadioButton rdbtnCash;
        private RadioButton rdbtnGcash;
        private RadioButton rdbtnCard;
        private Button btnCheckout2;
    }
}