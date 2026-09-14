namespace pryRotaSP2
{
    public partial class ventasregistradas : Form
    {
        public ventasregistradas()
        {
            InitializeComponent();
            btnregistrar.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numticket = int.Parse(txtnumero.Text);
            string tipoticket = cmblist.Text;
            string date = dtp.Value.ToString("dd/MM/yyyy");
            string linea = numticket + " - " + tipoticket + " - " + date;
            lstventas.Items.Add(linea);
        }

        private void cmblist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmblist.SelectedIndex != -1)
            {
                btnregistrar.Enabled = true;
            }

        }

        private void txtnumero_TextChanged(object sender, EventArgs e)
        {
            if (txtnumero.Text != "")
            {
                btnregistrar.Enabled = true;
            }
        }

        private void lbl4_Click(object sender, EventArgs e)
        {

        }
    }
}
