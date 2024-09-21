using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class User
    {
        public string Name;
        public int Id;
        public int Fine;

        // Abstrakta metoder med hantering av utlåning och återlämning där den används olika för Member och Librarian
        public abstract void BorrowItem();

        public abstract void ReturnItem();

        // Räknar ut vad bötern ska vara
        public void CalculateFine()
        {
            Console.WriteLine("The calculated Fine");
        }
      
        // Hanterar betalning av böter
        public void PayFine()
        {
            Console.WriteLine("Paying Fine");
        }
    }
}
