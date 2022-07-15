using CipherTask;
using System;
using System.Collections.Generic;
using Xunit;

namespace CipherTests
{
    public class DecodingBaconAlgorithmTests
    {
        [Fact]
        public void DecodedMessageIsCorrect()
        {
            //Arrange
            string Expected = "abcdefghijklmnopqrstuvwxyz .";
            string Input = "uuuuuuuuuluuuluuuulluuluuuululuulluuullluluuuuluulululuulullulluuullulullluullllluuuuluuulluululuullluluululullullulullllluuulluullllllllllu";

            //Action
            var Actual = DecodingBaconAlgorithm.RetrieveDecodedMessage(DecodingBaconAlgorithm.GetBaconPatterns(Input));

            //Assert
            Assert.Equal(Expected, Actual);
        }
    }

}
