using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace firstForm.Validation //защо се записва по този начин
{
    internal  static class Validator 
    {
         public static bool checkName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Липсва име. ");
                return false;
            }

            string search = @"0123456789.,:/\=*+@!?$#()";
            bool isValide = name.Any(a => search.Contains(a)) && !string.IsNullOrWhiteSpace(name);
            if (isValide == true)
            {
                MessageBox.Show($"Името съдържа невалиден симво!\n({search})"); return false;
            }
            return true;
        }
        public static bool checkPhoneNumber(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Липсва телефонен номер.");
                return false;
            }

            bool isValide = phone.All(char.IsDigit);
            if (!isValide)
            {
                MessageBox.Show($"Телефонният номер съдържа невалидни символи!");
                return false;
            }
            return true;
        }
        public static bool checkEmail(string mail)
        {
            if (string.IsNullOrWhiteSpace(mail))
            {
                MessageBox.Show("Липсва имейл.");
                return false;
            }
            string forbidden = ",/\\{}[]:;'\"!#$% *+?";
            if (mail.Any(c => forbidden.Contains(c)))
            {
                MessageBox.Show("Невалиден имейл.");    
                return false;
            }

            if (mail.Count(c => c == '@') != 1) {
                MessageBox.Show("Невалиден имейл."); 
                return false;
            }

            if (mail[mail.Length - 1] == '.') { 
                MessageBox.Show("Невалиден имейл.");
                return false;
            }

            int atIndex = mail.IndexOf('@'); //продължи с проверката след @
            string domain = mail.Substring(mail.IndexOf('@') + 1);
            if(!domain.Contains(".") )
            {
                MessageBox.Show("Невалиден имейл - домейн.1");
                return false;
            }
            if ( domain.Any(a=>("/\\123456789*+").Contains(a))) 
            {
                MessageBox.Show("Невалиден имейл - домейн.2");
                return false;
            }

            return true;
        }
        public static bool checkFill(string text, string box)
        {
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show($"Не е попълнено поле \"{box}\"."); 
                return false; 
            }
            return true; 
        }
        public static bool isDigit(string num)
        {
            if (string.IsNullOrWhiteSpace(num))
            {
                MessageBox.Show("Процентът е задължителен.");
                return false;
            }

            if  (!num.All(char.IsDigit))
            {
                MessageBox.Show("Невалиден фомат на процент.");
                return false; 
            }

            int.TryParse(num, out int number);
            if (number < 1 || number > 100)
            {
                MessageBox.Show("Процентът е извън рамките. \n(1<= <= 100)");
                return false; 
            }

            return true; 

        }
    }
}
