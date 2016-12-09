using System;
using November18th2016.Accounts;

namespace November18th2016.Operations
{
    public static class Operation
    {
        public static void ManageTransactions(AccountType accountType, OperationsType operationsType)
        {
            bool isTransactionAllowed, isTransactionSuccess = false;
            
            // Deciding about tansaction to proccess or not, depending upon the selected account type
            switch (accountType)
            {
                case AccountType.Active:
                    isTransactionAllowed = true;
                    break;
                case AccountType.Closed:
                    isTransactionAllowed = false;
                    break;
                case AccountType.InOperative:
                    isTransactionAllowed = true;
                    break;
                default:
                    throw new ApplicationException("Enter valid Account type '1 - Active, 2 - Closed, 3 - InOperative' ");
            }

            // Making transaction
            var opsFactory = new ConcreteOperationsFactory();
            var ops = opsFactory.GetOperationsType(operationsType);
            if (isTransactionAllowed)
            {
                isTransactionSuccess = ops.MakeTransaction();
            }
            else
            {
                ops.FailTransaction();
            }
            
            // Making the In-operative account to active.
            if (accountType == AccountType.InOperative && isTransactionSuccess)
            {
                MakeAccountActive(operationsType, ref accountType);
            }

            //Displaying User account information.
            var acsFactory = new ConcreteAccountFactory();
            var acs = acsFactory.GetAccountType(accountType);
            acs.DisplayAccountInfo();
        }

        private static void MakeAccountActive(OperationsType operationsType, ref AccountType accountType)
        {
            if (operationsType == OperationsType.Deposit || operationsType == OperationsType.Withdraw)
            {
                accountType = (AccountType)1;// Making In-Operative account to active, when user tries to deposit and withdraw.
            }
        }
    }
}