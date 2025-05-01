using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int base0;
            int altura;
            int area;

            Console.Write("digite a base: ");

            base0 = int.Parse(Console.ReadLine());

            Console.Write("digite a altura: ");

            altura = int.Parse(Console.ReadLine());

            area = base0 * altura;

            Console.WriteLine("a area do retangulo é " + area);
        }
    }
}
