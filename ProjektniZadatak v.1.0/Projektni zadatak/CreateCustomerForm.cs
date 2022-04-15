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
    public partial class CreateCustomerForm : Form
    {
        public CreateCustomerForm()
        {
            InitializeComponent();
        }

        public static String konekcioniString = LoginForm.konekcioniString;

        private static MySqlConnection konekcija;
        private static MySqlDataAdapter dataAdapter;
        private static DataTable tabela;
        private static MySqlDataReader reader;

        private static void executeQuery(String query, Int32 state)
        {
            try { 
                konekcija = new MySqlConnection(konekcioniString);
                konekcija = new MySqlConnection(konekcioniString);
                konekcija.Open();
                MySqlCommand cmd = new MySqlCommand(query, konekcija);
                if (state == 1) { 
                    dataAdapter = new MySqlDataAdapter(query, konekcija);
                    tabela = new DataTable();
                }
                if (state == 0) {
                    cmd.ExecuteNonQuery();
                }
                if (state == 2) {
                    reader = cmd.ExecuteReader();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void stopQuery(Int32 state)
        {
            if (state == 1) dataAdapter.Dispose();
            if (state == 0) reader.Close();
            konekcija.Close();
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

        private void PrikazKupaca()
        {
            String query = "SELECT kupac_id AS 'ID kupca', ime AS 'Ime', prezime AS 'Prezime',grad AS 'Grad',adresa AS 'Adresa',telefon AS 'Telefon' FROM kupac WHERE kupac_id=kupac_id ";
            try
            {

                if (textBoxFindFirstName.Text != "")
                {
                    query += "and ime LIKE '" + textBoxFindFirstName.Text + "%'";
                }

                if (textBoxFindLastName.Text != "")
                {
                    query += "and prezime LIKE '" + textBoxFindLastName.Text + "%'";
                }

                executeQuery(query, 1);

                dataAdapter.Fill(tabela);
                dataGridView1.DataSource = tabela;

                dataAdapter.Dispose();
                konekcija.Close();

                stopQuery(1);

                ModificirajGridView(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxFindFirstName_TextChanged(object sender, EventArgs e)
        {
            PrikazKupaca();
        }

        private void textBoxFindLastName_TextChanged(object sender, EventArgs e)
        {
            PrikazKupaca();
        }

        private void CreateCustomerButton_Click(object sender, EventArgs e)
        {
            String query = "INSERT INTO kupac(ime,prezime,grad,adresa,telefon,user,pass) VALUES ('" + textBoxName.Text + "','" + textBoxPrezime.Text + "','" + textBoxTown.Text + "','" + textBoxAdress.Text + "','" + textBoxMobilePhone.Text + "','" + textBoxUsername.Text + "','" + textBoxPassword.Text + "')";

            executeQuery(query, 0);
            MessageBox.Show("Dodan novi kupac.");
            stopQuery(0);
            PrikazKupaca();
        }

        private void UpdateCustomerButton_Click(object sender, EventArgs e)
        {
            String query = "UPDATE kupac SET ime='" + textBoxName.Text + "',prezime='" + textBoxPrezime.Text + "',grad='" + textBoxTown.Text + "',adresa='" + textBoxAdress.Text + "',telefon='" + textBoxMobilePhone.Text + "',user='" + textBoxUsername.Text + "',pass='" + textBoxPassword.Text + "' WHERE kupac_id='" + textBoxID.Text + "'";
            executeQuery(query, 0);
            MessageBox.Show("Dodan novi kupac.");
            stopQuery(0);
            PrikazKupaca();
        }

        private void CreateCustomerForm_Load(object sender, EventArgs e)
        {
            PrikazKupaca();

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            String query = "SELECT ime,prezime,grad,adresa,telefon,user,pass FROM kupac WHERE kupac_id='" + textBoxID.Text + "'";
            executeQuery(query, 2);
            reader.Read();
            if (reader.HasRows)
            {
                textBoxName.Text = reader[0].ToString();
                textBoxPrezime.Text = reader[1].ToString();
                textBoxTown.Text = reader[2].ToString();
                textBoxAdress.Text = reader[3].ToString();
                textBoxMobilePhone.Text = reader[4].ToString();
                textBoxUsername.Text = reader[5].ToString();
                textBoxPassword.Text = reader[6].ToString();
            }

            stopQuery(0);
        }

        private void CreateCustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dodavanjeIAžuriranjeArtiklaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateArticle CreateArticleForm = new CreateArticle();
            this.Hide();
            CreateArticleForm.Show();
        }

        private void priakzIBrisanjeNarudžbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteOrder DeleteOrderForm = new DeleteOrder();
            this.Hide();
            DeleteOrderForm.Show();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm LoginFormForm = new LoginForm();
            this.Hide();
            LoginFormForm.Show();
        }


    }
}
