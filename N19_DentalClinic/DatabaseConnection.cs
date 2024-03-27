using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace N19_DentalClinic
{

    internal class DatabaseConnection
    {
        string myConnectionString = "server=localhost;database=dental_clinic;uid=root;pwd=my-secret-pw";
        public DatabaseConnection()
        {
            MySqlConnection myConnection = new MySqlConnection(myConnectionString);

        }

    }
}
