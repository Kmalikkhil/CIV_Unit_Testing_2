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

            double Degree = Convert.ToDouble(farenheit);
            double Result = (Degree - 32) * / 9;
            Result = Math.Round(Result);
            int celsius = Convert.ToInt32(Result);
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

            string ConvertWord = string.Empty;
            for (int i = 0; i < word.Length; i++)
            {
                if (i % 2 == 0)
                {
                    ConvertWord = ConvertWord + word[i].ToString().ToUpper();
                }
                else
                {
                    ConvertWord = ConvertWord + word[i].ToString().ToLower();
                }
            }
            
            return ConvertWord;
            
        }

        public int CountDigits(string word) {

            int i = 0;
            int l = word.Length;
            int digit = 0;

            while(i<l)
            {
                if(word[i] >= '0' && word[i] <= '9' ) {
                    digit++;
                }

                i++;
            }

            return digit;
            
        }

        
    }
}
