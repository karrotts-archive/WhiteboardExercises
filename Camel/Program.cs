using System;
using System.Text;

namespace Camel
{
    class Program
    {
        static void Main(string[] args)
        {
            // the Cat in the hat -> theCatInTheHat
            // the cat in the hat -> TheCatInTheHat

            Console.WriteLine(CamelCase("The Cat in1 THE hat"));
            Console.WriteLine(CamelCase("                Shadows  in   the .. Rain"));
            Console.WriteLine(CamelCase("The Cat in THE hat"));
            //Console.WriteLine(PascalCase("the cat in the hat"));
        }

        static string CamelCase(string input)
        {
            string output = "";
            bool foundFirst = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsLetterOrDigit(input[i]))
                {
                    if(!foundFirst)
                    {
                        output += input[i].ToString().ToLower();
                        foundFirst = true;
                    }
                    else if (i != 0 && !(Char.IsLetterOrDigit(input[i - 1])))
                    {
                        output += input[i].ToString().ToUpper();
                    } 
                    else
                    {
                        output += input[i].ToString().ToLower();
                    }
                }
            }
            return output;
        }

        static string PascalCase(string input)
        {
            string output = "";
            bool foundFirst = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'A' && input[i] <= 'z')
                {
                    if (i != 0 && !(input[i - 1] >= 'A' && input[i - 1] <= 'z'))
                    {
                        output += input[i].ToString().ToUpper();
                    }
                    else if (i == 0 && input[i] >= 'A' && input[i] <= 'z')
                    {
                        output += input[i].ToString().ToUpper();
                    }
                    else
                    {
                        output += input[i].ToString().ToLower();
                    }
                }
            }
            return output;
        }

        public static string Dan (string inputString)
        {
            string result = "";
            bool newWord = false;
            foreach(char c in inputString)
            {
                if (char.IsWhiteSpace(c) || c == '-') newWord = true;
                if (char.IsLetterOrDigit(c) || c == '_')
                {
                    result += newWord ? char.ToUpper(c) : char.ToLower(c);
                    newWord = false;
                }
            }
            return result;
        }

    }
}
