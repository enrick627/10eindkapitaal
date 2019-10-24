//Enrick De Munter 5ITN nr4 23/10/19
/*analyse 
 * vraag het beginkapitaal
 * vraag de looptijd
 * 
 * bereken intrestvoet(/100*1.25)
 * bereken beginkapitaalinput
 * looptijdinput
 * bereken eindkapitaal(bkinput * (1+(/100*1.25)looptijdinput
 * 
 * toon eindkapitaal in 2 cijfers na de komma
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eindkapitaal
{
    class Program
    {
        static void Main(string[] args)
        {//Declaratie 
            string beginkapitaalinput, looptijdinput;
            decimal eindkapitaal, intrestvoet;
            string  looptijd;
            decimal beginkapitaal;



            //input
            //vraag het beginkapitaal
            Console.WriteLine("wat is het beginkapitaal");
            beginkapitaalinput = Console.ReadLine();
            //vraag de looptijd
            Console.WriteLine("wat is de looptijd: ");
            looptijdinput = Console.ReadLine();

            //bereken intrestvoet(/100*1.25)
            
            //bereken beginkapitaalinput
            beginkapitaal = decimal.Parse(beginkapitaalinput);
            //looptijdinput
            looptijd = looptijdinput;
            //bereken eindkapitaal(bkinput* (1+(/100*1.25)looptijdinput
            eindkapitaal = $"eindkapitaal: {beginkapitaalinput * (1 + 1,25%)}";

            //toon eindkapitaal in 2 cijfers na de komma


            //wachten
            Console.WriteLine();
            Console.WriteLine("druk op enter om af te sluiten: ");
            Console.ReadKey();
        }
        

    }
}
