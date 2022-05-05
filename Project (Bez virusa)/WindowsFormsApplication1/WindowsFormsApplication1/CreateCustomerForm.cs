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
    public partial class CreateCustomerForm : Form
    {
        public CreateCustomerForm()
        {
            InitializeComponent();
        }
        private static MySqlDataReader reader;

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
            if (textBoxFindFirstName.Text != "") query += "and ime LIKE '" + textBoxFindFirstName.Text + "%'";
            if (textBoxFindLastName.Text != "") query += "and prezime LIKE '" + textBoxFindLastName.Text + "%'";

            Utility.executeQuery(query, 1);
            dataGridView1.DataSource = Utility.tabela;
            Utility.stopQuery(1);
            ModificirajGridView(dataGridView1);
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
            errorProvider1.Clear();
            if (textBoxName.Text == "" || textBoxPrezime.Text == "" || textBoxTown.Text == "" || textBoxAdress.Text == "" || textBoxUsername.Text == "" || textBoxMobilePhone.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Molimo vas pravilno popunite formu");
                return;
            }

            string queryProvjeri = "SELECT user FROM kupac";
            Utility.executeQuery(queryProvjeri, 2);
            reader = Utility.reader;
            while (reader.Read())
            {
                if (reader[0].ToString() == textBoxUsername.Text)
                {
                    MessageBox.Show("Već postoji uneseno korisničko ime.");
                    errorProvider1.SetError(textBoxUsername, "Već postoji uneseno korisničko ime.");
                    return;
                }
            }

            String query = "INSERT INTO kupac(ime,prezime,grad,adresa,telefon,user,pass) VALUES ('" + textBoxName.Text + "','" + textBoxPrezime.Text + "','" + textBoxTown.Text + "','" + textBoxAdress.Text + "','" + textBoxMobilePhone.Text + "','" + textBoxUsername.Text + "','" + textBoxPassword.Text + "')";
            Utility.executeQuery(query, 0);
            MessageBox.Show("Dodan novi kupac.");
            Utility.stopQuery(0);
            PrikazKupaca();

            textBoxName.Text = "";
            textBoxPrezime.Text = "";
            textBoxTown.Text = "";
            textBoxAdress.Text = "";
            textBoxUsername.Text = "";
            textBoxMobilePhone.Text = "";
            textBoxPassword.Text = "";
        }

        private void UpdateCustomerButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (textBoxID.Text == "")
            {
                MessageBox.Show("Molim vas unseite validan korisnički id!");
                errorProvider1.SetError(textBoxID, "Pogrešan id.");
                return;
            }
            String query = "UPDATE kupac SET ime='" + textBoxName.Text + "',prezime='" + textBoxPrezime.Text + "',grad='" + textBoxTown.Text + "',adresa='" + textBoxAdress.Text + "',telefon='" + textBoxMobilePhone.Text + "',user='" + textBoxUsername.Text + "',pass='" + textBoxPassword.Text + "' WHERE kupac_id='" + textBoxID.Text + "'";
            Utility.executeQuery(query, 0);
            MessageBox.Show("Ažuriran kupac sa id-om " + textBoxID.Text + ".");
            Utility.stopQuery(0);
            PrikazKupaca();
        }

        private void CreateCustomerForm_Load(object sender, EventArgs e)
        {
            PrikazKupaca();
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            String query = "SELECT ime,prezime,grad,adresa,telefon,user,pass FROM kupac WHERE kupac_id='" + textBoxID.Text + "'";
            Utility.executeQuery(query, 2);
            reader = Utility.reader;
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

            Utility.stopQuery(2);
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
