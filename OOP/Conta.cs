using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class Conta : IConta //implementação pode ter várias, diferente de herança
    {
        //public Conta(int numero)
        //{
        //    this.Numero = numero;
        //}

        public Conta(int numero, double limite)
        {
            this.Numero = numero;
            this.Limite = limite;
            Conta.TotalContasCriadas++;
        }

        protected double Saldo { get; set; } //private = modificador de acesso
        public double Limite { get; private set; }
        public int Numero { get; private set; }
        public static int TotalContasCriadas { get; set; } //atributo estático

        public static int ProximoTotalContasCriadas()
        {
            return Conta.TotalContasCriadas + 1;
        }

        public void Deposita(double valor) //void = método sem retorno
        {
            this.Saldo += valor; //incrementa o valor na propriedade Saldo
        }

        public virtual bool Saca(double valor)
        {
            double saldoDisponivel = this.ConsultaSaldoDisponivel();

            if(valor > saldoDisponivel)
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            } 

            this.Saldo -= valor;
            return true;
        } //virtual permite que seja sobrescrito

        public void AdicionarLimite(double valor)
        {
            this.Limite = valor; //atualiza o limite, não incrementa
        }

        public double ConsultaSaldoDisponivel()
        {
            return this.Saldo + this.Limite;
        }
    }
}
