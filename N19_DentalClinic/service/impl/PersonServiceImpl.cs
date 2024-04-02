using FireSharp.Response;
using N19_DentalClinic.model;
using N19_DentalClinic.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using N19_DentalClinic.library;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace N19_DentalClinic.service.impl
{
    internal class PersonServiceImpl : PersonService
    {

        private PersonRepository personRepository;

        public PersonServiceImpl() {
            personRepository = new PersonRepository();
        } 

        public async Task<Person> GetAccountByEmail(string email)
        {
            string idToken = await personRepository.FindIdTokenByEmail(email);
            if (!string.IsNullOrEmpty(idToken))
            {
                string userId = MyLibrary.DecodeIdToken(idToken);
                FirebaseResponse response = await personRepository.GetAccountByIdToken(userId);
                if (response.Body != "null") { 
                    Person person = response.ResultAs<Person>();
                    return person;
                }
            }
            return null;
        }

        public async void LoginAccount(Person person)
        {
            Person existPerson = await GetAccountByEmail(person.Email);
            if (existPerson == null)
            {
                MessageBox.Show("Email hoặc mật khẩu không đúng");
                return;
            }

            if (existPerson.Email == person.Email && PasswordHasher.VerifyPassword(person.Password, existPerson.Password))
            {
                bool isEmailVerified = await personRepository.IsEmailVerified(existPerson.IdToken);
                if (!isEmailVerified)
                {
                    MessageBox.Show("Xin vui lòng xác thực email");
                    personRepository.SendVerificationEmail(existPerson.IdToken);
                    return;
                }

                string idToken = await personRepository.SignInWithEmailAndPassword(person.Email, person.Password);
                if (!string.IsNullOrEmpty(idToken)) { 
                    MessageBox.Show("Đăng nhập thành công");
                }
            }
            else
            {
                MessageBox.Show(existPerson.Email);
                MessageBox.Show(person.Email);
                MessageBox.Show(existPerson.Password);
                MessageBox.Show(person.Password);
                MessageBox.Show("Email hoặc mật khẩu không đúng wrong verify");
            }


        }

        public async Task<bool> RegisterAccount(Person person)
        {
            Person existPerson = await GetAccountByEmail(person.Email);

            if (existPerson == null)
            { 
                SetResponse response = await personRepository.CreatePersonAccount(person);
                if (response.Body != "null")
                {
                    return true;
                }
            }
            return false;
        }
    }
}
