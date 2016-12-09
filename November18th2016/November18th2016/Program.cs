using System;
using November18th2016.Accounts;
using November18th2016.Operations;

namespace November18th2016
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                //Abstract factory design pattern
                AtmOpeartions();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:{0}\n\n", ex);
                Console.ReadKey();
            }
        }

        private static void AtmOpeartions()
        {
            while (true)
            {
                Console.WriteLine("Note: To exit from the application, Please type 'exit' ");
                Console.WriteLine("Enter an Operation Type: (Select 1 - Deposit, 2 - Withdraw, 3 - Balance)");
                
                var opeartion = Console.ReadLine();
                if (opeartion != null)
                    if (opeartion.ToUpper() == "EXIT") return;
                var transactionType = (TransactionType)Convert.ToInt32(opeartion);

                Console.WriteLine("Enter a Account Type: (Select 1 - Active, 2 - Closed, 3 - InOperative)");
                var accountType = (AccountType)Convert.ToInt32(Console.ReadLine());

                TransactionHelper.Process(accountType, transactionType);
            }
        }
    }
}
