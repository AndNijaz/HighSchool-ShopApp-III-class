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
    public partial class CreateOrderForm : Form
    {
        public CreateOrderForm()
        {
            InitializeComponent();
        }




        private int CheckTextBoxId() {
            if (textBoxID.Text == "")
            {
                MessageBox.Show("Molimo vas unesite pravilan id artikla.");
                errorProvider1.SetError(textBoxID, "Pogrešan id.");
                return 1;
            }
            else return 0;
        }

        String customerID = LoginForm.customerID;
        MySqlDataReader reader;
        public static String lastOrder;
        DataTable tabela;
        int state;
        int postojiArtikal = 0;
        int dobar = 0;


        int pritisnuto = 0;

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

        private void ShowArticles()
        {
            String query = "SELECT a.artikal_id AS 'ID artikla', a.naziv_artikla AS 'Naziv', a.vrsta_artikla AS 'Vrsta',a.cijena AS 'Cijena',s.kolicina_stanje AS 'Količina' FROM artikal a,skladiste s WHERE a.artikal_id=s.artikal_id";
            Utility.executeQuery(query, 1);
            dataGridView1.DataSource = Utility.tabela;
            Utility.stopQuery(1);
            ModificirajGridView(dataGridView1);
            
        }

        private void createDefaulOrder() { 
        }

        private void CreateOrderForm_Load(object sender, EventArgs e)
        {
            createDefaulOrder();
            ShowArticles();
            TakeLastOrder();
            Cart();
            TotalPrice();
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            TakeLastOrder();
            String queryA = "UPDATE narudzbenica SET kupac_id = '" + customerID + "', datum_narudzbe = '" + DateTime.Now.ToString("yyyy-MM-dd") + "', state = '1' WHERE kupac_id = '"+customerID+"'";
            Utility.executeQuery(queryA, 0);
            MessageBox.Show("Narudžba je kreirana.");
            Utility.pritisnuto = 0;

            String query = "INSERT INTO narudzbenica(kupac_id,datum_narudzbe, state) VALUES('" + customerID + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "', 0)";
            Utility.executeQuery(query, 0);
            Utility.stopQuery(0);

            textBoxTotal.Text = "";
            TakeLastOrder();
            ShowArticles();
            Cart();

        }

        private void TakeLastOrder()
        {
            try
            {
                String query = "SELECT narudzbenica_id FROM narudzbenica WHERE kupac_id='" + customerID + "'ORDER BY narudzbenica_id DESC";
                Utility.executeQuery(query, 2);
                reader = Utility.reader;
                reader.Read();
                if (reader.HasRows) lastOrder = reader[0].ToString();
                Utility.stopQuery(2);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Cart() {
            String query = "SELECT s.stavka_id AS 'ID stavke', s.narudzbenica_id AS 'ID narudzbe', s.artikal_id AS 'ID artikla',s.kolicina AS 'Količina',a.naziv_artikla AS 'Naziv artikla' FROM artikal a,stavka_narudzbenice s,narudzbenica n WHERE s.artikal_id=a.artikal_id AND n.narudzbenica_id=s.narudzbenica_id AND s.narudzbenica_id='" + lastOrder + "' AND n.kupac_id='" + customerID + "'";
            Utility.executeQuery(query, 1);
            dataGridView2.DataSource = Utility.tabela;
            Utility.stopQuery(1);
            ModificirajGridView(dataGridView2);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                string queryCheckArtikal = "SELECT artikal_id FROM artikal";
                Utility.executeQuery(queryCheckArtikal, 2);
                reader = Utility.reader;
                while (reader.Read()) {
                    if (reader[0].ToString() == textBoxID.Text)
                    {
                        postojiArtikal = 1;
                        break;
                    };
                }
                if (postojiArtikal == 0) {
                    MessageBox.Show("Molimo vas unesite pravilan id artikla.");
                    errorProvider1.SetError(textBoxID, "Molimo vas unesite pravilan id artikla.");
                    return;
                }
                Utility.stopQuery(2);

                string queryProvjeriObrisi = "SELECT artikal_id FROM stavka_narudzbenice sn, narudzbenica n WHERE sn.artikal_id = 1  AND sn.narudzbenica_id = n.narudzbenica_id AND n.kupac_id = 2";


                if (lastOrder == null) {
                    String query = "INSERT INTO narudzbenica(kupac_id,datum_narudzbe, state) VALUES('" + customerID + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "', 0)";
                    Utility.executeQuery(query, 0);
                    Utility.stopQuery(0);
                }

                TakeLastOrder();
                String queryState = "SELECT STATE FROM narudzbenica where narudzbenica_ID = '"+lastOrder+"' AND kupac_id = '"+customerID+"' ORDER BY state DESC LIMIT 1 ";
                Utility.executeQuery(queryState, 2);
                reader = Utility.reader;               
                reader.Read();
                if (reader.HasRows)
                {
                    state = Convert.ToInt32(reader[0]);
                }
                else {
                    String query = "INSERT INTO narudzbenica(kupac_id,datum_narudzbe, state) VALUES('" + customerID + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "', 0)";
                    Utility.executeQuery(query, 0);
                    Utility.stopQuery(0);
                    state = 0;
                }
                Utility.stopQuery(2);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }

            if (state == 1) {
                Utility.pritisnuto = 0;
            }
            if (state == 0) {
                Utility.pritisnuto = 1;
            }

            if (Utility.pritisnuto == 0) {
                String query = "INSERT INTO narudzbenica(kupac_id,datum_narudzbe, state) VALUES('" + customerID + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "', 0)";
                Utility.executeQuery(query, 0);
                Utility.stopQuery(0);
                Utility.pritisnuto = 1;
            }
            
            TakeLastOrder();

            //String queryOne = "INSERT INTO stavka_narudzbenice(narudzbenica_id,artikal_id,kolicina) VALUES('" + lastOrder + "','" + textBoxID.Text + "','" + textBoxKOL.Text + "')";
            //Utility.executeQuery(queryOne, 0);
            //Cart();

            String queryTwo = "SELECT kolicina_stanje FROM skladiste WHERE artikal_id='" + textBoxID.Text + "'";
            Utility.executeQuery(queryTwo, 2);
            reader = Utility.reader;
            reader.Read();

            int kolicinaStanjeKolicina = Convert.ToInt32(reader[0]) - Convert.ToInt32(textBoxKOL.Text);
            if (kolicinaStanjeKolicina < 0) {
                MessageBox.Show("Trenutno nemamo toliko proizvoda na stanju.");
                return;
            }
            String queryOne = "INSERT INTO stavka_narudzbenice(narudzbenica_id,artikal_id,kolicina) VALUES('" + lastOrder + "','" + textBoxID.Text + "','" + textBoxKOL.Text + "')";
            Utility.executeQuery(queryOne, 0);
            Cart();
            Utility.stopQuery(2);
            String queryThree = "UPDATE skladiste SET kolicina_stanje='" + kolicinaStanjeKolicina + "' WHERE artikal_id='" + textBoxID.Text + "'";
            Utility.executeQuery(queryThree, 0);
            Utility.stopQuery(0);
          
            ShowArticles();
            Cart();
            TotalPrice();
        }

        private void TotalPrice()
        {
            int totalPrice = 0;
            String query = "SELECT sn.kolicina,a.cijena FROM stavka_narudzbenice sn,artikal a, narudzbenica n WHERE n.narudzbenica_id=sn.narudzbenica_id AND sn.artikal_id=a.artikal_id AND sn.narudzbenica_id='" + lastOrder + "' AND n.kupac_id='" + customerID + "'  ";

            Utility.executeQuery(query, 2);
            reader = Utility.reader;

            while (reader.Read())
            {
                String amount = reader[0].ToString();
                String price = reader[1].ToString();
                int total = Convert.ToInt32(amount) * Convert.ToInt32(price);
                totalPrice += total;
            }

            Utility.stopQuery(2);

            textBoxTotal.Text = totalPrice.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (CheckTextBoxId() == 1) return;

                String queryHelper = "SELECT sn.artikal_id FROM narudzbenica n, stavka_narudzbenice sn WHERE n.narudzbenica_id = sn.narudzbenica_id AND n.kupac_id = '"+customerID+"'";
                Utility.executeQuery(queryHelper, 2);
                reader = Utility.reader;
                while (reader.Read()) {
                    if (reader[0].ToString() == textBoxID.Text) dobar = 1;
                }
                if (dobar == 0) {
                    MessageBox.Show("Molimo vas unesite pravilan id artikla iz stavke narudzbenice.");
                    return;
                }
                //if (reader.HasRows) MessageBox.Show("IMA");
                //else MessageBox.Show("NEMA");
                Utility.stopQuery(2);


                String queryOne = "SELECT sn.stavka_id FROM stavka_narudzbenice sn,skladiste s WHERE sn.artikal_id=s.artikal_id AND sn.artikal_id='" + textBoxID.Text + "' AND narudzbenica_id='" + lastOrder + "' ORDER BY stavka_id DESC";
                String queryTwo = "SELECT kolicina,kolicina_stanje FROM stavka_narudzbenice sn,skladiste s WHERE sn.artikal_id=s.artikal_id AND s.artikal_id='" + textBoxID.Text + "' AND narudzbenica_id='" + lastOrder + "'";


                Utility.executeQuery(queryOne, 2);
                reader = Utility.reader;
                reader.Read();
                String item = reader[0].ToString();
                Utility.stopQuery(2);

                Utility.executeQuery(queryTwo, 2);
                reader = Utility.reader;
                reader.Read();


                String amount = reader[0].ToString();
                String amountHelper = reader[1].ToString();


                int final = Convert.ToInt32(amount) + Convert.ToInt32(amountHelper);

                Utility.stopQuery(2);

                String queryThree = "UPDATE skladiste SET kolicina_stanje='" + final + "' WHERE artikal_id='" + textBoxID.Text + "'";
                String queryFour = "DELETE FROM stavka_narudzbenice WHERE artikal_id='" + textBoxID.Text + "' AND narudzbenica_id='" + lastOrder + "' AND stavka_id='" + item + "'";

                Utility.executeQuery(queryFour, 0);
                Utility.executeQuery(queryThree, 0);

                MessageBox.Show("Artikl izbrisan iz korpe.");

                Utility.stopQuery(0);

                ShowArticles();
                Cart();
                TotalPrice();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }

        }

        private void CreateOrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void prikazNarudžbiIStavkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOrders sw = new ShowOrders();
            this.Hide();
            sw.Show();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }



    }
}
