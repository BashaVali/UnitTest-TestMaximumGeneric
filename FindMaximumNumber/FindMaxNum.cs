using System;
namespace FindMaximumNumber
{
    public class FindMaximumNum
    {
        //Uc1- Find Max Integer
        public int FindMaxInteger(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > a && b > c)
            {
                return b;
            }
            else
                return c;
        }
        //Uc2- Find Max Float
        public float FindMaxFloat(float a, float b, float c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > a && b > c)
            {
                return b;
            }
            else
                return c;
        }
    }
}