using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0909
{
    class Undown
    {
        static void Main()
        {
            while (true)
            {
                Random Rand = new Random();
                int i = Rand.Next(1, 101);
                int count = 1;
                string replay;
               
                while (true)
                {
                    Console.Write("숫자를 입력해주세요 : ");
                    int num = int.Parse(Console.ReadLine());

                    if (num == i)
                    {
                        Console.WriteLine("성공입니다.");
                        break;
                    }
                    else if (num < i)
                    {
                        Console.WriteLine("UP");
                    }
                    else if(num>i)
                    {
                        Console.WriteLine("DOWN");
                    }
                    count++;
                }
                Console.WriteLine("총 도전하신 횟수는 " + count + "입니다.");
                Console.WriteLine("다시 도전하시겠습니까? 예(Y) 아니오(N)");
                replay = Console.ReadLine();
                if (replay.ToUpper() == "Y")
                    continue;
                else if (replay.ToUpper() == "N")
                    break;
            }
        }
    }
}
