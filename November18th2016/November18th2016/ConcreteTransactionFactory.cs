using System;
using November18th2016.Operations;
using November18th2016.abstractFactory;
using November18th2016.interfaces;

namespace November18th2016
{
    public class ConcreteTransactionFactory : TransactionFactory
    {
        public override ITransaction Create(TransactionType transactionType)
        {
            switch (transactionType)
            {
                case TransactionType.Deposit:
                    return new Deposit();
                case TransactionType.Withdraw:
                    return new Withdraw();
                case TransactionType.BalanceEnquiry:
                    return new BalanceEnquiry();
                default:
                    throw new ApplicationException(string.Format("Enter valid transaction type 'Deposit / Withdraw / Balance' "));
            }
        }
    }
}
