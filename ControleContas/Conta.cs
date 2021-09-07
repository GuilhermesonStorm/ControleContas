using System.Collections.Generic;
using System.Text;

namespace aulasPOO
{
    public class Conta
    {
        // private decimal _saldo;

        public int Numero { get; private set; }

        public decimal Saldo { get; private set; }

        public Cliente Titular { get; private set; }

        public Conta(int numero)
        {
            if(numero < 999)
            { 
                throw new System.ArgumentException("O numero da conta deve ser superior a 999.");
            }
            Numero = numero;
        }
        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public bool Sacar(decimal valor)
        {
            if (Saldo - valor < 0)
            {
                return false;
            }
            Saldo -= valor;
            return true;
        }

        public bool Transferir(Conta destino, decimal valor)
        { 
            if(Sacar(valor))
            {
                destino.Depositar(valor);
                return true;
            }
            return false;
        }
    }
}