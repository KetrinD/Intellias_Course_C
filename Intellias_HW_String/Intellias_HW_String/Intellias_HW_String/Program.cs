using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intellias_HW_String
{
    class Program
    {

        //jjkll
        static void Main(string[] args)
        {
            string str;
            int alp, dig, chars, i, length;

            alp = dig = chars = i = length = 0;


            Console.Write("\n\nCount total number of alphabets, digits and special characters :\n");
            Console.Write("\nInput the string : ");

            str = Console.ReadLine();

            length = str.Length;

            for (i = 0; i < length; i++)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    alp++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    dig++;
                }
                else
                {
                    chars++;
                }
            }

            Console.Write($"\nFOR Number of Alphabets in the string is: {alp}");
            Console.Write($"\nFOR Number of Digits in the string is: {dig}");
            Console.Write($"\nFOR Number of Special characters in the string is:{chars}");

            while (i > length)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    alp++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    dig++;
                }
                else
                {
                    chars++;
                }
                i++;
            }



            Console.Write($"\n  \n");

            Console.Write($"\nWHILE Number of Alphabets in the string is: {alp}");
            Console.Write($"\nWHILE Number of Digits in the string is: {dig}");
            Console.Write($"\nWHILE Number of Special characters in the string is:{chars}");



            Console.ReadKey();
        }
    }
}