using N19_DentalClinic.model;
using N19_DentalClinic.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N19_DentalClinic.service.impl
{
    internal class PersonServiceImpl : PersonService
    {

        private PersonRepository personRepository;

        public PersonServiceImpl() {
            personRepository = new PersonRepository();
        }

        public void CreatePersonAccount(Person person)
        {
            personRepository.CreatePersonAccount(person);
        }

        public async Task<Person> GetAccountByEmail(string email)
        {
            return await Task.FromResult(personRepository.GetAccountByEmail(email)).Result;
        }
    }
}
