using CalcCustos.Models;
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
            // Coloca o encoding para UTF8 para exibir acentuação
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Seja bem vindo ao sistema de controles e orçamentos internos!\n" +
                              "Digite o preço inicial:");

            string opcao = string.Empty;
            bool exibirMenu = true;

            // Realiza o loop do menu
            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("1 - Orçamento tecníco");
                Console.WriteLine("2 - em dev");
                Console.WriteLine("3 - em dev");
                Console.WriteLine("4 - Encerrar");

                switch (Console.ReadLine())
                {
                    case "1":
                        //Limpa a tela sempre após selecionar uma opção.
                        Console.Clear();
                        Console.WriteLine("1 - Orçamento tecníco");
                        //Inicializa a classe que absorve os valores e executa os cálculo.
                        var calc = new CalculoDeCustoDeTrabalho();                        
                        calc.Valores();                        
                        calc.Calculos();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("2 - em dev");
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("2 - em dev");
                        break;

                    case "4":
                        //encessa a aplicação.
                        exibirMenu = false;
                        break;

                    default:
                        //caso a opção selecionada não seja valida, envia uma mensagem de erro e solicita nova informação.
                        Console.WriteLine("Opção inválida");
                        break;
                }
                //sempre ao termino de uma atividade o sistema retorna para o menu.
                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadLine();
            }
            // mensagem de aviso de encerramento da aplicação.
            Console.WriteLine("O programa se encerrou");


        }
    }
}
