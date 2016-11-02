using System;

namespace October21st2016
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chain Of Responsibility Design pattern (Type:Behavioral Design Pattern)
            var rs1000Dispenser = new Rs1000Dispenser();
            var rs500Dispenser = new Rs500Dispenser();
            var rs100Dispenser = new Rs100Dispenser();

            // Giving responsibily to the next chain
            rs1000Dispenser.SetNextDispenser(rs500Dispenser);
            rs500Dispenser.SetNextDispenser(rs100Dispenser);

            Console.WriteLine("Please enter amount:");

            try
            {
                var amount = Convert.ToInt32(Console.ReadLine());
                var dispenseReq = new DispenseRequest {Amount = amount};
                if (amount % 100 == 0)
                {
                    rs1000Dispenser.Dispense(dispenseReq);
                }
                else
                {
                    Console.WriteLine("Amount cannot be Dispensed.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR:{0}", ex.Message);
            }

            
        }
    }
}
