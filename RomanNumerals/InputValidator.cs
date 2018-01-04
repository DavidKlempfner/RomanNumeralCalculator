using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public static class InputValidator
    {        
        public static bool IsInputValid(int currentInput)
        {
            return currentInput >= Constants.MinimumValueComputable && currentInput <= Constants.MaximumValueComputable;
        }        
    }
}
