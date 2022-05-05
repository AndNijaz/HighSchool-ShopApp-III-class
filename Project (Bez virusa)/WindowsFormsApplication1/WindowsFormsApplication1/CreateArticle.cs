using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class CreateArticle : Form
    {
        public CreateArticle()
        {
            InitializeComponent();
        }

        MySqlDataReader reader;

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

        private void ShowArticle()
        {
            String query = "SELECT a.artikal_id AS 'ID artikla', a.naziv_artikla AS 'Naziv artikla', a.vrsta_artikla AS 'Vrsta artikla', a.cijena " +
            "AS 'Cijena artikla', s.kolicina_stanje AS 'Količina' FROM artikal a, skladiste s WHERE a.artikal_id=s.artikal_id ";

            if (textBoxPassword.Text != "")
            {
                query += "and a.artikal_id LIKE '" + textBoxPassword.Text + "%'";
            }

            if (textBoxLabel.Text != "")
            {
                query += "and a.naziv_artikla LIKE '" + textBoxLabel.Text + "%'";
            }

            Utility.executeQuery(query, 1);

            //Utility.dataAdapter.Fill(Utility.tabela);

            dataGridView1.DataSource = Utility.tabela;

            Utility.stopQuery(1);

            ModificirajGridView(dataGridView1);
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            ShowArticle();
        }

        private void textBoxLabel_TextChanged(object sender, EventArgs e)
        {
            ShowArticle();
        }

        private void buttonAddArticle_Click(object sender, EventArgs e)
        {
            if (textBoxArticleLabel.Text == "" || textBoxArticleType.Text == "" || textBoxPrice.Text == "" || textBoxAmount.Text == "")
            {
                MessageBox.Show("Molimo vas, unesite validne vrijednosti.");
                return;
            }

            //Provjeri da li postoji taj artikal već
            String queryProvjeri = "SELECT naziv_artikla FROM artikal";
            Utility.executeQuery(queryProvjeri, 2);
            reader = Utility.reader;
            while (reader.Read())
            {
                if (reader[0].ToString().ToLower() == textBoxArticleLabel.Text.ToLower())
                {
                    MessageBox.Show("Artikal " + textBoxArticleLabel.Text + " već postoji.");
                    return;
                };
            }
            Utility.stopQuery(2);

            String queryOne = "INSERT INTO artikal (naziv_artikla,vrsta_artikla,cijena) VALUES " +
                "('" + textBoxArticleLabel.Text + "','" + textBoxArticleType.Text + "','" + textBoxPrice.Text + "')";
            String queryTwo = "INSERT INTO skladiste (kolicina_stanje,artikal_id) VALUES ('" + textBoxAmount.Text + "',";
            String queryThree = "SELECT artikal_id from artikal where naziv_artikla='" + textBoxArticleLabel.Text + "'";

            Utility.executeQuery(queryOne, 0);
            Utility.stopQuery(0);
            Utility.executeQuery(queryThree, 2);

            reader = Utility.reader;
            reader.Read();

            MessageBox.Show(reader[0].ToString());

            String password = reader[0].ToString();

            Utility.stopQuery(2);

            queryTwo += "' " + password + "')";
            Utility.executeQuery(queryTwo, 0);
            MessageBox.Show("Dodan novi artikal.");

            Utility.stopQuery(0);

            ShowArticle();

            textBoxArticleLabel.Text = "";
            textBoxArticleType.Text = "";
            textBoxPrice.Text = "";
            textBoxAmount.Text = "";
        }

        private void buttonUpdateArticle_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (textBoxID.Text == "")
            {
                errorProvider1.SetError(textBoxID, "Pogrešan id.");
                MessageBox.Show("Molimo vas unesite ispravan id artikla kojeg želite ažurirati.");
                return;

            }
            String queryOne = "UPDATE artikal SET naziv_artikla='" + textBoxArticleLabel.Text + "',vrsta_artikla='" + textBoxArticleType.Text +
            "',cijena='" + textBoxPrice.Text + "' WHERE artikal_id='" + textBoxID.Text + "'";
            String queryTwo = "UPDATE skladiste SET kolicina_stanje='" + textBoxAmount.Text + "' WHERE artikal_id='" + textBoxID.Text + "'";

            Utility.executeQuery(queryOne, 0);
            Utility.executeQuery(queryTwo, 0);

            MessageBox.Show("Artikal je ažuriran.");

            Utility.stopQuery(0);

            ShowArticle();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                int num = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                String queryOne = "SELECT kolicina_stanje from skladiste WHERE artikal_id='" + textBoxID.Text + "'";

                Utility.executeQuery(queryOne, 2);

                reader = Utility.reader;
                reader.Read();
                String amount = reader[0].ToString();
                int sum = Convert.ToInt32(amount) + num;
                Utility.stopQuery(2);

                String queryTwo = "UPDATE skladiste SET kolicina_stanje='" + sum.ToString() + "' WHERE artikal_id='" + textBoxID.Text + "'";

                Utility.executeQuery(queryTwo, 0);

                MessageBox.Show("Dodana je količina.");

                Utility.stopQuery(0);

                ShowArticle();
            }
            catch (Exception ex)
            {
                if (ex.Message == "Invalid attempt to access a field before calling Read()") MessageBox.Show("Molim vas unesite id artikla kojem želite dodati količinu.");
                errorProvider1.SetError(textBoxID, "Molimo vas, unesite validne vrijednosti.");
            }
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            String query = "SELECT a.naziv_artikla, a.vrsta_artikla,a.cijena,s.kolicina_stanje FROM artikal a,skladiste s WHERE a.artikal_id=s.artikal_id and a.artikal_id='" + textBoxID.Text + "'";

            Utility.executeQuery(query, 2);

            reader = Utility.reader;
            reader.Read();

            if (reader.HasRows)
            {
                textBoxArticleLabel.Text = reader[0].ToString();
                textBoxArticleType.Text = reader[1].ToString();
                textBoxPrice.Text = reader[2].ToString();
                textBoxAmount.Text = reader[3].ToString();
            }

            Utility.stopQuery(2);
        }

        private void CreateArticle_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void kreiranjeIAžuriranjeNovogKupcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateCustomerForm cc = new CreateCustomerForm();
            this.Hide();
            cc.Show();
        }

        private void prikazIBrisanjeNarudžbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteOrder dor = new DeleteOrder();
            this.Hide();
            dor.Show();
        }

        private void CreateArticle_Load(object sender, EventArgs e)
        {
            ShowArticle();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }



    }
}
