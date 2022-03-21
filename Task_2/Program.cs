using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firststring = "Hello";
            string secondstring = ReverseString(firststring);
        }
        static string ReverseString(string input)
        {
            string temp = string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                temp += input[i];
            }
            return temp;
        }
    }
}
