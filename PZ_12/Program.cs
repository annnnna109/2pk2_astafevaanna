namespace PZ_12
{
    internal class Program
    {
        static void Main(string[] args)
        { 
             double GetPunctuationPercentage(string text)
            {
                int punctuationCount = 0;
                int totalChars = text.Length;

                foreach (char c in text)
                {
                    if (char.IsPunctuation(c))
                    {
                        punctuationCount++;
                    }
                }

                double percentage = (double)punctuationCount / totalChars * 100;
                return percentage;
            }

            string input = "Это текст с знаками препинания!";
            double punctuationPercentage = GetPunctuationPercentage(input);
            Console.WriteLine("Процентное соотношение знаков препинания: {0}%", punctuationPercentage);

        }
    }
}