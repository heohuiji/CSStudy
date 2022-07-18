using Ch05.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/18
 * 이름 : 허희지
 * 내용 : 캡슐화 실습하기 교재 p203
 * 
 * 캡슐화(Encapsulation)
 * - 캡슐화는 객체의 내용(필드)를 이부에서 참조하지 못하도록 객체의 정보(속성)을 은닉하는 특성
 * - 캡슐화를 위해 접근 제한자 public, private, protected를 사용
 * - 은닉된 정보의 안전한 제공을 위해 Gette, Setter를 사용(프로퍼티)
 */

namespace Ch05
{
    internal class _2_캡슐화
    {
        static void Main2(string[] args)
        {
            // 객체 생성
            Account kb = new Account("국민은행", "101-12-1010", "김유신", 10000);


            /*Account 객체 초기화
            kb.bank = "국민은행";
            kb.id = "101-12-1010";
            kb.name = "김유신";
            kb.balance = 10000;
            
            // private를 쓰면 초기화를 쓸 수 없음. (생성자가 필요)
            */


            // Account 객체 활용
            kb.Deposit(40000);
            kb.Withdraw(5000);
            kb.Show();

            // 캡슐화로 취약코드 예방
            //kb.balance--;




            //객체 생성
            Car sonata = new Car("소나타", "흰색", 0);

            sonata.SpeedUp(100);
            sonata.SpeedDown(20);
            sonata.Show();

            // Getter, Setter 활용한 객체
            Car bmw = new Car();  // 오버로딩메서드를 사용하면 오류 사라짐


            sonata.Name = "BMW 520";//setter호출 private이라서 소문 n은 X
            sonata.Color = "남색";
            sonata.Speed = -10;

            Console.WriteLine("bmw name : " + bmw.Name);  // getter
            Console.WriteLine("bmw color : " + bmw.Color);
            Console.WriteLine("bmw speed : " + bmw.Speed);

        }
    }
}
