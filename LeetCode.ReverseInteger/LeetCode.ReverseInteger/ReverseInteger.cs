using System;

namespace LeetCode.ReverseInteger
{
    public class ReverseInteger
    {
        public int Reverse(int x)
        {            
            int reverse = 0;
            int remainder;

            checked
            {
                try
                {
                    while (x != 0)
                    {
                        remainder = x % 10;
                        reverse = reverse * 10 + remainder;
                        x /= 10;
                    }
                }
                catch(OverflowException)
                {
                    reverse = 0;
                }
                 
            }               

            return reverse;
        }
    }
}
