using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N19_DentalClinic.database
{
    internal class FirebaseAuthenticator
    {
        private const string FirebaseApiKey = "AIzaSyAmpF1zcO4OWwXxH-vowvUkL1hMwaCUuSo";

        public async Task<string> RegisterUserWithEmailAndPassword(string email, string password)
        {
            using (var client = new HttpClient())
            {
                var request = new
                {
                    email,
                    password,
                    returnSecureToken = true
                };

                var content = new StringContent(JsonConvert.SerializeObject(request));
                var response = await client.PostAsync($"https://identitytoolkit.googleapis.com/v1/accounts:signUp?key={FirebaseApiKey}", content);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    dynamic data = JsonConvert.DeserializeObject(responseContent);
                    return data.idToken;
                }
                else
                {
                    throw new Exception("User registration failed.");
                }
            }
        }

        public async Task<bool> IsEmailVerified(string idToken)
        {
            using (var client = new HttpClient())
            {
                var request = new
                {
                    idToken
                };

                var content = new StringContent(JsonConvert.SerializeObject(request));
                var response = await client.PostAsync($"https://identitytoolkit.googleapis.com/v1/accounts:lookup?key={FirebaseApiKey}", content);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    dynamic data = JsonConvert.DeserializeObject(responseContent);

                    // Check if the user's email is verified
                    return data.users[0].emailVerified;
                }
                else
                {
                    throw new Exception("Failed to check email verification status.");
                }
            }
        }

        public async Task<string> FindIdTokenByEmail(string email)
        {
            using (var client = new HttpClient())
            {
                var request = new
                {
                    email
                };

                var content = new StringContent(JsonConvert.SerializeObject(request));
                var response = await client.PostAsync($"https://identitytoolkit.googleapis.com/v1/accounts:lookup?key={FirebaseApiKey}", content);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    dynamic data = JsonConvert.DeserializeObject(responseContent);

                    // Loop through the users returned in the response and find the user with matching email
                    foreach (var user in data.users)
                    {
                        if (user.email == email)
                        {
                            return user.idToken;
                        }
                    }
                    // If no user with matching email found
                    return null;
                }
                else
                {
                    throw new Exception("Failed to find user by email.");
                }
            }
        }

        public async Task SendVerificationEmail(string idToken)
        {
            using (var client = new HttpClient())
            {
                var request = new
                {
                    requestType = "VERIFY_EMAIL",
                    idToken
                };

                var content = new StringContent(JsonConvert.SerializeObject(request));
                var response = await client.PostAsync($"https://identitytoolkit.googleapis.com/v1/accounts:sendOobCode?key={FirebaseApiKey}", content);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Failed to send verification email.");
                }
            }
        }

        public async Task<string> SignInWithEmailAndPassword(string email, string password)
        {
            using (var client = new HttpClient())
            {
                var request = new
                {
                    email,
                    password,
                    returnSecureToken = true
                };

                var content = new StringContent(JsonConvert.SerializeObject(request));
                var response = await client.PostAsync($"https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key={FirebaseApiKey}", content);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    dynamic data = JsonConvert.DeserializeObject(responseContent);
                    return data.idToken;
                }
                else
                {
                    throw new Exception("Authentication failed.");
                }
            }
        }

    
    }
}
