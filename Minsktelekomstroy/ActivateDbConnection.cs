using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Minsktelekomstroy
{
    internal class ActivateDbConnection
    {
        protected internal SqlConnection connection;

        public ActivateDbConnection() { }

        ~ActivateDbConnection() { }

        public async Task SetConnection()
        {
            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Minsktelekomstroy.mdf;Integrated Security=True";
            using (connection = new SqlConnection(connectionstring))
            {
                try
                {
                    await connection.OpenAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
