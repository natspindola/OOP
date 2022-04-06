using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Conta
    {
        private double Saldo { get; set; } //private = modificador de acesso
        public double Limite { get; private set; }
        public int Numero { get; set; }

        public void Deposita(double valor) //void = método sem retorno
        {
            this.Saldo += valor; //incrementa o valor na propriedade Saldo
        }

        public bool Saca(double valor)
        {
            double saldoDisponivel = this.ConsultaSaldoDisponivel();

            if(valor > saldoDisponivel)
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            } 

            this.Saldo -= valor;
            return true;
        }

        public void adicionarLimite(double valor)
        {
            this.Limite = valor; //atualiza o limite, não incrementa
        }

        public double ConsultaSaldoDisponivel()
        {
            return this.Saldo + this.Limite;
        }
    }
}
