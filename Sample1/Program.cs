using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            singletonObj fromSeller = singletonObj.GetInstance;
            fromSeller.PrintDetails("This message from the seller");

            singletonObj fromCustomer = singletonObj.GetInstance;
            fromCustomer.PrintDetails("This second message from customer");
            Console.ReadLine();
        }
    }
}
