using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projektni_zadatak
{
    public static class Utility
    {
        public static String konekcioniString = "Server=localhost; Port=3306; " +
            "Database=projekat; Uid=root; Pwd=123";

        public static void executeQuery(String query) {
            try {
                MessageBox.Show(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
