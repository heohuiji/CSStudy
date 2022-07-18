using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub2
{
    internal class Account
    {
        // 속성 : private 선언으로 캡슐화
        private string bank;   // public을 하면 공개가 됨
        private string id;     // private는 보호의 역할
        private string name;
        private int balance;  //통장잔고


        // 생성자 (private를 쓰기 위해 생성자 사용) : 캡슐화된 속성을 초기화하기 위한 메서드
        // 속성 드래그해서 오른키, 빠른작업으로 생성자 생성시키기
        public Account(string bank, string id, string name, int balance)
        {
            this.bank = bank;
            this.id = id;
            this.name = name;
            this.balance = balance;
        }


        // 기능 : 일반적으로 외부에 기능을 제공하기 위해 public 선언
        public void Deposit(int money)
        {
            this.balance += money;  //돈을 더해준다.this.를 넣어주면 가독성면에서 좋음
        }

        public void Withdraw(int money)
        {
            this.balance -= money;
        }

        public void Show()
        {
            Console.WriteLine("=====================");
            Console.WriteLine("은행명 : " + bank);
            Console.WriteLine("계좌번호 : " + id);
            Console.WriteLine("입금주 : " + name);
            Console.WriteLine("현재잔액 : " + balance);
            Console.WriteLine("---------------------");
        }

    }


        

    
}
