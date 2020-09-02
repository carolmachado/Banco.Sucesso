using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BEM VINDO ao BANCO SUCESSO!");

            
           

            
             NomesDeClientesComuns nomesDeClientesComuns = null;
            nomesDeClientesComuns = new NomesDeClientesComuns();

            nomesDeClientesComuns.Cliente = new Cliente();
            nomesDeClientesComuns.Cliente.Nome = "";

            ClientesPremium clientesPremium = new ClientesPremium();
            clientesPremium.Cliente = new Cliente();

            clientesPremium.Cliente.Nome = "";


            SaldoDeClientesComuns mariaSilva = new SaldoDeClientesComuns();
            SaldoDeClientesComuns josePereira = new SaldoDeClientesComuns();
            SaldoDeClientesComuns rensto = new SaldoDeClientesComuns();
            mariaSilva.Depositar(200);
            josePereira.Depositar(300);
            rensto.Depositar(500);
            Console.WriteLine("mariaSilva.Saldo");


            Console.WriteLine("Saldo do José Pereira:  " + mariaSilva.ObterSaldo());
            Console.WriteLine("Saldo da maria Silva :  " + josePereira.ObterSaldo());

            bool resultadoTranferencia = josePereira.Transferir(100, mariaSilva);

            

            Console.WriteLine("Saldo do José Pereira:  " + josePereira.ObterSaldo());
            Console.WriteLine("Saldo da maria Silva :  " + mariaSilva.ObterSaldo());

            Console.WriteLine("Resultado da Transferência: " + resultadoTranferencia);

            mariaSilva.Transferir(50, josePereira);
            Console.WriteLine("Saldo do José Pereira:  " + josePereira.ObterSaldo());
            Console.WriteLine("Saldo da maria Silva :  " + mariaSilva.ObterSaldo());


            ClientesPremium nome = new ClientesPremium();

            ClientesPremium Saldos = new ClientesPremium();

            Cliente emmanuelMachado = new Cliente();
            emmanuelMachado.Celular = "98204-3464";
            emmanuelMachado.DataDeNascimento = new DateTime(1987, 8, 9);
            emmanuelMachado.Documento = "234.543.234-68";

            SaldoDeClientesComuns conta = new SaldoDeClientesComuns();

            conta.DefinirSaldo(-10);

            Console.WriteLine(conta.ObterSaldo());

            







            Console.WriteLine("Aperte qualquer tecla para fechar.");
            Console.ReadKey();
        }
    }
}
