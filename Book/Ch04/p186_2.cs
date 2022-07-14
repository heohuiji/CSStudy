using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{

    using System;
    using System.Threading;

    internal class p186_2
    {
        static void Main186(string[] args)
        {
            Console.WriteLine("첫 번째 출력");
            Thread.Sleep(1000);
            Console.WriteLine("두 번째 출력");
            Thread.Sleep(1000);
            Console.WriteLine("세 번째 출력");
        }
    }
}
