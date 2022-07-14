using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/14
 * 이름 : 허희지
 * 내용 : 백준 1단계 12번 문제 나머지 
 */

namespace Backjun._01단계
{            
    using System.Collections;

    internal class _01_12
    {
        static void Main12(string[] args)
        {

            string line = Console.ReadLine();
            string[] nums = line.Split(" ");

            int A, B, C;
            A = int.Parse(nums[0]);
            B = int.Parse(nums[1]);
            C = int.Parse(nums[2]);

            int[] result = new int[4] { (A + B) % C, ((A % C) + (B % C)) % C, (A * B) % C, ((A % C) * (B % C)) % C };

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
