using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phonebook.Models;
using Npgsql;
using System.Configuration;

namespace Phonebook.Services
{
    class PostgreSqlContactsRepository : IContactsRepository
    {
        private readonly string _conn = ConfigurationManager.ConnectionStrings["PhonebookDb"].ConnectionString;

        #region IContactsRepository Members

        public async Task<ContactDetails> GetContactDetailsAsync(int id)
        {
            return await Task.Run(() =>
            {
                return GetContactDetails(id);
            });
        }

        public async Task<List<ContactDetails>> GetContactsAsync()
        {
            return await Task.Run(() =>
             {
                 return GetContacts();
             });
        }
        #endregion

        #region Private Members
        private List<ContactDetails> GetContacts()
        {
            List<ContactDetails> contacts = new List<ContactDetails>();
            string cmdTxt = 
                "SELECT Id, Name, Surname, City, PhoneNumber " + 
                "FROM ContactDetails";
            using (var conn = new NpgsqlConnection(_conn))
            using (var cmd = new NpgsqlCommand(cmdTxt, conn))
            {
                conn.Open();
                using (var results = cmd.ExecuteReader())
                {
                    while (results.Read())
                    {
                        contacts.Add(new ContactDetails
                        {
                            Id = Int32.Parse(results["Id"].ToString()),
                            Name = results["Name"].ToString(),
                            Surname = results["Surname"].ToString(),
                            City = results["City"].ToString(),
                            PhoneNumber = results["PhoneNumber"].ToString()
                        });
                    }
                }
            }
            return contacts;
        }

        private ContactDetails GetContactDetails(int id)
        {
            ContactDetails contact = null;
            string cmdTxt =
                "SELECT Id, Name, Surname, City, PhoneNumber " +
                "FROM ContactDetails " +
                "WHERE Id = @Id";
            using (var conn = new NpgsqlConnection(_conn))
            using (var cmd = new NpgsqlCommand(cmdTxt, conn))
            {
                conn.Open();
                cmd.Parameters.Add(new NpgsqlParameter("@Id", id));
                using (var results = cmd.ExecuteReader())
                {
                    while (results.Read())
                    {
                        contact = new ContactDetails
                        {
                            Id = Int32.Parse(results["Id"].ToString()),
                            Name = results["Name"].ToString(),
                            Surname = results["Surname"].ToString(),
                            City = results["City"].ToString(),
                            PhoneNumber = results["PhoneNumber"].ToString()
                        };
                    }
                }
            }
            return contact;
        }
        #endregion
    }
}
