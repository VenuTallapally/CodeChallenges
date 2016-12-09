using System;
using November18th2016.Accounts;

namespace November18th2016.Operations
{
    public static class TransactionHelper
    {
        public static bool IsValidTransaction(AccountType accountType)
        {
            bool isValidTransaction;

            // Deciding about tansaction to proccess or not, depending upon the selected account type
            switch (accountType)
            {
                case AccountType.Active:
                    isValidTransaction = true;
                    break;
                case AccountType.Closed:
                    isValidTransaction = false;
                    break;
                case AccountType.InOperative:
                    isValidTransaction = true;
                    break;
                default:
                    throw new ArgumentException("Enter valid Account type '1 - Active, 2 - Closed, 3 - InOperative' ");
            }
            return isValidTransaction;
        }

        public static void Process(AccountType accountType, TransactionType transactionType)
        {
            bool isTransactionSuccess = false;
            
            // Making transaction
            var transactionFactory = new ConcreteTransactionFactory();
            var transaction = transactionFactory.Create(transactionType);
            
            if (IsValidTransaction(accountType))
            {
                isTransactionSuccess = transaction.MakeTransaction();
            }
            else
            {
                transaction.FailTransaction();
            }
            
            
            // Making the In-operative account to active.
            if (accountType == AccountType.InOperative && isTransactionSuccess)
            {
                MakeAccountActive(transactionType, ref accountType);
            }

            //Displaying User account information.
            var acsFactory = new ConcreteAccountFactory();
            var acs = acsFactory.Create(accountType);
            acs.DisplayAccountInfo();
        }

        private static void MakeAccountActive(TransactionType transactionType, ref AccountType accountType)
        {
            if (transactionType == TransactionType.Deposit || transactionType == TransactionType.Withdraw)
            {
                accountType = (AccountType)1;// Making In-Operative account to active, when user tries to deposit or withdraw.
            }
        }
    }
}
