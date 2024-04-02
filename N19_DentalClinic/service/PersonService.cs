using N19_DentalClinic.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N19_DentalClinic.service
{
    internal interface PersonService
    {
        public void LoginAccount(Person person);
        public Task<bool> RegisterAccount(Person person);
        public Task<bool> ResetPassword(string email);
    }
}
