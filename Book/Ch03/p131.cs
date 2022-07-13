using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class p131
    {
        static void Main131(string[] args)
        {
            Console.WriteLine("숫자 입력: ");
            int input = int.Parse(Console.ReadLine());

            if (input% 2 == 0)
            {
                Console.WriteLine("짝수입니다!");
            }
            else
            {
                Console.WriteLine("홀수입니다!");

                Console.WriteLine();


                if(DateTime.Now.Hour < 12)
                {
                    Console.WriteLine("오전입니다.");
                }
                else
                {
                    Console.WriteLine("오후입니다.");

                }
            }
        }
    }
}
