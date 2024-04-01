using FireSharp.Extensions;
using FireSharp.Response;
using N19_DentalClinic.database;
using N19_DentalClinic.model;


namespace N19_DentalClinic.repository
{
    internal class PersonRepository
    {
        FirebaseConnection firebaseConnection;

        public PersonRepository()
        {
            firebaseConnection = new FirebaseConnection();
        }

        public async Task<SetResponse> CreatePersonAccount(Person person)
        {
            SetResponse response = await firebaseConnection.Client.SetTaskAsync("Person/" + person.Email, person);
            return response;

        }

        public async Task<FirebaseResponse> GetAccountByEmail(string email)
        {
            FirebaseResponse response = await firebaseConnection.Client.GetTaskAsync("Person/" + email);
            return response;
        }

    }
}
