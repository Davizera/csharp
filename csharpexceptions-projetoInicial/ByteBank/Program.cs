using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            //Aprendendo Regex em C#
            string teste = "Este aqui é meu telefone 99315-6009";
            string padrao = "9?[0-9]{4}-?[0-9]{4}";
            Match resultado = Regex.Match(teste, padrao);
            Console.WriteLine(resultado);

            Console.ReadLine();

            //Aprendendo mais sobre o Object, "pai" de todas as classes
            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Carlos";
            carlos_1.CPF = "458.623.120-03";
            carlos_1.Profissao = "Designer";

            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Carlos";
            carlos_2.CPF = "458.623.120-03";
            carlos_2.Profissao = "Designer";

            if (carlos_1.Equals(carlos_2))
            {
                Console.WriteLine("São iguais!");
            }

            Console.WriteLine();

            try
            {
                string url = "www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";

                ExtratoDeArgumentoURL extrator = new ExtratoDeArgumentoURL(url);
                Console.WriteLine(extrator.GetValor("moedaOrigem")); // real
                Console.WriteLine(extrator.GetValor("moedaDestino")); // dolar
                Console.WriteLine(extrator.GetValor("valor")); // 1500
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Expception capturada no Main");
            }

            Console.WriteLine("Aperte enter para sair da aplicação. . .");
            Console.ReadLine();
        }

        private static void leitoArquivos()
        {
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("Contas.txt"))
            {
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
            }
        }
        private static void criaContas()
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(123, 456789);
                ContaCorrente conta2 = new ContaCorrente(123, 987654);

                conta.Sacar(10000);

            }
            catch (OperacaoFinanceiraException e)
            {
                Console.Write(e.Message);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write(e.StackTrace);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write("Informações da innerException: ");
                Console.WriteLine(e.InnerException);

            }

            Console.WriteLine("Aperte enter para sair da aplicação . . .");
            Console.ReadLine();
        }
    }
}
