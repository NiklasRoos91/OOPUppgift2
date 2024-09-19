using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Member : User
    {
        public override void BorrowItem()
        {
            Console.WriteLine("Medlem lånar");
        }

        public override void ReturnItem()
        {
            Console.WriteLine("Medlem lämnar Tillbaka");
        }
    }
}