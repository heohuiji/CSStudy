using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/14
 * 이름 : 허희지
 * 내용 : 백준 1단계 11번 문제 1998년생인 내가 태국에서는 2541년생?! 
 */

namespace Backjun._01단계
{
    internal class _01_11
    {
        static void Main11(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            Console.Write(year - 543);
        }
    }
}
