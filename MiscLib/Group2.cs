using System;

namespace MiscLib
{
    public class GroupTwoFunctions
    {
        //---- Group 2 Functions ----------
        public int CalcRectPerimeter(int length, int width) {
            return (length + width) * 2;
        }

        public bool IsTriangularNum(int num) {
            
            long calc_num = 8*num+1;
            long t = (long) Math.Sqrt(calc_num);
            
            if (t*t==calc_num) {
                return true;
            }
                return false;
        }

        public int FarenheitToCelcius(int farenheit) {
            
            int celsius = (farenheit - 32) * 5 / 9;
            return celsius;
        }

        public bool CheckWhiteSpace(string word) {
            int numberOfSpaces = 0;
            
            for(int i = 0; i < word.Length; i++)
            {
                if(word[i] == ' ')
                {
                    numberOfSpaces++;
                }
                
            }

            if(numberOfSpaces >= 1){
                return true;
            }else
            {
                return false;
            }
        }

        public string CamelString(string word) {
            
        }

        public int CountDigits(string word) {
            throw new NotImplementedException();
        }

        
    }
}
