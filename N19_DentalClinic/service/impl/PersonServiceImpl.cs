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

namespace N19_DentalClinic.service.impl
{
    internal class PersonServiceImpl : PersonService
    {

        private PersonRepository personRepository;

        public PersonServiceImpl() {
            personRepository = new PersonRepository();
        } 

        public async void CreatePersonAccount(Person person)
        {
            person.Email = MyLibrary.formatEmail(person.Email);
            Task<SetResponse> responseTask = personRepository.CreatePersonAccount(person);
            SetResponse response = await responseTask;
            if (response.Body != "null")
            {
                MessageBox.Show("Tạo tài khoản thành công");
            }
        }

        public async Task<Person> GetAccountByEmail(string email)
        {
            email = MyLibrary.formatEmail(email);
            Task<FirebaseResponse> responseTask = personRepository.GetAccountByEmail(email);
            FirebaseResponse response = await responseTask;
            if (response.Body != "null")
            {
                Person person = response.ResultAs<Person>();
                return person;
            }
            return null;
        }
    }
}
