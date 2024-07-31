using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //area = largura x comprimento (10 x 30 =300)
            //preço = area x preço do metro quadrado ( 300 x 200 = 60000)

            double largura, comprimento, precoMetroQuadrado, area, preco;
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comprimento = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            precoMetroQuadrado = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = area * precoMetroQuadrado;

            Console.WriteLine("Area = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Preco = " + preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
