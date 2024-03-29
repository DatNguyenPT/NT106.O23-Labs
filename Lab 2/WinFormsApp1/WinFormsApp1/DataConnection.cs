using System;
using System.Data;
using System.Data.SQLite;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    class DataClass
    {
        private SQLiteConnection sqlite;

        public DataClass()
        {
            string databasePath = @"E:\UIT\Sophomore\Network Programming\Lab\Lab 2\lab2_ex6_database\.FoodData.db";
            sqlite = new SQLiteConnection("Data Source=" + databasePath);
        }

        public DataTable dataQuery(string query)
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();

            try
            {
                sqlite.Open();
                SQLiteCommand cmd = sqlite.CreateCommand();
                cmd.CommandText = query;
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Không có món ăn phù hợp.\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlite.State == ConnectionState.Open)
                {
                    sqlite.Close();
                }
            }

            return dt;
        }
    }
}
