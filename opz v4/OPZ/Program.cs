using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OPZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyOPZ myopz = new MyOPZ();

            Console.WriteLine("Введите выражение");

            string stroka = Console.ReadLine();
            string otvet = myopz.Opz(stroka);

            Console.WriteLine(otvet);

            Console.ReadLine();

        }
    }
}
