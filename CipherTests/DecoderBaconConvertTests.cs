using CipherTask;
using System;
using Xunit;

namespace CipherTests
{
    public class DecoderBaconConvertTests
    {
        [Fact]
        public void ConverterWorks()
        {
            //Arrange
            string Input = "tests";
            string Expected = "lllll";

            //Action
            string Actual = DecoderPhraseBaconConvert.Convert(Input);

            //Assert
            Assert.Equal(Expected, Actual);
        }
        [Fact]
        public void ConverterReturnsLForCapitalLetters()
        {
            //Arrange
            string Input = "S";
            string Expected = "u";

            //Action
            string Actual = DecoderPhraseBaconConvert.Convert(Input);

            //Assert
            Assert.Equal(Expected, Actual);
        }
        [Fact]
        public void ConverterReturnsUForLowercaseLetters()
        {
            //Arrange
            string Input = "s";
            string Expected = "l";

            //Action
            string Actual = DecoderPhraseBaconConvert.Convert(Input);

            //Assert
            Assert.Equal(Expected, Actual);
        }

        [Fact]
        public void PhraseCleanRemovesPunctuation()
        {
            //Arrange
            string Input = ",.:;?(){}...!-/[]<>test";
            string Expected = "test";

            //Action
            string Actual = DecoderPhraseBaconConvert.PhraseClean(Input);

            //Assert
            Assert.Equal(Expected, Actual);
        }

        [Fact]
        public void PhraseCleanRemovesSpaces()
        {
            //Arrange
            string Input = "te st";
            string Expected = "test";

            //Action
            string Actual = DecoderPhraseBaconConvert.PhraseClean(Input);

            //Assert
            Assert.Equal(Expected, Actual);
        }

    }
}
