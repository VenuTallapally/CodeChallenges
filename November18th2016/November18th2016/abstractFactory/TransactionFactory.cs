using November18th2016.Operations;
using November18th2016.interfaces;

namespace November18th2016.abstractFactory
{
    public abstract class TransactionFactory
    {
        public abstract ITransaction Create(TransactionType transactionType);
    }
}
