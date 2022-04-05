using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando instância da conta
            Conta conta1 = new Conta();

            conta1.Saldo = 1500;
            conta1.Limite = 500;
            conta1.Numero = 123;

            Console.WriteLine("Olá, seu saldo em conta é: " + conta1.Saldo);
            Console.WriteLine("O limite de saque é: " + conta1.Limite);
            Console.WriteLine("O número da conta é: " + conta1.Numero);
        }
    }
}
