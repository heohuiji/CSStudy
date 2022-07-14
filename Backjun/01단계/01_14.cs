using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/14
 * 이름 : 허희지
 * 내용 : 백준 1단계 14번 문제 새싹
 */

namespace Backjun._01단계
{
    internal class _01_14
    {
        static void Main(string[] args)
        {
            string[] arr;

            arr = new string[] { "         ,r\'\"7", "r`-_   ,\'  ,/", " \\. \". L_r\'", "   `~\\/", "      |", "      |" };

            foreach (string i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
