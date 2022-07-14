using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/14
 * 이름 : 허희지
 * 내용 : 백준 1단계 8번 문제 A/B 
 */

namespace Backjun._01단계
{
    internal class _01_08
    {

            static void Main8(string[] args)
            {
                string[] inputs = Console.ReadLine().Split();

                double a = double.Parse(inputs[0]);
                double b = double.Parse(inputs[1]);

                Console.WriteLine(a / b);

            }
        
    }
}
