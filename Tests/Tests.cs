using System;
using Xunit;

namespace Tests
{
    public class MiscLibTests
    {
        // Write Unit Tests for all functions for your assigned group

        // GROUP 1


        //Instantiating Group1 object
         GroupOneFunctions grp1 = new GroupOneFunctions();

        //1.  Method receives the two sides of a Rectangle and return the area

        [Theory]
        [InlineData(6,2,3)]
        [InlineData(15,3,5)]
        [InlineData(20,7,3)]


        public void CalcRectArea_Test(int expected, int length, int width)
        {
            Assert.Equal(expected, grp1.CalcRectArea(length,width));
        }
        
    }
}
