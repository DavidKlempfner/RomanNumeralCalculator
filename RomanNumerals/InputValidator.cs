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
