using FireSharp.Extensions;
using FireSharp.Response;
using N19_DentalClinic.database;
using N19_DentalClinic.library;
using N19_DentalClinic.model;
using Newtonsoft.Json;
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
                person.IdToken = userId;
                person.Id = MyLibrary.DecodeIdToken(userId); 
                bool isEmailVerified = await firebaseAuthenticator.IsEmailVerified(userId);
                if (!isEmailVerified)
                {
                    firebaseAuthenticator.SendVerificationEmail(userId);
                    MessageBox.Show("Vui lòng xác nhận tài khoản email");
                }
                person.Password = "";
                SetResponse response = await firebaseConnection.Client.SetTaskAsync("Person/" + person.Id, person);
                return response;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Authentication failed: " + ex.Message);
                return null;
            }

        }

        public async Task<FirebaseResponse> GetAccountByIdToken(string idToken)
        {
            FirebaseResponse response = await firebaseConnection.Client.GetTaskAsync("Person/" + idToken);
            return response;
        }

        public async Task<string> FindIdTokenByEmail(string email)
        {
            FirebaseResponse response = await firebaseConnection.Client.GetTaskAsync("Person");

            if (response.Body != "null")
            {
                dynamic data = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(response.Body);
                foreach (var key in data.Keys)
                {
                    var userObj = data[key];
                    string userEmail = userObj["Email"].ToString();
                    if (userEmail == email)
                    {
                        return userObj["IdToken"].ToString();
                    }

                }
            }
            return "";
        }

        public async Task<bool> IsEmailVerified(string idToken)
        {
            return await firebaseAuthenticator.IsEmailVerified(idToken);
        }

        public async void SendVerificationEmail(string idToken)
        {
            await firebaseAuthenticator.SendVerificationEmail(idToken);
        }

        public async Task<string> SignInWithEmailAndPassword(string email, string password)
        {
            string idToken =  await firebaseAuthenticator.SignInWithEmailAndPassword(email, password);
            return idToken;
        }

        public async Task<FirebaseResponse> UpdateIdToken(string userId, string newToken)
        {
            FirebaseResponse response = await GetPersonData(userId);
            Person existPerson = response.ResultAs<Person>();
            existPerson.IdToken = newToken;
            return await firebaseConnection.Client.UpdateTaskAsync($"Person/{userId}", existPerson);
        }

        public async Task<FirebaseResponse> GetPersonData(string userId)
        {
            return await firebaseConnection.Client.GetTaskAsync($"Person/{userId}");
        }

        public async Task<bool> ResetPassword(string email)
        {
            return await firebaseAuthenticator.ResetPasswordAsync(email);
        }
    }
}
