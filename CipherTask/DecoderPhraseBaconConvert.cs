using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherTask
{
    //Responsible for converting a given phrase into bacon patterns.
    public static class DecoderPhraseBaconConvert
    {
        //cleans the phrase by removing spaces and punctuation.
        public static string PhraseClean(string phrase)
        {
            phrase = phrase.Replace(" ", "");
            phrase = phrase.Replace("  ", "");
            phrase = phrase.Replace(",", "");
            phrase = phrase.Replace(".", "");
            phrase = phrase.Replace(":", "");
            phrase = phrase.Replace(";", "");
            phrase = phrase.Replace("?", "");
            phrase = phrase.Replace("(", "");
            phrase = phrase.Replace(")", "");
            phrase = phrase.Replace("{", "");
            phrase = phrase.Replace("}", "");
            phrase = phrase.Replace("...", "");
            phrase = phrase.Replace("!", "");
            phrase = phrase.Replace("-", "");
            phrase = phrase.Replace("/", "");
            phrase = phrase.Replace("[", "");
            phrase = phrase.Replace("]", "");
            phrase = phrase.Replace("<", "");
            phrase = phrase.Replace(">", "");
            return phrase;
        }

        //This function will convert a phrase to bacon format.
        public static string Convert(string phrase)
        {
            phrase = PhraseClean(phrase);
            
            //Bacon phrase to be populated.
            string ConvertedPhrase = "";
            //The phrase converted to a char array.
            var PhraseCharList = phrase.ToCharArray();


            //Loops through the characters
            foreach (char ch in PhraseCharList)
            {
                //if the character is a upper case mark it as L.
                if (char.IsLower(ch))
                {
                    ConvertedPhrase += "l";
                }

                //if the character is a lower case mark it as u.
                if (char.IsUpper(ch))
                {
                    ConvertedPhrase += "u";
                }
            }
            //return the converted list.
            return ConvertedPhrase;
        }
    }
}
