using System.Collections.Generic;
using System.Text;
using System;

namespace aulasPOO
{
    public class Cliente
    {
        public string Nome { get; private set; }

        public string Email { get; set; }

        public int AnoNasc { get; private set; }

        public string CPF { get; private set; }

        public List<Conta> Contas { get; set; }

    public Cliente(string nome, string email, int anoNasc, string cPF)
    {
        if(Int32.Parse(DateTime.Now.ToString("yyyy")) - anoNasc < 18)
            throw new System.ArgumentException("Cliente deve ser maior de 18 anos.");
        
        if(cPF.Length != 11)
            throw new System.ArgumentException("O CPF deve possuir 11 dígitos.");
        Nome = nome;
        Email = email;
        AnoNasc = anoNasc;
        CPF = cPF;
        
    }
  }
}