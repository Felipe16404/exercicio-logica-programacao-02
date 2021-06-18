using System;

namespace VSProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um sálario:");
            string digitadoString = Console.ReadLine();
            double digitado = Convert.ToDouble(digitadoString);

            Console.WriteLine("Digite a porcentagem para reajuste:");
            string reajusteString = Console.ReadLine();
            double porcentagem = Convert.ToDouble(reajusteString);

            double resultado = digitado + ((porcentagem / 100) * digitado);
            string mensagem = string.Format("Salario de R${0} reajustado para R${1}", digitado, resultado);
            Console.WriteLine(mensagem);
        }
    }
}
