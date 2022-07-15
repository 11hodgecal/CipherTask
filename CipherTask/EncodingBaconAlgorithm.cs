using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherTask
{
    //This class is responsible for the encoding messages into bacon patterns.
    public static class EncodingBaconAlgorithm
    {
        //The encoding dictionary showing the different values of letters as bacon patterns.
        private static Dictionary<string, string> LetterValuesInBacon = new Dictionary<string, string>()
        {
            {"a","uuuuu"},
            {"b","uuuul"},
            {"c","uuulu"},
            {"d","uuull"},
            {"e","uuluu"},
            {"f","uulul"},
            {"g","uullu"},
            {"h","uulll"},
            {"i","uluuu"},
            {"j","uluul"},
            {"k","ululu"},
            {"l","ulull"},
            {"m","ulluu"},
            {"n","ullul"},
            {"o","ulllu"},
            {"p","ullll"},
            {"q","luuuu"},
            {"r","luuul"},
            {"s","luulu"},
            {"t","luull"},
            {"u","luluu"},
            {"v","lulul"},
            {"w","lullu"},
            {"x","lulll"},
            {"y","lluuu"},
            {"z","lluul"},
            {" ","lllll"},
            {".","llllu"},
        };
        //Turns a provided Phrase into a Bacon Pattern
        public static string ToPattern(string phrase)
        {
            //The Phrase is turned into a char array
            var CharlistPhrase = phrase.ToCharArray();
            string MessageInPattern = "";

            //For each character in the phrase turn it into it corresponding pattern if it is a character not in the dictionary leave it out.
            foreach (char c in CharlistPhrase)
            {
                try
                {
                    MessageInPattern += LetterValuesInBacon[c.ToString()];
                }
                catch
                {
                    //do nothing.
                }
                
            }

            //Returns the Converted Message
            return MessageInPattern;
        }
    }
}
