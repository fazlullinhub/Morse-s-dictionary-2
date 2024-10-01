using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, char> morseCodeDict = new Dictionary<string, char>
            {
            { ".-", 'A' },
            { "-...", 'B' },
            { "-.-.", 'C' },
            { "-..", 'D' },
            { ".", 'E' },
            { "..-.", 'F' },
            { "--.", 'G' },
            { "....", 'H' },
            { "..", 'I' },
            { ".---", 'J' },
            { "-.-", 'K' },
            { ".-..", 'L' },
            { "--", 'M' },
            { "-.", 'N' },
            { "---", 'O' },
            { ".--.", 'P' },
            { "--.-", 'Q' },
            { ".-.", 'R' },
            { "...", 'S' },
            { "-", 'T' },
            { "..-", 'U' },
            { "...-", 'V' },
            { ".--", 'W' },
            { "-..-", 'X' },
            { "-.--", 'Y' },
            { "--..", 'Z' },
            { "-----", '0' },
            { ".----", '1' },
            { "..---", '2' },
            { "...--", '3' },
            { "....-", '4' },
            { ".....", '5' },
            { "-....", '6' },
            { "--...", '7' },
            { "---..", '8' },
            { "----.", '9' },
            { "/", ' ' } 
        };

            Console.WriteLine("Write some text in morse dictionary (use the whitespace to separate letters and '/' to separate words):");
            string morseInput = Console.ReadLine();
            string[] morseWords = morseInput.Split(new char[] { ' ', '/' }, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder decodedMessage = new StringBuilder();

            foreach (string morseLetter in morseWords)
            {
                if(morseCodeDict.TryGetValue(morseLetter, out char letter))
                {
                    decodedMessage.Append(letter);
                }
                else
                {
                    Console.WriteLine($"Wrong morse's code: {morseLetter}");
                }
            }

            Console.WriteLine("Decoded message: " + decodedMessage.ToString());
        }
    }
}

