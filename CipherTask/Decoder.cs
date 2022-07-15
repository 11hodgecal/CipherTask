using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherTask
{
    //Responsible for decoding a Phrase
    public static class Decoder
    {
        public static void Decode(string mephod)
        {
            //Needs to receive an input to decode
            string Phrase = PhraseForm.GetPhrase(PhraseForm.WhichMephod(mephod));

            //The message needs to be converted Into bacon patterns
            string ConvertedPhrase = DecoderPhraseBaconConvert.Convert(Phrase);

            //Find Patterns in the phrase
            var PhrasePatterns = DecodingBaconAlgorithm.GetBaconPatterns(ConvertedPhrase);
        }
    }
}
