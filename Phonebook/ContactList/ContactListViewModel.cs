using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phonebook.Models;
using Phonebook.Services;

namespace Phonebook.ContactList
{
    class ContactListViewModel: BindableBase
    {

        private IContactsRepository _repo = new PostgreSqlContactsRepository();

        public ContactListViewModel()
        {
            EditContactCommand = new RelayCommand<ContactDetails>(OnEditContact);
            
        }
        
        private ObservableCollection<ContactDetails> _contacts;
        public ObservableCollection<ContactDetails> Contacts
        {
            get { return _contacts; }
            set { SetProperty(ref _contacts, value); }

        }

        public async void LoadContacts()
        {
            Contacts = new ObservableCollection<ContactDetails>(await _repo.GetContactsAsync());
        }

        public RelayCommand AddContactCommand { get; private set; }
        public RelayCommand<ContactDetails> EditContactCommand{ get; private set; }
        
        public event Action<int> EditContactRequested = delegate { };
        public event Action AddContactRequested = delegate { };
        
        private void OnEditContact(ContactDetails contact)
        {
            EditContactRequested(contact.Id);
        }
    }
}
