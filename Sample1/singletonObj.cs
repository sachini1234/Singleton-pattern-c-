using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{
    public sealed class singletonObj
    {
        private static int counter = 0;
        private static singletonObj instance = null;
        public static singletonObj GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new singletonObj();
                return instance;
            }
        }
        private singletonObj()
        {
            counter++;
            Console.WriteLine("Item No. " + counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
