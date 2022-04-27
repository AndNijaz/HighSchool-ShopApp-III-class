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
    public static class Utility
    {
        public static MySqlConnection konekcija;
        public static MySqlDataAdapter dataAdapter;
        public static DataTable tabela;
        public static MySqlDataReader reader;

        public static String konekcioniString = "Server=localhost; Port=3306; " +
        "Database=projekat; Uid=root; Pwd=123";

        public static void executeQuery(String query, Int32 state)
        {
            try
            {
                konekcija = new MySqlConnection(konekcioniString);
                konekcija.Open();
                MySqlCommand cmd = new MySqlCommand(query, konekcija);
                if (state == 0)
                {
                    cmd.ExecuteNonQuery();
                }
                if (state == 1)
                {
                    dataAdapter = new MySqlDataAdapter(query, konekcija);
                    tabela = new DataTable();
                    dataAdapter.Fill(tabela);
                }
                if (state == 2)
                {
                    reader = cmd.ExecuteReader();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void stopQuery(Int32 state)
        {
            if(state == 1){
                dataAdapter.Dispose();
            }
            if (state == 2) {
                reader.Close();
            }

            konekcija.Close();
        }
    }
}
