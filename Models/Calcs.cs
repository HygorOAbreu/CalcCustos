using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CalcCustos.Models
{
    internal class Calcs
    {
        private decimal Km {get; set;}
        private decimal HoraTecnica {get; set;}
        private decimal ValorQtdEquipamentos {get; set;}
        private decimal QtdEquipamentos {get; set;}
        private decimal QtdTecnicos {get; set;}

 
        public void Valores ()
        {
            Console.WriteLine("Digite a Quantidade de KMs");
            Km = ObterValordaTela();
            Console.Clear();
            Console.WriteLine("Digite a Quantidade de Horas Técnicas");
            HoraTecnica = ObterValordaTela();
            Console.Clear();
            Console.WriteLine("Digite o valor do Equipamento(s)");
            ValorQtdEquipamentos = ObterValordaTela();
            Console.Clear();
            Console.WriteLine("Digite a Quantidade de Equipamentos");
            QtdEquipamentos = ObterValordaTela();
            Console.Clear();
            Console.WriteLine("Digite a Quantidade de Técnicos");
            QtdTecnicos = ObterValordaTela();
            Console.Clear();

        }

        private decimal ObterValordaTela ()
        {
            while (true)
            {
                if (decimal.TryParse(Console.ReadLine().Replace('.', ','), out decimal result))
                    return result;
                Console.WriteLine("O valor precisa ser um número");   
               


             }
        }

        public void Calculos()
        {
            decimal Quilometros = (Km / 13.5M) * 5.40M;
            decimal tecnica = HoraTecnica * QtdTecnicos * 71;
            decimal equipamentos = QtdEquipamentos * ValorQtdEquipamentos;

            Console.WriteLine ($"o valor Gasto {Quilometros.ToString("C")}\n" +
                $"Valor da Hora Técnica {tecnica.ToString("C")}\n " +
                $"Valor total dos Equipamentos {equipamentos.ToString("C")}\n");
           
        }            

        
    }
}
