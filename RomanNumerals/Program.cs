using System;

namespace RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;

            //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("de-DE"); //Use this to test different languages.
            
            string introMessage = string.Format(Strings.Strings.FirstMessageToUser, Constants.MinimumValueComputable, Constants.MaximumValueComputable, 0);
            OutputDisplayer.DisplayOutput(introMessage);
            
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
