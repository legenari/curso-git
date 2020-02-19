using System;
using System.Collections.Generic;
using System.Globalization;

namespace Conta_Banco
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public static double Saldo { get; private set; }

        //Contruto com  dois argumentos
        public Conta(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;

        }
        //Contruto com  tresd argumentos
        public Conta(int numero, string nome, double valor) : this(numero, nome)
        {
            Deposito(valor); //É possivel chamar a função Deposito para o argumento valor
        }

        //Funçoes Deposito e Saque
        public  void Deposito(double valor){
           Saldo += valor;
        }

        public  void Saque(double valor)
        {
            Saldo -= valor+5.00;
        }

        public override string ToString()
        {
            return
                "Conta: "
                + Numero + ", Titular: "
                + Nome + ", Saldo:  $"
                + Saldo.ToString("F2",CultureInfo.InvariantCulture);
               
        }
    }
}
