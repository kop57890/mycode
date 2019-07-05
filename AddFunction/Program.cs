using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddFunction
{
    public class AddMethod
    {
        static void Main(string[] args)
        {
            int tmp = Add(1, 2);
            Console.WriteLine(tmp);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public static int Add(int fnum, int secnum) {
            return fnum + secnum;
        }
    }
}
