using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_18_Вариант_5

{
    public enum CreditHistoryStatus
    {
        High, Medium,
        Low
    }
    internal class CreditClient
    {
        private static decimal totalLoanAmount; private static int totalClientCount;
        private string fio;
        private CreditHistoryStatus creditHistory; private decimal loanAmount;
        private decimal interestRate;
        public string FIO
        {
            get { return fio; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Предупреждающее сообщение: ФИО не может быть пустым");
                    Console.WriteLine("Введите ФИО заново:"); string input = Console.ReadLine();
                    FIO = input;
                }
                else
                {
                    fio = value;
                }
            }
        }
        public CreditHistoryStatus CreditHistory
        {
            get { return creditHistory; }
            set { creditHistory = value; }
        }
        public decimal LoanAmount
        {
            get { return loanAmount; }
            set
            {
                if (value < 100000 || value > 5000000)
                {
                    Console.WriteLine("Предупреждающее сообщение: Сумма кредита должна быть от 100 тыс. до 5 млн.");
                }
                else
                {
                    loanAmount = value;
                }
            }
        }
        public decimal InterestRate
        {
            get { return interestRate; }
        }
        public static decimal TotalLoanAmount
        {
            get { return totalLoanAmount; }
        }
        public static int TotalClientCount
        {
            get { return totalClientCount; }
        }
        public CreditClient(string fio, CreditHistoryStatus creditHistory, decimal loanAmount)
        {
            FIO = fio; CreditHistory = creditHistory;
            LoanAmount = loanAmount;
            CalculateInterestRate(); totalLoanAmount += loanAmount;
            totalClientCount++;
        }
        public void PrintClientInformation()
        {
            Console.WriteLine("Информация о клиенте:");
            Console.WriteLine($"ФИО: {fio}"); Console.WriteLine($"Сумма кредита: {loanAmount}");
            Console.WriteLine($"Процент кредита: {interestRate}"); Console.WriteLine($"Статус кредитной истории: {creditHistory}");
        }
        public void GrantLoan()
        {
            if (creditHistory == CreditHistoryStatus.High)
            {
                Console.WriteLine("Кредит выдан! Процент кредита составляет 10%.");
            }
            else if (creditHistory == CreditHistoryStatus.Medium)
            {
                Console.WriteLine("Кредит выдан! Процент кредита составляет 12%.");
            }
            else
            {
                Console.WriteLine("Кредит не выдан! Отказ в кредите.");
            }
        }
        public static void PrintCreditInformation()
        {
            Console.WriteLine("Общая информация о кредитах:"); Console.WriteLine($"Сумма всех выданных кредитов: {totalLoanAmount}");
            Console.WriteLine($"Количество выданных кредитов: {totalClientCount}");
            Console.WriteLine($"Остаток суммы на кредиты: {50000000 - totalLoanAmount}");
        }
        private void CalculateInterestRate()
        {
            if (creditHistory == CreditHistoryStatus.High)
            {
                interestRate = 10;
            }
            else if (creditHistory == CreditHistoryStatus.Medium)
            {
                interestRate = 12;
            }
            else
            {
                interestRate = 0;
            }
        }
    }
}