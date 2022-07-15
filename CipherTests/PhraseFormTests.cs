using CipherTask;
using System;
using Xunit;

namespace CipherTests
{
    public class PhraseFormTests
    {
        [Fact]
        public void WhichMephodChoiceOneReturnsEncode()
        {
            //Arrange
            string Expected = "encode";

            //Action
            string Actual = PhraseForm.WhichMephod("1");

            //Assert
            Assert.Equal(Expected, Actual);
        }
        [Fact]
        public void WhichMephodChoiceTwoReturnsDecode()
        {
            //Arrange
            string Expected = "decode";

            //Action
            string Actual = PhraseForm.WhichMephod("2");

            //Assert
            Assert.Equal(Expected, Actual);
        }
        [Fact]
        public void WhichMephodUnknownValueIsNull()
        {
            //Arrange
            string Input = "should be null";

            //Action
            string Action = PhraseForm.WhichMephod(Input);

            //Assert
            Assert.Null(Action);
        }
    }
    

}
