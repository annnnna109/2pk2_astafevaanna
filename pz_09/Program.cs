using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольную строку:");
            string input = Console.ReadLine();

            int uppercaseCount = 0;
            int lowercaseCount = 0;
            int whitespaceCount = 0;
            int punctuationCount = 0;

            foreach (char ch in input)
            {
                if (char.IsUpper(ch))
                {
                    uppercaseCount++;
                }
                else if (char.IsLower(ch))
                {
                    lowercaseCount++;
                }
                else if (char.IsWhiteSpace(ch))
                {
                    whitespaceCount++;
                }
                else if (char.IsPunctuation(ch))
                {
                    punctuationCount++;
                }
            }

            int totalCount = uppercaseCount + lowercaseCount + whitespaceCount;

            double punctuationPercentage = (double)punctuationCount / totalCount * 100;

            Console.WriteLine("Заглавных букв: " + uppercaseCount);
            Console.WriteLine("Строчных букв: " + lowercaseCount);
            Console.WriteLine("Количество пробельных символов: " + whitespaceCount);
            Console.WriteLine("Процент символов пунктуации: " + punctuationPercentage.ToString("0") + "%");
        }
    }
}
    

