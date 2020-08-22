using System;
using Xunit;
using MiscLib;

namespace Tests
{
    public class MiscLibTests
    {   
        
        // Write Unit Tests for all functions for your assigned group


        /*-----------------------------------------------------------------------------
        GROUP 1
        -----------------------------------------------------------------------------*/
        
        /*
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

        public void StringReplace_Test(string expected, string word, char replaceChar, char replacement)
        {
            Assert.Equal(expected, g1.StringReplace(word,replaceChar,replacement));
        }


        //6.  Counts the number of times a character occurs in a string

        [Theory]
        [InlineData(2,"Book","o")]

        public void CharCount_Test(int expected, string word, char countCharacter)
        {
            Assert.Equal(expected, g1.CharCount(word,countCharacter));
        }
        
        */
           
           
        /*-----------------------------------------------------------------------------
        GROUP 2
        -----------------------------------------------------------------------------*/
    
        
        GroupTwoFunctions msclib = new GroupTwoFunctions();

        [Theory]
        [InlineData(40, 10, 10)]
        [InlineData(1158, 234, 345)]
        [InlineData(69114, 12, 34545)]
        public void CalcRectPerimeter_Test(int expected, int input_one, int input_two)
        {
            
            var result = msclib.CalcRectPerimeter(input_one, input_two);
            Assert.Equal(expected, result);
        }    
        
        [Theory]
        [InlineData(true, 21)]
        [InlineData(true, 66)]
        [InlineData(false, 23)]
        [InlineData(false, 665)] 
        public void IsTriangularNum_Test(bool expected, int input)
        {
            
            var result = msclib.IsTriangularNum(input);
            Assert.Equal(expected, result);
        }  
        
        [Theory]
        [InlineData(32, 0)]
        [InlineData(780, 415.556)]
        [InlineData(-22, -30)]
        [InlineData(-103, -75)]
        public void FarenheitToCelcius_Test(int expected, int Finput)
        {
            
            var result = msclib.FarenheitToCelcius(Finput);
            Assert.Equal(expected, result);
        }  
        
        [Theory]
        [InlineData(true, " sdfh")]
        [InlineData(false, "Moated")]
        [InlineData(true, "Triangles ")]
        [InlineData(false, "Motorboated")]  
        public void CheckWhiteSpace_Test(bool expected, string userInput)
        {
            
            var result = msclib.CheckWhiteSpace(userInput);
            Assert.Equal(expected, result);
        }    

        
        [Theory]
        [InlineData("ThIs", "ThIs")]
        [InlineData("SoMeTiMe", "SoMeTiMe")]
        [InlineData("SoMeThIhNg", "somethihng")]
        [InlineData("UnSeTsTaDnIgN", "unserstadnign")]
        public void CamelString_Test(string expected, string userInput)
        {
            
            var result = msclib.CamelString(userInput);
            Assert.Equal(expected, result);
        }    
        
        [Theory]
        [InlineData(4, "1123")]
        [InlineData(10, "2398473456")]
        [InlineData(11, "23984734563")]
        [InlineData(6, "123456")]
        public void CountDigits(int expected, string input)
        {
            
            var result = msclib.CountDigits(input);
            Assert.Equal(expected, result);
        }     
        
        
    }
}
