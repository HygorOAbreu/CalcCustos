using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CalcCustos.Models
{
    internal class CalculoDeCustoDeTrabalho
    {       
        private decimal Km {get; set;}
        private decimal HoraTecnica {get; set;}
        private decimal ValorQtdEquipamentos {get; set;}
        private decimal QtdEquipamentos {get; set;}
        private decimal QtdTecnicos {get; set;}
        private decimal ValorPorHora { get; set; }



        public void Valores ()
        {   
            // inicializa a classe de verificação de valores númericos.
            var tratamentoDeErros = new TratamentosDeErros();

            //Solicita ao usuario os valores a serem trabalhados.
            Console.WriteLine("Digite a Quantidade de KMs");
            Km = tratamentoDeErros.ObterValorNumeroTela();
            // limpa a tela após o preenchimento da informação antes da proxima solicitação.
            Console.Clear();
            Console.WriteLine("Digite o valor da Horas Técnicas");
            ValorPorHora = tratamentoDeErros.ObterValorNumeroTela();
            Console.Clear();
            Console.WriteLine("Digite a Quantidade de Horas Técnicas trabalhadas");
            HoraTecnica = tratamentoDeErros.ObterValorNumeroTela();
            Console.Clear();
            Console.WriteLine("Digite o valor do Equipamento(s)");
            ValorQtdEquipamentos = tratamentoDeErros.ObterValorNumeroTela();
            Console.Clear();
            Console.WriteLine("Digite a Quantidade de Equipamentos");
            QtdEquipamentos = tratamentoDeErros.ObterValorNumeroTela();
            Console.Clear();
            Console.WriteLine("Digite a Quantidade de Técnicos");
            QtdTecnicos = tratamentoDeErros.ObterValorNumeroTela();
            Console.Clear();
        }

        public void Calculos()
        {
            //executa os cálculos e retorna o resultado para o usuario.
            decimal Quilometros = (Km / 13.5M) * 5.40M;
            decimal tecnica = HoraTecnica * QtdTecnicos * ValorPorHora;
            decimal equipamentos = QtdEquipamentos * ValorQtdEquipamentos;

            Console.WriteLine ($"o valor Gasto {Quilometros.ToString("C")}\n" +
                $"Valor da Hora Técnica {tecnica.ToString("C")}\n " +
                $"Valor total dos Equipamentos {equipamentos.ToString("C")}\n");
           
        }

    }
}
