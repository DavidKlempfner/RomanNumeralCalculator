using System.Collections;
using System.Collections.Specialized;
using System.Linq;

namespace RomanNumerals
{
    public static class OrderedDictionaryExtensions
    {
        public static int IndexOfValue(this OrderedDictionary dictionary, object value)
        {
            for (int i = 0; i < dictionary.Count; ++i)
            {
                if (dictionary[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }

        public static bool ContainsValue(this OrderedDictionary dictionary, object value)
        {
            for (int i = 0; i < dictionary.Count; ++i)
            {
                if (dictionary[i].Equals(value))
                {
                    return true;
                }
            }
            return false;
        }

        public static object GetKeyFromFirstElementWithValue(this OrderedDictionary dictionary, object value)
        {
            for (int i = 0; i < dictionary.Count; ++i)
            {
                if (dictionary[i].Equals(value))
                {
                    return dictionary.Cast<DictionaryEntry>().ElementAt(i).Key;
                }
            }
            return null;
        }
    }
}
