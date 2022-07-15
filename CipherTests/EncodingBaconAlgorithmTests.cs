using CipherTask;
using System;
using System.Collections.Generic;
using Xunit;

namespace CipherTests
{
    public class EncodingBaconAlgorithmTests
    {
        [Fact]
        public void TurnsMessageIntoBaconCorrectly()
        {
            //Arrange
            string Input = "abcdefghijklmnopqrstuvwxyz .";
            string Expected = "uuuuuuuuuluuuluuuulluuluuuululuulluuullluluuuuluulululuulullulluuullulullluullllluuuuluuulluululuullluluululullullulullllluuulluullllllllllu";

            //Action
            var Actual = EncodingBaconAlgorithm.ToPattern(Input);

            //Assert
            Assert.Equal(Expected, Actual);
        }
        [Fact]
        public void IgnoresCharactersThatAreNotLettersSpacesOrFullStops()
        {
            //Arrange
            string Input = ",:;?(){}!-/[]<>test";
            string Expected = "luulluuluuluululuull";

            //Action
            var Actual = EncodingBaconAlgorithm.ToPattern(Input);

            //Assert
            Assert.Equal(Expected, Actual);
        }

    }
}
