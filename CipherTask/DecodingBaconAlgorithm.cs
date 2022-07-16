using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherTask
{
    //This class is responsible for the Decoding messages using the bacon cipher.
    public static class DecodingBaconAlgorithm
    {
        //The decoding dictionary showing the different values of bacon patterns as a letters.
        private static Dictionary<string, string> BaconPatternValues = new Dictionary<string, string>()
        {
            {"uuuuu","a"},
            {"uuuul","b"},
            {"uuulu","c"},
            {"uuull","d"},
            {"uuluu","e"},
            {"uulul","f"},
            {"uullu","g"},
            {"uulll","h"},
            {"uluuu","i"},
            {"uluul","j"},
            {"ululu","k"},
            {"ulull","l"},
            {"ulluu","m"},
            {"ullul","n"},
            {"ulllu","o"},
            {"ullll","p"},
            {"luuuu","q"},
            {"luuul","r"},
            {"luulu","s"},
            {"luull","t"},
            {"luluu","u"},
            {"lulul","v"},
            {"lullu","w"},
            {"lulll","x"},
            {"lluuu","y"},
            {"lluul","z"},
            {"lllll"," "},
            {"llllu","."},
        };

        //Finds patterns in a particular Phrase in bacon format.
        public static List<string> GetBaconPatterns(string convertedPhrase)
        {
            //The index which the splicing will happen.
            int Beginning = 0;
            //The number of chars that will make up a pattern.
            int numberofChars = 5;
            //Gets the amount of characters in the Phrase and divide it by five to get the number of patterns.
            int NumOfPatterns = convertedPhrase.Length / 5;
            //creates a new list for the patterns.
            List<string> patterns = new List<string>();

            //For each pattern add to the pattern list and add 5 to the beginning variable so the for loop can move onto the next pattern.
            for(int PatternNum = 0; PatternNum < NumOfPatterns; PatternNum++)
            {
                string Pattern = convertedPhrase.Substring(Beginning, numberofChars);
                patterns.Add(Pattern);
                Beginning = Beginning + 5;
            }

            return patterns;
        }
        //Decodes a list of bacon patterns into a message.
        public static string RetrieveDecodedMessage(List<string> BaconPatterns)
        {
            //bool to check if the message is all empty.
            string message = "";

            //The decoded letter will be added onto the message.
            foreach(string Pattern in BaconPatterns)
            {
                message += DecodeLetter(Pattern);
            }

            //checks the message is not empty.
            PhraseEmptyCheck.Check(message.ToCharArray());

            return message;
        }

        //Matches the pattern to a letter then returns the decoded letter.
        private static string DecodeLetter(string BaconPattern)
        {
            var decodedletter = "";
            //The function will try to decode the pattern and if it is not recognisable it will task the user to the error menu with a appropriate message.
            try
            {
                decodedletter = BaconPatternValues[BaconPattern];
            }
            catch
            {
                Menu.Error("Could not decode your message there was a unknown character");
            }

            return decodedletter;
        }
    }
}
