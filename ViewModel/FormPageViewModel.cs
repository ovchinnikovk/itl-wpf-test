using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace itl_wpf_test.ViewModel
{
    static class FormPageViewModel
    {
        private static bool _canGo = false;
        public static void IsValidMail(string mail)
        {
            if (string.IsNullOrWhiteSpace(mail)) _canGo = false;
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            _canGo = Regex.IsMatch(mail, pattern, RegexOptions.IgnoreCase);
        }
         
        public static void IsValidNumber(string number)
        {
            Regex regexTelephone = new Regex(@"^[+]{0,1}[0-9]{11}");
            _canGo = regexTelephone.IsMatch(number);
        }

        public static void IsValidFullname(string fullname)
        {
            _canGo = fullname.Split(',').Length == 3;
        }

        public static bool CanGo() => _canGo;
    }
}
