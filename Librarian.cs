using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Librarian : User
    {
        public override void BorrowItem()
        {
            Console.WriteLine("Bibliotekarien lånar ut");
        }

        public override void ReturnItem()
        {
            Console.WriteLine("Bibliotikarien hanterar återlämning");
        }
    }
}
