using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projektni_zadatak
{
    public partial class DeleteOrder : Form
    {
        public DeleteOrder()
        {
            InitializeComponent();
        }

        MySqlDataReader reader;
        MySqlDataReader reader2;

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

            dataGridView1.DataSource = Utility.tabela;

            Utility.stopQuery(1);

            ModificirajGridView(dataGridView1);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string queryHelper = "SELECT sn.kolicina, sn.artikal_id FROM stavka_narudzbenice sn, narudzbenica n WHERE n.narudzbenica_id = '" + textBoxID.Text + "' AND n.narudzbenica_id = sn.narudzbenica_id;";
            Utility.executeQuery(queryHelper, 2);
            reader = Utility.reader;
            while (reader.Read()) {
                string queryNeki = "SELECT kolicina_stanje FROM skladiste WHERE artikal_id = '"+reader[1].ToString()+"'";
                Utility.executeQuery(queryNeki, 2);
                reader2 = Utility.reader;
                reader2.Read();
                int kolicina = Convert.ToInt32(reader2[0]);
                kolicina = kolicina + Convert.ToInt32(reader[0]);
                Utility.stopQuery(2);

                string query = "UPDATE skladiste SET kolicina_stanje = '"+kolicina.ToString()+"' WHERE artikal_id = '"+reader[1].ToString()+"'";
                Utility.executeQuery(query, 0);
            }


            string queryOne = "DELETE from narudzbenica where narudzbenica_id='" + textBoxID.Text + "'";
            string queryTwo = "DELETE from stavka_narudzbenice where narudzbenica_id='" + textBoxID.Text + "'";

            Utility.executeQuery(queryTwo, 0);
            Utility.stopQuery(0);
            Utility.executeQuery(queryOne, 0);
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

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }
    }
}
