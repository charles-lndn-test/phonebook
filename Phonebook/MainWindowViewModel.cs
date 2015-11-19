using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phonebook.ContactList;
using Phonebook.AddEditContact;
using Phonebook.Models;
using Phonebook.Services;

namespace Phonebook
{
    public class MainWindowViewModel: BindableBase
    {
        private IContactsRepository _repo = new PostgreSqlContactsRepository();

        private ContactListViewModel _contactListViewModel = new ContactListViewModel();
        private AddEditContactViewModel _addEditContactViewModel = new AddEditContactViewModel();

        private BindableBase _CurrentViewModel;

        public MainWindowViewModel()
        {
            NavCommand = new RelayCommand<string>(OnNav);
            _contactListViewModel.EditContactRequested += NavToEdit;
            _contactListViewModel.AddContactRequested += NavToAdd;
            _addEditContactViewModel.Done += NavToContactList;
        }

        public BindableBase CurrentViewModel
        {
            get { return _CurrentViewModel; }
            set { SetProperty(ref _CurrentViewModel, value); }
        }

        public RelayCommand<string> NavCommand { get; private set; }
        private void OnNav(string destination)
        {
            switch(destination)
            {
                case "addContact":
                    NavToAdd();
                    break;
                default:
                    CurrentViewModel = _contactListViewModel;
                    break;
            }
        }

        private async void NavToEdit(int contactId)
        {
            _addEditContactViewModel.EditMode = true;
            _addEditContactViewModel.SetContact(await _repo.GetContactDetailsAsync(contactId));
            CurrentViewModel = _addEditContactViewModel;
        }

        private void NavToAdd()
        {
            _addEditContactViewModel.EditMode = false;
            _addEditContactViewModel.SetContact(new ContactDetails());
            CurrentViewModel = _addEditContactViewModel;
        }

        private void NavToContactList()
        {
            CurrentViewModel = _contactListViewModel;
        }
    }
}
