using System.Diagnostics.Tracing;

namespace vtnjls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string str = Console.ReadLine();
            // string[] arrayWords = GetWordArray(str);
            // foreach (string word in arrayWords) { Console.WriteLine(word); }
            int[] Numbers = { 1, 2, 3, -1, -2, -3 };
            int[] PositiveNumber = NumberArray(Numbers);
            static string GetWordArray(string s)
            {
                string[] words;
                words = s.Split(' ');
                return words;
            }
            static int[] NumberArray(int[] array)
            {
                int count = 0;
                foreach (int i in array)
                {
                    count++;
                }
                int[] result = new int[count];
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                    {
                        result[i] = array[i];
                    }
                }
                return result;

            }
        }



    }

}