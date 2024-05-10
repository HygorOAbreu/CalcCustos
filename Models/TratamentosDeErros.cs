using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcCustos.Models
{   
    internal class TratamentosDeErros
    {
        public decimal ObterValorNumeroTela()
        {
            while (true)
            {
                if (decimal.TryParse(Console.ReadLine().Replace('.', ','), out decimal result) && result > 0) return result;
                Console.WriteLine("O valor precisa ser um número maior que 0");

            }           
            
        }
        
    }
}
