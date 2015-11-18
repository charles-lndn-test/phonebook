using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phonebook.Models;

namespace Phonebook.Services
{
    interface IContactsRepository
    {
        Task<List<ContactDetails>> GetContactsAsync();
        Task<ContactDetails> GetContactDetailsAsync(int id);
    }
}
