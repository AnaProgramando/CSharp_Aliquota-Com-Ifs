using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliquotaComIfs
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 4664.69;

            Console.WriteLine("O salário é de " + salario + ".");
            if (salario <= 1903.98)
            {
                Console.WriteLine("O IR é de 0%.");
                Console.WriteLine("Não há parcela a deduzir do IRPF.");
            }
            else if (salario >= 1903.99 && salario <= 2826.65)
            {
                Console.WriteLine("O IR é de 7.5%.");
                Console.WriteLine("Pode deduzir na declaração o valor de R$ 142,80.");
            }
            else if (salario >= 2826.66 && salario <= 3751.05)
            {
                Console.WriteLine("O IR é de 15%.");
                Console.WriteLine("Pode deduzir na declaração o valor de R$ 354,80");
            }
            else if (salario >= 3751.06 && salario <= 4664.68)
            {
                Console.WriteLine("O IR é de 22.5%.");
                Console.WriteLine("Pode deduzir na declaração o valor de R$ 636,13.");
            }
            else
            {
                Console.WriteLine("O IR é de 27,5%.");
                Console.WriteLine("Pode deduzir na declaração o valor de R$ 869,36.");
            }

            Console.ReadLine();
        }
    }
}
