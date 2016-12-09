using System;
using November18th2016.Operations;
using November18th2016.abstractFactory;
using November18th2016.interfaces;

namespace November18th2016
{
    public class ConcreteOperationsFactory : OperationsFactory
    {
        public override ITransaction GetOperationsType(OperationsType operationsType)
        {
            switch (operationsType)
            {
                case OperationsType.Deposit:
                    return new Deposit();
                case OperationsType.Withdraw:
                    return new Withdraw();
                case OperationsType.BalanceEnquiry:
                    return new BalanceEnquiry();
                default:
                    throw new ApplicationException(string.Format("Enter valid operational type 'Deposit / Withdraw / Balance' "));
            }
        }

    }
}