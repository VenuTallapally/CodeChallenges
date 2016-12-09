using System;
using November18th2016.interfaces;

namespace November18th2016.Operations
{
    public class Withdraw : ITransaction
    {
        public bool MakeTransaction()
        {
            Console.WriteLine("You can do Withdraw : True");
            // Depends on the transaction
            return true;
        }

        public void FailTransaction()
        {
            Console.WriteLine("You can't do Withdraw : False");
        }
    }
}
