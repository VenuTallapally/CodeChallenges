using System;
using November18th2016.interfaces;

namespace November18th2016.Accounts
{
    public class ActiveAccount : IAccount
    {
        public void DisplayAccountInfo()
        {
            Console.WriteLine("Account type: ACTIVE\n");
        }
    }
}