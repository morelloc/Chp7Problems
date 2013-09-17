using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem5
{
    class Program
    {
        static void Main()
        {
            GirlScout Rachael = new GirlScout();
            {
                Rachael.Name = "Rachael";
                Rachael.Number = 20;
                Rachael.Dues = 10000000;
            }
            
            GirlScout Nicole = new GirlScout("Nicole", 12, 0);

            Console.WriteLine("Name: {0} Troop Number: {1} Dues: {2}", Rachael.Name, Rachael.Number, Rachael.Dues);
            Console.WriteLine("Name: {0} Troop Number: {1} Dues: {2}", Nicole.Name, Nicole.Number, Nicole.Dues);
            Console.WriteLine(GirlScout.motto);

        }
    }
}
