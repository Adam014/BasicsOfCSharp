using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    class ItalianChef : Chef
    {
        // znak : spoji chef a italianchef a italianchef bude umet metody ktery ma v sobe chef

        public override void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes italian special dish...");
        }

        public void MakePasta()
        {
            Console.WriteLine("Italian chef makes pasta...");
        }
        
    }
}
