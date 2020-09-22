using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0909
{
    class Program
    {
        static void Main(string[] args)
        {
            //여러가지 실수형의 포맷 방법

            double d = 123456.123456789;
            double t = 12345.678;

            Console.WriteLine(d);
            Console.WriteLine("{0}",d);
            Console.WriteLine("{0:0.00}",d);
            Console.WriteLine(d.ToString("0.00"));
            Console.WriteLine(d.ToString("#.##"));

            Console.WriteLine(t.ToString("0.00"));
            Console.WriteLine(t.ToString("#.##"));

            Console.WriteLine(d.ToString("F"));//소수 둘째자리까지만 표시
            Console.WriteLine(d.ToString("n2"));//쉼표가능,소수점자리수 제어

            Console.WriteLine(Math.Round(d,2));//반올림 System.Math.Round
            Console.WriteLine(Math.Round(t,2));
        }
    }
}
