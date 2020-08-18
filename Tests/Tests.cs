using System;
using Xunit;

namespace Tests
{
    public class MiscLibTests
    {
        // Write Unit Tests for all functions for your assigned group

        // GROUP 1


        //Instantiating Group1 object
         GroupOneFunctions g1 = new GroupOneFunctions();

        //1.  Method receives the two sides of a Rectangle and return the area

        [Theory]
        [InlineData(6,2,3)]
        [InlineData(15,3,5)]
        [InlineData(20,7,3)]


        public void CalcRectArea_Test(int expected, int length, int width)
        {
            Assert.Equal(expected, g1.CalcRectArea(length,width));
        }
        

        //2.  Checks if a number is a factorial

        [Theory]
        [InlineData(true,6)]
        [InlineData(false,4)]

        public void IsFactiorialNum_Test(bool expected, int num)
        {
            int Output = g1.IsFactiorialNum(num);
            Assert.Equal(expected, Output);
        }



        //3.  Coverts a temperature from Celcius to Farenheit, rounded up to the nearest whole number

        [Theory]
        [InlineData(0,32)]
        [InlineData(10,50)]

        public void CelciusToFarenheit_Test(int Farenheit, int Celsius)
        {
            int Output = g1.CelciusToFarenheit(Celsius);
            Assert.Equal(Farenheit, Output);
        }


        //4.  Checks a string and returns true if it is palindromic

        [Theory]
        [InlineData(true,"Anna")]
        [InlineData(false,"rob")]

        public void IsPalindrome_Test(bool expected, string word)
        {
            Assert.Equal(expected, g1.IsPalindrome(word));
        }


        //5.  Replaces a character when found in a string

        [Theory]
        [InlineData("Love Programming" , "Live Prigramming" , "i" , "o")]
        [InlineData("cat" , "cot" , "o" , "a")]

        public void StringReplace_Test(string expected, string word, char value1, char value2)
        {
            Assert.Equal(expected, g1.StringReplace(word,value1,value2));
        }


        //6.  Counts the number of times a character occurs in a string

        [Theory]
        [InlineData(2,"o","Book")]

        public void CharCount_Test(int expected, string word, char countCharacter)
        {
            Assert.Equal(expected, g1.CharCount(word,countCharacter));
        }
        

    }
}
