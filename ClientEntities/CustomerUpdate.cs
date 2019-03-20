using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace HandsOnLab1.ClientEntities
{
    public class CustomerUpdate : INotifyPropertyChanged
    {
        public CustomerUpdate(int accountId)
        {
            _accountId = accountId;
        }

        #region Private Fields
        private int _accountId;
        private string _companyName;
        private string _companyPhoneNumber;
        private string _mainContactFirstName;
        private string _mainContactLastName;
        private string _mainContactNumber;
        private string _mainContactRole;
        private string _address1; 
        private string _address2;
        private string _address3;
        private string _address4;
        private string _city;
        private AustralianStates _state = AustralianStates.WestAustralia;
        private string _postCode;
        #endregion

        #region Properties
        public int AccountId
        {
            get { return _accountId; }
        }
        
        public string CompanyName
        {
            get { return _companyName; }
            set
            {
                if (_companyName != value)
                {
                    _companyName = value;
                    OnPropertyChanged("CompanyName");
                }
            }
        }

        public string CompanyPhoneNumber
        {
            get { return _companyPhoneNumber; }
            set
            {
                if (_companyPhoneNumber != value)
                {
                    _companyPhoneNumber = value;
                    OnPropertyChanged("CompanyPhoneNumber");
                }
            }
        }

        public string MainContactFirstName
        {
            get { return _mainContactFirstName; }
            set
            {
                if (_mainContactFirstName != value)
                {
                    _mainContactFirstName = value;
                    OnPropertyChanged("MainContactFirstName");
                }
            }
        }

        public string MainContactLastName
        {
            get { return _mainContactLastName; }
            set
            {
                if (_mainContactLastName != value)
                {
                    _mainContactLastName = value;
                    OnPropertyChanged("MainContactLastName");
                }
            }
        }

        public string MainContactNumber
        {
            get { return _mainContactNumber; }
            set
            {
                if (_mainContactNumber != value)
                {
                    _mainContactNumber = value;
                    OnPropertyChanged("MainContactNumber");
                }
            }
        }
        
        public string MainContactRole
        {
            get { return _mainContactRole; }
            set
            {
                if (_mainContactRole != value)
                {
                    _mainContactRole = value;
                    OnPropertyChanged("MainContactRole");
                }
            }
        }

        public string Address1
        {
            get { return _address1; }
            set
            {
                if (_address1 != value)
                {
                    _address1 = value;
                    OnPropertyChanged("Address1");
                }
            }
        }

        public string Address2
        {
            get { return _address2; }
            set
            {
                if (_address2 != value)
                {
                    _address2 = value;
                    OnPropertyChanged("Address2");
                }
            }
        }

        public string Address3
        {
            get { return _address3; }
            set
            {
                if (_address3 != value)
                {
                    _address3 = value;
                    OnPropertyChanged("Address3");
                }
            }
        }

        public string Address4
        {
            get { return _address4; }
            set
            {
                if (_address4 != value)
                {
                    _address4 = value;
                    OnPropertyChanged("Address4");
                }
            }
        }

        public string City
        {
            get { return _city; }
            set
            {
                if (_city != value)
                {
                    _city = value;
                    OnPropertyChanged("City");
                }
            }
        }

        public AustralianStates State
        {
            get { return _state; }
            set
            {
                if (_state != value)
                {
                    _state = value;
                    OnPropertyChanged("State");
                }
            }
        }

        public string PostCode
        {
            get { return _postCode; }
            set
            {
                if (_postCode != value)
                {
                    _postCode = value;
                    OnPropertyChanged("PostCode");
                }
            }
        }
        #endregion

        #region INotifyPropertyChanged Members
        /// <summary>
        /// Implicit implementation of the INotifyPropertyChanged.PropertyChanged event.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Throws the <c>PropertyChanged</c> event.
        /// </summary>
        /// <param name="propertyName">The name of the property that was modified.</param>
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
