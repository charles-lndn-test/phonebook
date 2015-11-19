using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.AddEditContact
{
    class SimpleEditableContact: ValidatableBindableBase
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        private string _name;
        [Required]
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private string _surname;
        [Required]
        public string Surname
        {
            get { return _surname; }
            set { SetProperty(ref _surname, value); }
        }

        private string _city;
        [Required]
        public string City
        {
            get { return _city; }
            set { SetProperty(ref _city, value); }
        }

        private string _phoneNUmber;
        [Required]
        public string PhoneNumber
        {
            get { return _phoneNUmber; }
            set { SetProperty(ref _phoneNUmber, value); }
        }
    }
}
