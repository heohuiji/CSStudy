﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class p133
    {
        static void Main133(string[] args)
        {
            if(DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침 먹을 시간입니다.");
            }
            else
            {
                if(DateTime.Now.Hour < 15)
                {
                    Console.WriteLine("점심 먹을 시간입니다.");

                }
                else
                {
                    Console.WriteLine("저녁 먹을 시간입니다.");
                }
            }
        }
    }
}
