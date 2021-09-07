using System;

namespace aulasPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada = 0;
            do
            {
                entrada = int.Parse(Console.ReadLine());
                switch (entrada)
                {
                    case 1:
                        string nome, cpf, email;
                        int anoNasc;
                        System.Console.WriteLine("Entre com o nome:");
                        nome = Console.ReadLine();
                        System.Console.WriteLine("Entre com o CPF:");
                        cpf = Console.ReadLine();
                        System.Console.WriteLine("Entre com o Email:");
                        email = Console.ReadLine();
                        System.Console.WriteLine("Entre com o ano do nascimento:");
                        anoNasc = int.Parse(Console.ReadLine());
                        Cliente novoCliente = new Cliente(nome, email, anoNasc, cpf);
                        System.Console.WriteLine($"Cliente cadastrado: Nome: {novoCliente.Nome} Email: {novoCliente.Email} CPF: {novoCliente.CPF} Ano de Nascimento: {novoCliente.AnoNasc} ");

                        break;
                }

            } while (entrada < 0 || entrada > 9);
            // try
            // { 
            //     Conta conta1 = new Conta(654321);
            //     Conta conta2 = new Conta(123456);
            //     Console.WriteLine(conta1.Numero);
            //     System.Console.WriteLine("O saldo inicial da conta é: " + conta1.Saldo);
            //     conta1.Depositar(1000);
            //     System.Console.WriteLine("O saldo da conta após o deposito é: " + conta1.Saldo);
            //     conta1.Sacar(500);
            //     System.Console.WriteLine("O saldo da conta após o saque é " + conta1.Saldo);
            //     conta1.Transferir(conta2, 300);
            //     System.Console.WriteLine($"O saldo da conta {conta1.Numero} após a transferencia é: {conta1.Saldo}");
            //     System.Console.WriteLine($"O saldo da conta {conta2.Numero} após a transferencia é: {conta2.Saldo}");
            // }
            // catch (Exception e)
            // {
            //     System.Console.WriteLine(e.Message);
            // }
        }
    }
}
