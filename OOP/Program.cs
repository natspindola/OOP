using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Encapsulamento significa separar o programa wm partes mais isoladas possível
            // serve para controlar o acesso aos atributos e métodos de uma classe

            AnalistaTI analistaTI = new AnalistaTI();

            analistaTI.AdicionarNome("Natália", "Spindola");
            analistaTI.AdicionarSalarioPadrao(1000);
            analistaTI.Reajustar();

            Console.WriteLine("Salário é: " + analistaTI.Salario);
        }
    }
}



////Primeira forma - sem usar método

//Criando instância da conta
//Conta conta1 = new Conta();

//Criando 2ª instância da conta
//Conta conta2 = new Conta();

//Atribuindo valores para conta 1
//conta1.Saldo = 1500;
//conta1.Limite = 500;
//conta1.Numero = 123;

//Atribuindo valores para conta 2
//conta2.Saldo = 2000;
//conta2.Limite = 600;
//conta2.Numero = 456;

//Console.WriteLine("Olá, seu saldo em conta é: " + conta1.Saldo);
//Console.WriteLine("O limite de saque é: " + conta1.Limite);
//Console.WriteLine("O número da conta é: " + conta1.Numero);

//Console.WriteLine("-----------------------------------------------------------------");

//Console.WriteLine("Olá, seu saldo em conta é: " + conta2.Saldo);
//Console.WriteLine("O limite de saque é: " + conta2.Limite);
//Console.WriteLine("O número da conta é: " + conta2.Numero);





////Criando instância da conta com métodos
//Conta conta = new Conta(123, 300);

//conta.AdicionarLimite(1500);

//conta.Deposita(1500);
//conta.Deposita(2500);
//conta.Deposita(4500);

//bool saca = conta.Saca(7000); //saque maior que saldo dá valor indisponível

//if (saca)
//{
//    double saldo = conta.ConsultaSaldoDisponivel();

//    Console.WriteLine("Seu saldo é: " + saldo);
//    Console.WriteLine("Seu limite é: " + conta.Limite);
//    Console.WriteLine("O número da sua conta é: " + conta.Numero);
//}





//// Criando um objeto de cada classe

//CartaoDeCredito cdc = new CartaoDeCredito();
//Cliente c = new Cliente();

////Adicionando o nome do cliente
//c.Nome = "Natália Spindola";

////Adicionando o número e data de validade do cartão
//cdc.Numero = "1234 5678 9012 3456";
//cdc.DataDeValidade = "04/2026";
//cdc.Cliente = c;

//Console.WriteLine("O nome do cliente é: " + c.Nome);
//Console.WriteLine("O número do cartão é: " + cdc.Numero);
//Console.WriteLine("A validade do cartão é: " + cdc.DataDeValidade);
//Console.WriteLine("O nome do cliente do agregado é: " + cdc.Cliente.Nome);





//// Métodos e atributos estáticos

//Conta conta1 = new Conta(123, 500);
//Conta conta2 = new Conta(456, 800);
//Conta conta3 = new Conta(789, 900);
//Conta conta4 = new Conta(987, 1000);

//Console.WriteLine("Total de contas: " + Conta.TotalContasCriadas);

//int total = Conta.ProximoTotalContasCriadas();
//Console.WriteLine("Próximo total de contas: " + total);




//// Herança

//ContaPoupanca contaPoupanca = new ContaPoupanca(112, 0);

//contaPoupanca.Deposita(100);
//contaPoupanca.Saca(10);

//double saldo = contaPoupanca.ConsultaSaldoDisponivel();

//contaPoupanca.MostrarNumeroConta();

//Console.WriteLine("Saldo da conta poupança é: " + saldo);

//Conta conta = new Conta(113, 100);

//conta.Deposita(500);
//conta.Saca(140);

//double saldoContaCorrente = conta.ConsultaSaldoDisponivel();

//Console.WriteLine("Saldo da conta corrente é: " + saldoContaCorrente);




//// classe abstrata não permite instancia. serve de modelo para uma classe filha
//// polimorfismo é "muitas formas", cada ação tem determinadas características diferentes

//AnalistaTI analistaTI = new AnalistaTI();
//Gerente gerente = new Gerente();
//GerenteAgencia gerenteAgencia = new GerenteAgencia();
//GerenteTI gerenteTI = new GerenteTI();

//analistaTI.Nome = "Natalia Spindola";
//analistaTI.Salario = 3000;
//Console.WriteLine("O salário do Analista de TI é: " + analistaTI.Salario);
//analistaTI.Reajustar();
//Console.WriteLine("O salário do Analista de TI reajustado é: " + analistaTI.Salario);

//Console.WriteLine("---------------------------------------------------------------------------");

//gerente.Nome = "Natanael Spindola";
//gerente.Salario = 8000;
//Console.WriteLine("O salário do Gerente é: " + gerente.Salario);
//gerente.Reajustar();
//Console.WriteLine("O salário do Gerente reajustado é: " + gerente.Salario);

//Console.WriteLine("---------------------------------------------------------------------------");

//gerenteAgencia.Nome = "Leila Spindola";
//gerenteAgencia.Salario = 10000;
//Console.WriteLine("O salário do Gerente de Agência é: " + gerenteAgencia.Salario);
//gerenteAgencia.Reajustar();
//Console.WriteLine("O salário do Gerente de Agência reajustado é: " + gerenteAgencia.Salario);

//Console.WriteLine("---------------------------------------------------------------------------");

//gerenteTI.Nome = "Gustavo Spindola";
//gerenteTI.Salario = 20000;
//Console.WriteLine("O salário do Gerente de Agência é: " + gerenteTI.Salario);
//gerenteTI.Reajustar();
//Console.WriteLine("O salário do Gerente de TI reajustado é: " + gerenteTI.Salario);





//// Interface é um conjunto de métodos públicos que deverão ser implementados pela classe que utiliza
//// Interface não pode ser instanciada, mas uma clsse pode implementar diversas interfaces

//ContaPoupanca contaPoupanca = new ContaPoupanca(111, 0);
//contaPoupanca.Deposita(100);
//contaPoupanca.Saca(10);
//double saldoPoupanca = contaPoupanca.ConsultaSaldoDisponivel();

//Console.WriteLine("Saldo da poupança é: " + saldoPoupanca);

//ContaCorrente contaCorrente = new ContaCorrente(111, 100);
//contaCorrente.Deposita(100);
//contaCorrente.Saca(50);
//double saldoCorrente = contaCorrente.ConsultaSaldoDisponivel();

//Console.WriteLine("Saldo da conta corrente é: " + saldoCorrente);


