using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public static class InputValidator
    {
        private const int MinimumValueComputable = 1;
        private const int MaximumValueComputable = 1000000;

        public static bool IsInputValid(int currentInput)
        {
            return currentInput >= MinimumValueComputable && currentInput <= MaximumValueComputable;
        }        
    }
}
