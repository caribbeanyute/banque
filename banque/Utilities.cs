using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace banque
{

    public static class Utilities
    {
        public static bool ValidateDecimalString(string input)
        {
            Regex regex = new Regex(@"^\d+\.\d{2}$");
            return regex.IsMatch(input);
        }

  
    }
}
