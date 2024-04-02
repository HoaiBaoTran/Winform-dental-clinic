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
                FirebaseResponse response = await personRepository.GetAccountByIdToken(idToken);
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
            if (existPerson != null)
            {
                if (existPerson.Email == person.Email && PasswordHasher.VerifyPassword(person.Password, existPerson.Password))
                {
                    MessageBox.Show("Đăng nhập thành công");
                    }
                else
                {
                    MessageBox.Show("Email hoặc mật khẩu không đúng");
                }

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
