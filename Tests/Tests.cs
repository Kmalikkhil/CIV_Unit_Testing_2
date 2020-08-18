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
    }
}
