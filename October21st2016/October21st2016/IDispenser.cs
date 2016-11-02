namespace October21st2016
{
    public interface IDispenser
    {
        void SetNextDispenser(IDispenser dispenser);
        void Dispense(DispenseRequest dispense);
    }
}
