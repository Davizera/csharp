using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using _07_ByteBank;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            UsarSistema();
            Console.WriteLine();
            CalcularBonificacao();
            Console.WriteLine("Temos no total " + Funcionario.TotalDeFuncionarios +" funcionários");
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

            Desenvolvedor davi = new Desenvolvedor("072.078.455-70");
            davi.Nome = "Davi";

            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";


            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            GerenteDeConta caio = new GerenteDeConta("159.753.398-04");
            caio.Nome = "Caio";

            Auxiliar richard = new Auxiliar("326.985.628-89");
            richard.Nome = "Richard";

            gerenciador.Registrar(pedro);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(caio);
            gerenciador.Registrar(richard);

            Console.WriteLine("Bonificações do mês: R$" + gerenciador.GetTotalBonificacao());

        }
    }
}
