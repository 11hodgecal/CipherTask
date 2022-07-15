using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherTask
{
    public static class PatternObfuscater
    {
        //Variables for randomly generating letters
        private static Char[] Lowerletters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        private static Char[] CapLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private static Random Random = new Random();


        private static string ToLowerCapObfuscationString(string Pattern)
        {
            var CharPatternArray = Pattern.ToCharArray();

            string LowerCapObfuscationString = "";

            foreach (char c in CharPatternArray)
            {
                if ("u".Contains(c))
                {
                    LowerCapObfuscationString += CapLetters[Random.Next(0, 26)];
                }
                if ("l".Contains(c))
                {
                    LowerCapObfuscationString += Lowerletters[Random.Next(0, 26)];
                }   
            }
            return LowerCapObfuscationString;
        }
        
        private static string ToSpacesAPunctuationIncludedString(string LowerCapObfuscationString)
        {
            int PunctuationRoll = 0;
            int CurrentIndex = 0;
            int NextSpace = Random.Next(1, 9);
            var ObfuscationStringArray = LowerCapObfuscationString.ToCharArray().ToList();
            string ObfuscationString = "";

            foreach (char c in ObfuscationStringArray)
            {
                try
                {
                    if (CurrentIndex == NextSpace)
                    {
                        PunctuationRoll = Random.Next(21);
                        if (PunctuationRoll < 16)
                        {
                            ObfuscationString += " ";
                        }
                        if(PunctuationRoll > 17 && PunctuationRoll <= 18)
                        {
                            ObfuscationString += ", ";
                        }
                        if (PunctuationRoll == 20 )
                        {
                            ObfuscationString += ". ";
                        }
                        NextSpace = CurrentIndex + Random.Next(1, 9);
                    }
                    ObfuscationString += c;
                    CurrentIndex++;
                }
                catch
                {
                    //do nothing
                }
            }

            return ObfuscationString + ".";
        }

        public static string ToMeaninglessPhrase(string Pattern)
        {
            string ObfuscationString = ToLowerCapObfuscationString(Pattern);
            ObfuscationString = ToSpacesAPunctuationIncludedString(ObfuscationString);
            return ObfuscationString;
        }
    }
}
