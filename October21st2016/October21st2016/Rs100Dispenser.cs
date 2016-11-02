namespace October21st2016
{
    public class Rs100Dispenser: IDispenser
    {
        protected IDispenser Dispenser;

        public void SetNextDispenser(IDispenser dispenser)
        {
            Dispenser = dispenser;
        }
        public void Dispense(DispenseRequest dispense)
        {
            var displayDenimonations = new DisplayDenominations();
            const int denomination = 100;
            if (dispense.Amount >= denomination)
            {
                var count = dispense.Amount / denomination;
                var remainder = dispense.Amount % denomination;
                if (count != 0)
                {
                    displayDenimonations.Display(denomination, count);
                }
                if (remainder > 0)
                {
                    Dispenser.Dispense(new DispenseRequest { Amount = remainder });
                }
            }
            else if (Dispenser != null)
            {
                Dispenser.Dispense(dispense);
            }
        }
    }
}
