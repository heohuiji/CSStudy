using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P91
    {
        static void Main91(string[] args)
        {
            int output = 0;
            output += 52;
            output += 273;
            output += 103;

            Console.WriteLine(output);

            // 2-38

            output = output + 52;
            output = output + 273;
            output = output + 103;

            Console.WriteLine(output);

        }
    }
}
