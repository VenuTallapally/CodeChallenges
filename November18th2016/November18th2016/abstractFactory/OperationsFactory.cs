using November18th2016.Operations;
using November18th2016.interfaces;

namespace November18th2016.abstractFactory
{
    public abstract class OperationsFactory
    {
        public abstract ITransaction GetOperationsType(OperationsType operationsType);

    }
}