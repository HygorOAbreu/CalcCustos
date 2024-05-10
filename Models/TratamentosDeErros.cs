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
                // Validação de valor inferior a 0.
                // Caso as validações falhem, o usuario receberá uma notificação "generica" e uma nova chance de inserir a informação correta.
                if (decimal.TryParse(Console.ReadLine().Replace('.', ','), out decimal result) && result > 0) return result;
                Console.WriteLine("O valor precisa ser um número maior que 0");

            }           
            
        }
        
    }
}
