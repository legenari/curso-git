using System;
using System.Globalization;

namespace Conta_Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta dados;
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Entre o Titular da conta: ");
            string nome = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Havera o valor de depósito inicial (S/N)? ");
            char resposta =char.Parse(Console.ReadLine());

            if (resposta == 'S' || resposta == 's')
            {
                Console.WriteLine("Entre com Valor depósito inicial");
                double valor = double.Parse(Console.ReadLine());

                dados = new Conta(numero, nome, valor);

                Console.WriteLine("Dados da conta :");
                Console.WriteLine(dados);
            }
            else 
            {
                dados = new Conta(numero, nome);

                Console.WriteLine("Dados da conta :");
                Console.WriteLine(dados);
            }



            
            Console.WriteLine("Entre um valor para depósito");
            double deposito = double.Parse(Console.ReadLine());
            dados.Deposito(deposito);
            Console.WriteLine("Dados da conta :");
            Console.WriteLine(dados);
            

            Console.WriteLine("Entre um valor para Saque");
            double Saque = double.Parse(Console.ReadLine());
            dados.Saque(Saque);
            Console.WriteLine("Dados da conta :");
            Console.WriteLine(dados);
            Console.WriteLine("Fim do programa");


        }
    }
}
