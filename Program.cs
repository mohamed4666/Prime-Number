using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int num1, num2, flag, temp;
            Console.WriteLine(" ENTER THE FIRST NUMBER ");

            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ENTER THE SCONDE NUMBER ");

            num2 = int.Parse(Console.ReadLine());

            if(num1>num2)
            {
                temp = num1;
                num1 = num2;
                num2 = temp;
            }
            Console.WriteLine( "prime Number Between  " + num1 + "  and  " + num2);
            while (num1 < num2)
            {

                flag = 0;
                for (i = 2; i <= num1 / 2; i++)
                {
                    if (num1 % i == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                    Console.WriteLine(" \t " + num1);
                num1++;
            
            }
            Console.WriteLine("   DO YOU HAVE A COMMENT OR PROBLEM   ");

            Console.ReadLine();
            Console.WriteLine("   THANK YOU FOR USE ME APP   ");

        }
    }
}
