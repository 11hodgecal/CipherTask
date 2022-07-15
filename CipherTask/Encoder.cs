﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherTask
{
    //Responsible for encoding a phrase
    public class Encoder
    {
        public static void Encode(string mephod)
        {
            //Needs to receive an input to encode and change it to lowercase just in case the user cannot put in a capital and not break the program
            string Phrase = PhraseForm.GetPhrase(PhraseForm.WhichMephod(mephod)).ToLower();

            //Convert the text into bacon patterns
            string PhraseInBacon = EncodingBaconAlgorithm.ToPattern(Phrase);

            //Encoded into a message that cannot be understood or has a obvious pattern
            string MeaninglessPhrase = PatternObfuscater.ToMeaninglessPhrase(PhraseInBacon);
        }
    }
}
