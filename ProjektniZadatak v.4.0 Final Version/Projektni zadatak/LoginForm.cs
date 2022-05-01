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
        private static MySqlDataReader reader;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            String korisnickoIme = textBoxUsername.Text;
            String korisnickaSifra = textBoxPassword.Text;

            String query = "SELECT CONCAT(ime,' ',prezime),pass,kupac_id FROM kupac WHERE user='" + korisnickoIme + "'";

            Utility.executeQuery(query, 2);

            reader = Utility.reader;
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
                return;
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


            Utility.stopQuery(2);
            

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
