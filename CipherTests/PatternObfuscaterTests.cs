using CipherTask;
using System;
using System.Collections.Generic;
using Xunit;

namespace CipherTests
{
    public class PatternObfuscaterTests
    {
        [Fact]
        public void ObfuscationStringIncludesLettersThatAreNotLorS()
        {
            //Arrange
            //Test repeated in bacon pattern
            string Input = "luulluuluuluululuullluulluuluuluululuullluulluuluuluululuullluulluuluuluululuullluulluuluuluululuullluulluuluuluululuullluulluuluuluululuull";

            //Action
            var Result = PatternObfuscater.ToMeaninglessPhrase(Input).ToCharArray();
            Boolean AreOtherLetters = false;

            foreach (var c in Result)
            {
                if (c.ToString() != "l" && c.ToString() != "l")
                {
                    AreOtherLetters = true;
                }    
            }

            //Assert
            Assert.True(AreOtherLetters);
        }
        [Fact]
        public void ObfuscationStringIncludesCapitals()
        {
            //Arrange
            //Test repeated in bacon patterns
            string Input = "luulluuluuluululuullluulluuluuluululuullluulluuluuluululuullluulluuluuluululuullluulluuluuluululuullluulluuluuluululuullluulluuluuluululuull";

            //Action
            var Result = PatternObfuscater.ToMeaninglessPhrase(Input).ToCharArray();
            Boolean AreCapitals = false;

            foreach (var c in Result)
            {
                if (char.IsUpper(c))
                {
                    AreCapitals = true;
                }
            }

            //Assert
            Assert.True(AreCapitals);
        }
        [Fact]
        public void ObfuscationStringIncludesLowerCaseLetters()
        {
            //Arrange
            //Test repeated in bacon patterns
            string Input = "luulluuluuluululuullluulluuluuluululuullluulluuluuluululuullluulluuluuluululuullluulluuluuluululuullluulluuluuluululuullluulluuluuluululuull";

            //Action
            var Result = PatternObfuscater.ToMeaninglessPhrase(Input).ToCharArray();
            Boolean AreLowers = false;

            foreach (var c in Result)
            {
                if (char.IsLower(c))
                {
                    AreLowers = true;
                }
            }

            //Assert
            Assert.True(AreLowers);
        }
        [Fact]
        public void ObfuscationStringIncludesCommas()
        {
            //Arrange
            //Test repeated in bacon pattern
            string Input = "luulluuluuluululuullluulluuluuluululuullluulluuluuluululuullluulluuluuluululuullluulluuluuluululuullluulluuluuluululuullluulluuluuluululuull";

            //Action
            var Result = PatternObfuscater.ToMeaninglessPhrase(Input).ToCharArray();
            Boolean AreCommas = false;

            foreach (var c in Result)
            {
                if (c.ToString() == ",")
                {
                    AreCommas = true;
                }
            }

            //Assert
            Assert.True(AreCommas);
        }
        [Fact]
        public void ObfuscationStringIncludesSpaces()
        {
            //Arrange
            //Test repeated in bacon pattern
            string Input = "luulluuluuluululuullluulluuluuluululuullluulluuluuluululuullluulluuluuluululuullluulluuluuluululuullluulluuluuluululuullluulluuluuluululuull";

            //Action
            var Result = PatternObfuscater.ToMeaninglessPhrase(Input).ToCharArray();
            Boolean AreSpaces = false;

            foreach (var c in Result)
            {
                if (c.ToString() == " ")
                {
                    AreSpaces = true;
                }
            }

            //Assert
            Assert.True(AreSpaces);
        }
        [Fact]
        public void ObfuscationStringIncludesFullStops()
        {
            //Arrange
            //Test repeated in bacon pattern
            string Input = "luulluuluuluululuullluulluuluuluululuullluulluuluuluululuullluulluuluuluululuullluulluuluuluululuullluulluuluuluululuullluulluuluuluululuull";

            //Action
            var Result = PatternObfuscater.ToMeaninglessPhrase(Input).ToCharArray();
            Boolean AreStops = false;

            foreach (var c in Result)
            {
                if (c.ToString() == " ")
                {
                    AreStops = true;
                }
            }

            //Assert
            Assert.True(AreStops);
        }
    }
}
