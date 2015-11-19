using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phonebook.Models;
using Phonebook.Services;

namespace Phonebook.AddEditContact
{
    class AddEditContactViewModel: BindableBase
    {
        

        private bool _EditMode;
        public bool EditMode
        {
            get { return _EditMode; }
            set { SetProperty(ref _EditMode, value); }
        }

        private SimpleEditableContact _Contact;
        public SimpleEditableContact Contact
        {
            get { return _Contact; }
            set { SetProperty(ref _Contact, value); }
        }

        private ContactDetails _editingContact = null;

        public AddEditContactViewModel()
        {
            CancelCommand = new RelayCommand(OnCancel);
            SaveCommand = new RelayCommand(OnSave, CanSave);
        }

        public RelayCommand CancelCommand { get; private set; }
        public RelayCommand SaveCommand { get; private set; }

        public event Action Done = delegate { };

        public void SetContact(ContactDetails contactDetails)
        {
            if (Contact != null) Contact.ErrorsChanged -= RaiseCanExecuteChanged;
            _editingContact = contactDetails;
            Contact = new SimpleEditableContact();
            Contact.ErrorsChanged += RaiseCanExecuteChanged;
            CopyContactDetails(_editingContact, Contact);
        }

        private void RaiseCanExecuteChanged(object sender, EventArgs e)
        {
            SaveCommand.RaiseCanExecuteChanged();
        }

        private void CopyContactDetails(ContactDetails source, SimpleEditableContact target)
        {
            if (EditMode)
            {
                target.Id = source.Id;
                target.Name = source.Name;
                target.Surname = source.Surname;
                target.PhoneNumber = source.PhoneNumber;
                target.City = source.City;
            }
        }

        private void OnCancel()
        {
            Done();
        }

        private async void OnSave()
        {
            Done();
        }

        private bool CanSave()
        {
            return !Contact.HasErrors;
        }
        
    }
}
