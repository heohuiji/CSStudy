using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub2
{
    internal class Car
    {
        // 속성 (필드)
        private string name;  //public은 기본 접근권한임으로 임시로 넣어줌
        private string color;
        private int speed;

        //Getter, Setter : C#에서 '프로퍼티'라고 함
        public string Name1 { get => name; set => name = value; }
        public string Color1 { get => color; set => color = value; }
        public int Speed1 { get => speed; set => speed = value; }



        // 속성을 드래그하고 오른쪽 빠른작업 필드 캡슐화
        public string Name 
        { 
            get => Name1; 
            set => Name1 = value; 
        }
        public string Color 
        { 
            get => Color1; 
            set => Color1 = value; 
        }
        public int Speed
        {
            get => Speed1;
            set
            {
               if(value < 0)
                {
                    Console.WriteLine("speed는 0보다 작을 수 없습니다.");
                    Speed1 = 0;
                }
               else
                {
                    Speed1 = value;
                }
            }
        }

        



        //생성자

        public Car()
        {
            // 기본 샌성자 (오버로딩 메서드)
        }


        public Car(string name, string color, int speed)
        {
            this.Name = name;
            this.Color = color;
            this.Speed = speed;
        }


        // 기능 (메서드) ----- 여기선 static 잊기.
        public void SpeedUp(int speed) 
        {
            this.Speed += speed;    //속성에 대입을 해야해서 this.라는 지시자를 입력
        }
        
        public void SpeedDown(int speed) 
        {
            this.Speed -= speed;
        }

        public void Show() 
        {
            Console.WriteLine("====================");
            Console.WriteLine("차량명 : "+Name);
            Console.WriteLine("차량색 : "+Color);
            Console.WriteLine("현재속도 : "+Speed);
            Console.WriteLine("--------------------");
        }


    }
}
