using System;

namespace CipherTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Choose between encoding or decoding.
            Console.WriteLine("Type 1 and enter to encode a phrase");
            Console.WriteLine("Type 2 and enter to decode the phrase");

            //Program asks the user what they want to do.
            string UserInput = Console.ReadLine();

            //User chooses to encode.
            if (UserInput == "1")
            {
                Encoder.Encode(UserInput);
            }

            //User choses to decode.
            if (UserInput == "2")
            {
                Decoder.Decode(UserInput);
            }        
        }
    }
}
