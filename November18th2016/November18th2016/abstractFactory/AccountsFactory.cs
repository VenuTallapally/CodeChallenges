using November18th2016.Accounts;
using November18th2016.interfaces;

namespace November18th2016.abstractFactory
{
    public abstract class AccountsFactory
    {
        public abstract IAccount GetAccountType(AccountType accountType);

    }
}