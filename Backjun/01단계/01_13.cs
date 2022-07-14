using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/14
 * 이름 : 허희지
 * 내용 : 백준 1단계 13번 문제 곱셈
 */

namespace Backjun._01단계
{
    internal class _01_13
    {
        static void Main13(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string b = Console.ReadLine();

            char[] c = b.ToCharArray();

            int[] nums = new int[3];


            for (int i = 0; i < 3; i++)
            {
                nums[i] = int.Parse(c[i].ToString());
            }


            int[] result = new int[4] { a * nums[2], a * nums[1], a * nums[0], a * (nums[2] + nums[1] * 10 + nums[0] * 100) };

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
