using System;
using November18th2016.Accounts;
using November18th2016.abstractFactory;
using November18th2016.interfaces;

namespace November18th2016
{
    public class ConcreteAccountFactory : AccountsFactory
    {
        public override IAccount GetAccountType(AccountType accountType)
        {
            switch (accountType)
            {
                case AccountType.Active:
                    return new ActiveAccount();
                case AccountType.Closed:
                    return new ClosedAccount();
                case AccountType.InOperative:
                    return new InOperativeAccount();
                default:
                    throw new ApplicationException("Enter valid Account type '1 - Active, 2 - Closed, 3 - InOperative' ");
            }
        }
    }
}