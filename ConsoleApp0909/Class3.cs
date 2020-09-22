using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0909
{
    class Class3
    {
        static void Main()
        {
            Console.Write("계속 하시겠습니까? 예(Y), 아니오(N)");
            string reply = Console.ReadLine();

            //if(reply=="Y"|| reply == "N")
            //   Console.WriteLine("예");
            //else if (reply == "N" || reply == "n")
            //    Console.WriteLine("아니오");
            //else
            //    Console.WriteLine("잘못된 입력입니다");
            //switch ~ case
            switch (reply)
            {
                case "Y":
                case "y":
                    Console.WriteLine("예");
                    break;
                case "N": 
                case "n":
                    Console.WriteLine("아니오");
                    break;
                default:
                    Console.WriteLine("잘못입력하셧습니다");
                    break;
            }
            //System.String ToLower()-소문자/ToUpper()-대문자

        }
    }
}
