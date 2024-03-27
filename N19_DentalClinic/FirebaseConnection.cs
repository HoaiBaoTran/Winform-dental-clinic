using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace N19_DentalClinic
{
    public class FirebaseConnection
    {
        IFirebaseConfig config = new FirebaseConfig {
            AuthSecret = "IpKcFdMVCXUWRqo8pok7lHzyA9VUeJHKSX403PsP",
            BasePath = "https://winform-dental-clinic-default-rtdb.firebaseio.com/"
        };

        public IFirebaseClient Client { get; set; }
    
        public FirebaseConnection() {
            Client = new FireSharp.FirebaseClient(config);

            if (Client != null )
            {
                MessageBox.Show("Connection is established");
            }
            else
            {
                MessageBox.Show("Can't connect to database");
            }
        }
    }
}
