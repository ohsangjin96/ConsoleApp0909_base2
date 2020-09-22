using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0909
{
    class Class1
    {
        static void Main()
        {
            //숫자를 입력받아서 변수에 저장
            int n1 = int.Parse(Console.ReadLine());

            //중단점:컴파일러가 이 문장을 실행할 순서가 되었을때(실행하기 전) 멈춰서 디버깅이 가능한 도구
            //중단점으로 디버깅을 하기 위해서는 F5로 실행
            //콘솔프로그램의 경우,디버깅을 하고 싶으면 중단점 찍고 F5
            //단순 실행만 하고 싶으면 ctrl+F5를 사용해서 실행

            //삼항 연산자 (조건)?참실행:거짓실행;
            //odd = (n1 % 2 == 0) ? false : true;
            //삼항 연산자는 2개까지만 쓰기
            if (n1 % 5 == 0)
            {
                Console.WriteLine("5");
            }
            else if (n1 % 3 == 0)
            {
                Console.WriteLine("3");
            }
            else
            {
                Console.WriteLine("9");
            }

            string result = string.Empty;
        }
    }
}
