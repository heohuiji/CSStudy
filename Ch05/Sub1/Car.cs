using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub1
{
    internal class Car
    {
        // 속성 (필드)
        public string name;  //public은 기본 접근권한임으로 임시로 넣어줌
        public string color;
        public int speed;


        // 기능 (메서드) ----- 여기선 static 잊기.
        public void SpeedUp(int speed) 
        {
            this.speed += speed;    //속성에 대입을 해야해서 this.라는 지시자를 입력
        }
        
        public void SpeedDown(int speed) 
        {
            this.speed -= speed;
        }

        public void Show() 
        {
            Console.WriteLine("====================");
            Console.WriteLine("차량명 : "+name);
            Console.WriteLine("차량색 : "+color);
            Console.WriteLine("현재속도 : "+speed);
            Console.WriteLine("--------------------");
        }


    }
}
