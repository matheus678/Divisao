using System;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            [console: Divisao] Receba um numerador e um denominador. Exiba o resultado da divisão ou "Não é possível dividir por zero.", conforme o caso.
            Ex.:
            Digite o numerador....: 12
            Digite o denominador..: 3
            12 dividido por 3 é 4.
            ou
            Digite o numerador....: 0
            Digite o denominador..: 5
            0 dividido por 5 é 0.
            ou
            Digite o numerador....: 12
            Digite o denominador..: 0
            Não é possível dividir por zero.
            */
            
            Decimal n1;
            Decimal n2;
            Decimal DivisaoFinal;

            Console.WriteLine("Olá usuário, estou aqui para ajuda-lo me seu problema matemático");
         

            Console.Write("Usuárior favor usuário, digite o numerador...:");

            n1 = Convert.ToDecimal(Console.ReadLine());

            
            Console.Write("Agora digite o denominador...:");
            n2 = Convert.ToDecimal(Console.ReadLine());

            if (n2 == 0)
            {
                Console.Write("O programa é incapaz de exibir algo dividido por 0");
                Environment.Exit (-1);
            }

            // O coomando Environment.Exit (-1); faz com que o programa seja sencerrado.

            else
            {
                DivisaoFinal = n1 / n2;
                Console.WriteLine($"{n1} dividido por {n2} é igual a {DivisaoFinal}");
            }

            // O comando else siginica "se não" ele é utilizado no programa quando o número é diferente de 0.





        }
    }
}
