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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        public static String customerID;
        public static String konekcioniString = "Server=localhost; Port=3306; " +
        "Database=projekat; Uid=root; Pwd=123";

        private static MySqlConnection konekcija;
        private static MySqlDataReader reader;


        private static void executeQuery(String query) {
            try
            {
                konekcija = new MySqlConnection(konekcioniString);
                konekcija.Open();
                MySqlCommand cmd = new MySqlCommand(query, konekcija);
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void stopQuery() {
            reader.Close();
            konekcija.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            String korisnickoIme = textBoxUsername.Text;
            String korisnickaSifra = textBoxPassword.Text;

            String query = "SELECT CONCAT(ime,' ',prezime),pass,kupac_id FROM kupac WHERE user='" + korisnickoIme + "'";

            executeQuery(query);

            reader.Read();


            if (!reader.HasRows){
                errorProvider1.SetError(textBoxUsername, "Pogrešno korisničko ime.");
                return;
            }

            String imeIPrezime = reader[0].ToString();
            String password = reader[1].ToString();
            customerID = reader[2].ToString();

            if (korisnickaSifra != password) {
                errorProvider1.SetError(textBoxPassword, "Pogrešna šifra.");
            }

            if (customerID == "1")
            {
                MessageBox.Show("Administrator " + imeIPrezime + " uspješno logovan.");
                CreateCustomerForm createCustomer = new CreateCustomerForm();
                this.Hide();
                createCustomer.Show();
                return;
            }

            MessageBox.Show("Uspješno ste se logovali " + imeIPrezime);
            CreateOrderForm createOrder = new CreateOrderForm();
            this.Hide();
            createOrder.Show();


            stopQuery();
            

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
