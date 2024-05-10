using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcCustos.Models
{   
    internal class TratamentosDeErros
    {
        // valida se a informação inserida é um valor decimal.
        public decimal ObterValorNumeroTela()
        {

            while (true)
            {
                // validação de "." e "," aceitando qualquer um dos caracteres para a execução do código de forma correta.
                if (decimal.TryParse(Console.ReadLine().Replace('.', ','), out decimal result))
                    {
                    if (result > 0)
                    {
                        return result;
                    }
                    else
                    {
                        // validação se o valor digitado é um número.
                        Console.WriteLine("O valor precisa ser um número maior que 0");
                    }
                } else {
                    // Validação de valor é inferior a 0.                
                    Console.WriteLine("O valor precisa ser um número");
                }
            }           
            
        }
        
    }
}
