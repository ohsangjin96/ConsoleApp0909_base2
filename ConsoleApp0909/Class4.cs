using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0909
{
    class Class4
    {
        static void Main()
        {
           Random rand = new Random();
            //Console.WriteLine(rand.Next(10));//1~9까지
            //Console.WriteLine(rand.Next(10));
            //Console.WriteLine(rand.Next(10));
            //Console.WriteLine(rand.Next(10));
            //Console.WriteLine(rand.Next(10));

            int[] lotto = new int[6];
            for(int a=0; a<6; a++)
            {
                lotto[a] = rand.Next(1, 47);
            }
            for(int i=0; i<6; i++)
            {
                Console.Write(lotto[i]+", ");
            }
            Console.WriteLine("");
            foreach (int c in lotto)//foreach(변수 in 배열)
                {
                Console.Write(c+", ");
                }
            //=============================================
            //while은(0~n번 실행)
            //do~while은 (1~n번 실행)
        }
    }
}
