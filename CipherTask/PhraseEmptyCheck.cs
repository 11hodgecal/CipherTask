using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherTask
{
    //Responsible for checking if the inputted phrase is empty
    public static class PhraseEmptyCheck
    {
        public static void Check(char[] PhraseCharArr)
        {
            Boolean AllEmpty = true;

            foreach (char ch in PhraseCharArr)
            {
                if (ch.ToString() != " ")
                {
                    AllEmpty = false;
                }
            }

            if (AllEmpty == true)
            {
                Menu.Error("Encoded/Decoded Message only contains spaces");
            }
        }
    }
}
