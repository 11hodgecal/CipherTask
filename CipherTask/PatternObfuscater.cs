using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherTask
{
    //Responible for changing the pattern into unrecognizable and confusing text.
    public static class PatternObfuscater
    {
        //Variables for randomly generating letters.
        private static Char[] Lowerletters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        private static Char[] CapLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private static Random Random = new Random();

        //Changes the l's to a random lowercase letter and the u's to uppercase letters.
        private static string ToLowerCapObfuscationString(string Pattern)
        {
            //the pattern broken down into a character array.
            var CharPatternArray = Pattern.ToCharArray();
            //string which the new obfuscation string will be stored in.
            string LowerCapObfuscationString = "";

            //Each character will be checked if its a uppercase or a lowercase letter then will have a appropriate letter of appropriate case generated for it.
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
            //returns the obfuscation string.
            return LowerCapObfuscationString;
        }

        //Adds spaces and punctuation to the Obfuscation String
        private static string ToSpacesAPunctuationIncludedString(string LowerCapObfuscationString)
        {
            //This int will be randomly rolled to see if the space will include a comma or a full stop
            int PunctuationRoll = 0;
            //Tracks the current index in the for loop.
            int CurrentIndex = 0;
            //Tracks when the next space will be added.
            int NextSpace = Random.Next(1, 9);
            //The Lower Cap ObfuscationString in a char array to loop throgh.
            var ObfuscationStringArray = LowerCapObfuscationString.ToCharArray().ToList();
            //The Obfuscation string that will be populated in the for loop
            string ObfuscationString = "";

            foreach (char c in ObfuscationStringArray)
            {
                try
                {
                    //If the current index is when the next space should be added .
                    //add the space and roll whether it will also be populated by a comma or a full stop.
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
                        //roll where the next space will be.
                        NextSpace = CurrentIndex + Random.Next(1, 9);
                    }
                    //Add the current character.
                    ObfuscationString += c;

                    //Add one to the current index to move on to the next character in the string.
                    CurrentIndex++;
                }
                //Avoids out of range of the array errors
                catch
                {
                    //do nothing.
                }
            }

            //Add the generated string with a full stop at the end
            return ObfuscationString + ".";
        }

        //This function will generate the obfucation string.
        public static string ToMeaninglessPhrase(string Pattern)
        {
            string ObfuscationString = ToLowerCapObfuscationString(Pattern);
            ObfuscationString = ToSpacesAPunctuationIncludedString(ObfuscationString);
            return ObfuscationString;
        }
    }
}
