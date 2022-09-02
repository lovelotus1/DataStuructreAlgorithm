using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex
{
    public class Patterns
    {
        public static string Regex_Patterns = "^[0-9]{1}$";
        public bool validatePinCode(string pincode)
        {
            return Regex.IsMatch(pincode, Regex_Patterns);
        }
    }
}