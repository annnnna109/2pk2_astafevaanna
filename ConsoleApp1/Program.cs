namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char sum1 = 'e';
            char sum2 = 'n';
            char result = sum1==sum2 ? sum1++ :++ sum2;
            Console.WriteLine(result);
        }
    }
}