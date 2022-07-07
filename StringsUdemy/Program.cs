using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.udemy.com/course/csharp-tutorial-for-beginners/learn/lecture/2980860#content
namespace StringsUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Formatting

            ToLower()       "hellow world"
            ToUpper()       "HELLO WORLD"
            Trim()          - removes white spaces around the string
            

            // Searching

            IndexOf('a')            searches for particular character
            LastIndexOf("Hello")    searches for particular string
            

            // Substrings - creates a substring from a given string
            
            Substring(startIndex)
            Substring(startIndex, length)

            
            // Replacing
            
            Replace('a', '!')       replaces character a with !
            Replace("abe", "cede")  replaces string abe with cede


            // Null checking

            String.IsNullOrEmpty(str)
            String.IsNullOrWhiteSpace(str)

            // Splitting

            str.Split(' ')          splits the given string by a character ' ' 
                                    returns an array of strings where each element
                                    contains a word

            // Converting Strings to Numbers

            string s = "1234";

            int i = int.Parse(s);       // if the string is null or empty it throws an exception (program doesn't run)
            or
            int j = Convert.ToInt32(s); // if the string is null or empty it returns 0


            // Converting Numbers to Strings

            int = 1234;

            string s = i.ToString();                                         //"1234"
            string t = i.ToString("C");    C stands for currency             //"$1.234.00"   
            string t = i.ToString("C0");   C0 same, without decimal point    //"$1,234"  
                                           C1 stands for 1 decimal point


            // Format Strings

            Format Specifier        Description         Example             
                                                        
            c or C                  Currency            123456 (C) -> $123,456    
            d or D                  Decimal             1234 (D6) -> 001234
            e or E                  Exponential         1052.0329112756 (E) -> 1.052033E+003
            f or F                  Fixed Point         1234.567 (F1) -> 1234.5
            x or X                  Hexadecimal         255 (X) -> FF

            */
        }
    }
}