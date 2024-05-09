using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcCustos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Digite a Quantidade de KMs");
            decimal km = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Quantidade de Horas Técnicas");
            decimal horatecnica = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Quantidade de Equipamentos");
            decimal QtdEquipamentos = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Quantidade de Técnicos");
            decimal QtdTecnicos = decimal.Parse(Console.ReadLine());

            decimal Quilometros = (km / 13.5M) * 5.40M;
            Console.WriteLine($"o valor Gasto {Quilometros.ToString("C", CultureInfo.GetCultureInfo("pt-br"))}\n");

            decimal tecnica = horatecnica * QtdTecnicos * 71;
            Console.WriteLine($"Valor da Hora Técnica {tecnica.ToString("C", CultureInfo.GetCultureInfo("pt-br"))}\n");

            decimal equipamentos = QtdEquipamentos * 350;
            Console.WriteLine($"Valor total dos Equipamentos {equipamentos.ToString("C", CultureInfo.GetCultureInfo("pt-br"))}\n");

            Console.WriteLine("Precione qualquer tecla para finalizar");
            Console.ReadLine();

        }
    }
}
