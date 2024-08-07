namespace AS2
{
    public partial class WaterBill : Form
    {

        public Invoice invoiceManager;
        public WaterBill()
        {
            InitializeComponent();
            invoiceManager = new Invoice();

            addInvoice.InvoiceManager = invoiceManager;
            manageInvoices.InvoiceManager = invoiceManager;
            

            addInvoice.Show();
            manageInvoices.Hide();
            manageInvoices.RefreshInvoiceList();

        }

        private void addInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addInvoice.Show();
            manageInvoices.Hide();
        }

        private void addInvoice1_Load(object sender, EventArgs e)
        {

        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageInvoices.Show();
            addInvoice.Hide();
            manageInvoices.RefreshInvoiceList();
        }
    }
}