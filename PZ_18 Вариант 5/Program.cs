namespace PZ_18_Вариант_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditClient client1 = new CreditClient("Мухамбетова Алина Сериковна", CreditHistoryStatus.High, 100000); client1.PrintClientInformation();
            client1.GrantLoan();
            CreditClient client2 = new CreditClient("Сарбаева Азалия Зинуровна", CreditHistoryStatus.Medium, 3000000); client2.PrintClientInformation();
            client2.GrantLoan();
            CreditClient client3 = new CreditClient("Винс Елена Алексеевна", CreditHistoryStatus.Low, 5000000); client3.PrintClientInformation();
            client3.GrantLoan();
            CreditClient.PrintCreditInformation();
        }
    }
}