using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N19_DentalClinic.model
{
    class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }

        public Person() { }

        public Person(string name, string email, string password, string phoneNumber)
        {
            this.Name = name;
            this.Email = email;
            this.Password = password;
            this.PhoneNumber = phoneNumber;
        }

        public Person(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }

        public override string ToString()
        {
            return String.Format("Name: {0}, Email: {1}, PhoneNumber: {2}", Name, Email, PhoneNumber);
        }

    }
}
