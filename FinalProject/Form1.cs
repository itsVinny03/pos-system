namespace FinalProject
{
    public partial class frmFinalProject : Form
    {
        public frmFinalProject()
        {
            InitializeComponent();
        }
        private void frmFinalProject_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            SalesProcess s = new SalesProcess(); s.TopLevel = false; pnlContent.Controls.Add(s);
            s.BringToFront();
            s.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Inventory s = new Inventory(); s.TopLevel = false; pnlContent.Controls.Add(s);
            s.BringToFront();
            s.Show();
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalesHistory_Click(object sender, EventArgs e)
        {
            SalesHistory s = new SalesHistory(); s.TopLevel = false; pnlContent.Controls.Add(s);
            s.BringToFront();
            s.Show();
        }
    }
}