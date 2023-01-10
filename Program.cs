using System;

namespace StringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] s = "Hello World".ToCharArray();
            ReverseString(s);
            Console.WriteLine(new string(s));
        }
  
        static void ReverseString(char[] s)
        {

            for (int i = 0; i < s.Length; i++)
            {
                int right = s.Length - i - 1; 
                char temp;

                if (i < right)
                {
                    temp = s[right];
                    s[right] = s[i];
                    s[i] = temp;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
