using itl_wpf_test.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace itl_wpf_test.Models
{
    class User : NotifyPropertyChanged
    {
        private string _fullname;
        private string _tnumber;
        private string _email;

        public string Fullname
        {
            get { return _fullname; }
            set
            {
                _fullname = value;
                OnPropertyChanged("Fullname");
            }
        }

        public string Tnumber
        {
            get { return _tnumber; }
            set
            {
                _tnumber = value;
                OnPropertyChanged("Tnumber");
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged("Email");
            }
        }
    }
}
