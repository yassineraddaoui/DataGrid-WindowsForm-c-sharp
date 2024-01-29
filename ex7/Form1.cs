namespace ex7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = firstnameF.Text;
            string lastname = lastnameF.Text;
            string gender = genderF.Text;
            string contact = contactF.Text;
            string adresse = adresseF.Text;

            dataGridView1.Rows.Add(contactF.Text, firstname, lastname, gender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            firstnameF.Text = "";
            lastnameF.Text = "";
            genderF.Text = "";
            contactF.Text = "";
            adresseF.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
