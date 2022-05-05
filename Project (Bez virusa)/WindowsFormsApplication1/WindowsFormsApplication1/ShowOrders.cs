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
    public partial class ShowOrders : Form
    {
        public ShowOrders()
        {
            InitializeComponent();
        }

        private void ShowOrders_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        String customerID = LoginForm.customerID;
        String order = CreateOrderForm.lastOrder;
        MySqlDataReader reader;

        private void ShowOrders_Load(object sender, EventArgs e)
        {
            ShowOrderz();
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

        private void ShowOrderz()
        {
            String query = "SELECT narudzbenica_id AS 'ID narudzbe',datum_narudzbe AS 'Datum narudzbe' from " +
            "narudzbenica WHERE kupac_id='" + customerID + "'";

            Utility.executeQuery(query, 1);

            dataGridViewOrders.DataSource = Utility.tabela;

            Utility.stopQuery(1);

            ModificirajGridView(dataGridViewOrders);

        }

        private void ShowOrderItem()
        {
            String query = "SELECT s.stavka_id AS 'ID stavke', s.narudzbenica_id AS 'ID narudzbe', s.artikal_id AS 'ID artikla',s.kolicina AS 'Količina'," +
            " a.naziv_artikla AS 'Naziv artikla',a.cijena AS 'Cijena' FROM artikal a,stavka_narudzbenice s,narudzbenica n WHERE s.artikal_id=a.artikal_id " +
            " AND n.narudzbenica_id=s.narudzbenica_id AND s.narudzbenica_id='" + textBoxID.Text + "' AND n.kupac_id='" + customerID + "'";

            Utility.executeQuery(query, 1);

            dataGridViewItemOrders.DataSource = Utility.tabela;

            Utility.stopQuery(1);

            ModificirajGridView(dataGridViewItemOrders);
        }

        private void TotalPrice()
        {
            int totalPrice = 0;
            String query = "SELECT sn.kolicina,a.cijena FROM stavka_narudzbenice sn,artikal a, narudzbenica n " +
            "WHERE n.narudzbenica_id=sn.narudzbenica_id AND sn.artikal_id=a.artikal_id AND " +
            "sn.narudzbenica_id='" + textBoxID.Text + "' AND n.kupac_id='" + customerID + "'  ";

            Utility.executeQuery(query, 2);

            reader = Utility.reader;

            while (reader.Read())
            {
                String amount = reader[0].ToString();
                String price = reader[1].ToString();
                int total = Convert.ToInt32(amount) * Convert.ToInt32(price);
                totalPrice += total;
            }

            Utility.stopQuery(1);

            textBoxTotalPrice.Text = totalPrice.ToString();
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            ShowOrderItem();
            TotalPrice();
        }

        private void kreiranjeNarudžbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateOrderForm co = new CreateOrderForm();
            this.Hide();
            co.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();
        }

    }
}
