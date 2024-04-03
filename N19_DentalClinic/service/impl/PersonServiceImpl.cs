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

        public async Task<bool> LoginAccount(Person person)
        {
            Person existPerson = await GetAccountByEmail(person.Email);
            if (existPerson == null)
            {
                MessageBox.Show("Email hoặc mật khẩu không đúng");
                return false;
            }

            /*
            bool isEmailVerified = await personRepository.IsEmailVerified(existPerson.IdToken);
            if (!isEmailVerified)
            {
                MessageBox.Show("Xin vui lòng xác thực email");
                personRepository.SendVerificationEmail(existPerson.IdToken);
                return;
             }
            */

            string idToken = await personRepository.SignInWithEmailAndPassword(person.Email, person.Password);
            if (string.IsNullOrEmpty(idToken)) {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                return false;
            }

            FirebaseResponse respone = await personRepository.UpdateIdToken(existPerson.Id, idToken);
            if (respone.Body != "null")
            {
                MessageBox.Show("Đăng nhập thành công");
                return true;
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
                return false;
            }
        }

        public async Task<bool> ResetPassword(string email)
        {
            Person existPerson = await GetAccountByEmail(email);
            if (existPerson == null)
            {
                MessageBox.Show("Email không đúng");
                return false;
            }

            bool isSuccessful = await personRepository.ResetPassword(email);
            return isSuccessful;
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
