﻿using FireSharp.Extensions;
using FireSharp.Response;
using N19_DentalClinic.database;
using N19_DentalClinic.model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace N19_DentalClinic.repository
{
    internal class PersonRepository
    {
        FirebaseConnection firebaseConnection;

        public PersonRepository()
        {
            firebaseConnection = new FirebaseConnection();
        }

        public async void CreatePersonAccount(Person person)
        {
            SetResponse response = await firebaseConnection.Client.SetTaskAsync("Person/" + person.Email, person);
            Person result = response.ResultAs<Person>();
        }

        public async Task<FirebaseResponse> GetAccountByEmail(string email)
        {
            FirebaseResponse response = await firebaseConnection.Client.GetTaskAsync("Person/" + email);
            return response;
        }
    }
}
