using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando instância da conta
            Conta conta1 = new Conta();

            //Criando 2ª instância da conta
            Conta conta2 = new Conta();

            //Atribuindo valores para conta 1
            conta1.Saldo = 1500;
            conta1.Limite = 500;
            conta1.Numero = 123;

            //Atribuindo valores para conta 2
            conta2.Saldo = 2000;
            conta2.Limite = 600;
            conta2.Numero = 456;

            Console.WriteLine("Olá, seu saldo em conta é: " + conta1.Saldo);
            Console.WriteLine("O limite de saque é: " + conta1.Limite);
            Console.WriteLine("O número da conta é: " + conta1.Numero);

            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("Olá, seu saldo em conta é: " + conta2.Saldo);
            Console.WriteLine("O limite de saque é: " + conta2.Limite);
            Console.WriteLine("O número da conta é: " + conta2.Numero);
        }
    }
}
