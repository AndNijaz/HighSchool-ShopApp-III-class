using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projektni_zadatak
{
    public partial class DeleteOrder : Form
    {
        public DeleteOrder()
        {
            InitializeComponent();
        }

        private void ModificirajGridView(DataGridView dgv)
        {

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (dgv.Rows.IndexOf(dgv.Rows[i]) % 2 == 0)
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.Gainsboro;
                else
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }
        }

        private void DeleteOrder_Load(object sender, EventArgs e)
        {
            ShowOrders();
        }

        private void ShowOrders() {
            String query = "SELECT n.narudzbenica_id AS 'ID narudzbe', n.kupac_id AS 'ID kupca',CONCAT(k.ime,' ',k.prezime) AS 'Ime i prezime'," +
            "n.datum_narudzbe AS 'Datum narudzbe' from narudzbenica n, kupac k WHERE n.kupac_id=k.kupac_id";

            Utility.executeQuery(query, 1);

            //Utility.dataAdapter.Fill(Utility.tabela);
            dataGridView1.DataSource = Utility.tabela;

            Utility.stopQuery(1);

            ModificirajGridView(dataGridView1);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE from narudzbenica where narudzbenica_id='" + textBoxID.Text + "'";

            Utility.executeQuery(query, 0);
            MessageBox.Show("Obrisana je narudzba.");
            Utility.stopQuery(0);
            ShowOrders();

        }

        private void DeleteOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void kreiranjeIAžuriranjeNovogKupcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateCustomerForm cc = new CreateCustomerForm();
            this.Hide();
            cc.Show();
        }

        private void dodavanjeIAžuriranjeArtiklovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateArticle ca = new CreateArticle();
            this.Hide();
            ca.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }
    }
}
