
using FireSharp.Config;
using FireSharp.Interfaces;

namespace N19_DentalClinic.database
{
    public class FirebaseConnection
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "IpKcFdMVCXUWRqo8pok7lHzyA9VUeJHKSX403PsP",
            BasePath = "https://winform-dental-clinic-default-rtdb.firebaseio.com/"
        };

        public IFirebaseClient Client { get; set; }

        public FirebaseConnection()
        {
            this.Client = new FireSharp.FirebaseClient(config);

            if (Client == null)
            {
                MessageBox.Show("Can't connect to database");
            }
        }
    }
}
