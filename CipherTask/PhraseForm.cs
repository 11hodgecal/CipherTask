using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherTask
{
    //This class is responsible for retriving a phrase to be decoded or encoded 
    public static class PhraseForm
    {
        //return a string depending if the person has selected encoding or decoding.
        public static string WhichMephod(string choice)
        {
            //if the string is "1" the mephod is encode.
            if (choice == "1")
            {
                return "encode";
            }

            //if the string is "2" the mephod is decode.
            if (choice == "2")
            {
                return "decode";
            }

            //Returns null if it does not equal either.
            return null;
        }

        //A phrase will be retrived to be encoded or decoded.
        public static string GetPhrase(string mephod)
        {
            Console.Clear();
            //Tells the user to enter a phrase and the mephod that they have chosen.
            Console.WriteLine("What phrase do you want to {0}", mephod);
            if (mephod == "encode")
            {
                Console.WriteLine("Note: Any punctuation apart from full stops will be ignored and will not appear when decoded.");
            }
            string Phrase = Console.ReadLine();
            return Phrase;
        }
    }
}
