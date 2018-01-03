using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Threading;
using System.Globalization;

namespace RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("de-DE"); //Use this to test different languages.
            OutputDisplayer.DisplayOutput(Strings.Strings.FirstMessageToUser);
            do
            {
                input = Int32.Parse(InputGatherer.GetInputFromUser());

                string romanNumeral = RomanNumeralCalculator.CalculateRomanNumeral(input);

                OutputDisplayer.DisplayOutput(romanNumeral);
                OutputDisplayer.DisplayOutput("");
            }
            while (input != 0);            
        }        
    }
}
