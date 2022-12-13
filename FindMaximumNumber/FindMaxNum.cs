using System;
namespace FindMaximumNumber
{    
    //Uc1-Find Max Integer
    public class FindMaximumNum
    {
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
        //Uc1-Find Max Float
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
        //Uc1-Find Max String
        public string FindMaxString(string a, string b, string c)
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
            {
                return a;
            }
            else if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
            {
                return b;
            }
            else
                return c;
        }
    }
}