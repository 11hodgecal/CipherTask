using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherTask
{
    //Reponsible for Informing the user on the results there actions or the actions they will take. 
    public static class Menu
    {
        //Shows the possible functions of the software
        public static void Init()
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
        //Depending on the mephod used a different message will be shown with the results of that mephod along with choices on what they can do next
        public static void ShowResults(string mephodused, string Userinput, string Result)
        {
            Console.Clear();

            if (mephodused == "1")
            {
                Console.WriteLine("Your message has been encoded correctly");
                Console.WriteLine("Your unencoded message was:");
                Console.WriteLine(Userinput);
                Console.WriteLine();
                Console.WriteLine("Here is your encoded message:");
                Console.WriteLine(Result);
                Console.WriteLine();
                Init();
                
            }
            if (mephodused == "2")
            {
                Console.WriteLine("Your message has been encoded correctly");
                Console.WriteLine("Your encoded message was:");
                Console.WriteLine(Userinput);
                Console.WriteLine();
                Console.WriteLine("Here is your Decoded message:");
                Console.WriteLine(Result);
                Console.WriteLine();
                Init();
            }
        }

        //This function will show a error message depending on the message provided and the function selection will also appear
        public static void Error(string message)
        {
            Console.Clear();
            Console.WriteLine("Task Failed!!!!");
            Console.WriteLine(message);
            Console.WriteLine();
            Init();
        }
    }
}
