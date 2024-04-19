using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            SettlerUnit settler = new SettlerUnit();
            MilitaryUnit soldier = new MilitaryUnit(2, 100, 20);

            int settlerMovement = settler.Move();
            int soldierMovement = soldier.Move();

            Console.WriteLine("Settler Health: " + settler.Health);
            Console.WriteLine("Settler Cost: " + settler.Cost);
            Console.WriteLine("Soldier Health: " + soldier.Health);
            Console.WriteLine("Soldier Cost: " + soldier.Cost);
        }
    }
}
