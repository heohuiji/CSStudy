using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P101
    {
        // var global = 52;  -> 메서드 외부에서 선언 시 오류 발생
        static void Main101(string[] args)
        {
            var local = 273;
        }
    }
}
