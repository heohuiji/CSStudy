﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/14
 * 이름 : 허희지
 * 내용 : 백준 1단계 6번 문제 A-B 
 */

namespace Backjun._01단계
{
    internal class _01_06
    {
        static void Main6(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();

            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);

            Console.WriteLine(a - b);

        }
    }
}
