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

        // hantering av utlåning och återlämning där den används olika för Member och Librarian
        public abstract void BorrowItem();

        public abstract void ReturnItem();

        // Räknar ut vad bötern ska vara
        public void CalculateFine();
        {
            // Vet inte hur den skulle se ut men så lämnar metoden tom
        }

        // Hanterar betalning av böter
        public void PayFine();
        {
            // Vet inte hur den skulle se ut men så lämnar metoden tom
        }
    }
}
