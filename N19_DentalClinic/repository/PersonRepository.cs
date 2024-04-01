using FireSharp.Extensions;
using FireSharp.Response;
using N19_DentalClinic.database;
using N19_DentalClinic.library;
using N19_DentalClinic.model;
using RestSharp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace N19_DentalClinic.repository
{
    internal class PersonRepository
    {
        FirebaseConnection firebaseConnection;
        FirebaseAuthenticator firebaseAuthenticator;

        public PersonRepository()
        {
            firebaseConnection = new FirebaseConnection();
            firebaseAuthenticator = new FirebaseAuthenticator();
        }
        public async Task<SetResponse> CreatePersonAccount(Person person)
        {
            try
            {
                string userId = await firebaseAuthenticator.RegisterUserWithEmailAndPassword(person.Email, person.Password);
                person.Id = MyLibrary.DecodeIdToken(userId);
                person.Password = PasswordHasher.HashPassword(person.Password);
                bool isEmailVerified = await firebaseAuthenticator.IsEmailVerified(userId);
                if (!isEmailVerified)
                {
                    firebaseAuthenticator.SendVerificationEmail(userId);
                    MessageBox.Show("Vui lòng xác nhận tài khoản email");
                }

                SetResponse response = await firebaseConnection.Client.SetTaskAsync("Person/" + person.Id, person);
                return response;
            } catch (Exception ex)
            {
                MessageBox.Show("Authentication failed: " + ex.Message);
                return null;
            }
            
        }

        public async Task<FirebaseResponse> GetAccountByEmail(string email)
        {
            FirebaseResponse response = await firebaseConnection.Client.GetTaskAsync("Person/" + email);
            return response;
        }

    }
}
