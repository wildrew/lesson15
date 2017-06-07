using System;
using System.Text;

namespace StringsNullablesConversionsDecisions
{
    class Program
    {
        static void Main()
        {
            // Use a StringBuilder to efficiently change an original string containing
            // the text "Cat" to a result that has one character changed to produce the
            // result "Rat". Then display that result in the console window.

            string str2Change = "Cat";
            System.Text.StringBuilder sb =
                new System.Text.StringBuilder(str2Change); 
            sb[0] = 'R';                                       
            string resultingString = sb.ToString();            
            System.Console.WriteLine(resultingString);

            // Declare a nullable int named x, initialize it to null, and then
            // display it in console output. Then display the boolean value that
            // indicates whether x has a value or not. After that, assign 42 to it
            // and display it again and then display the boolean value again that
            // indicates whether x has a value or not.

            int? x = null;           
            System.Console.WriteLine(x);
            System.Console.WriteLine(x.HasValue);
            x = 42;
            System.Console.WriteLine(x);
            System.Console.WriteLine(x.HasValue);

            // Declare a DateTime variable named aDateTime, and assign it to the result of
            // converting the string "4 July 1776" to a DateTime object. Then display the result.

            System.DateTime aDateTime =
            System.Convert.ToDateTime("4 July 1776");
            System.Console.WriteLine(aDateTime);

            // Declare a variable of type char named ch and initialize it with the value '7'.
            // Then test it in an if statement to see if it is a letter or a
            // non-letter character. Display output on the console that indicates
            // whether it is a letter or a non-letter.

            char ch = '7';
            if (Char.IsLetter(ch))
            {
                System.Console.WriteLine(ch + " is a character");
            }
            else
            {
                System.Console.WriteLine(ch + " is not a character");
            }
        }
    }
}