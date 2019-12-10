using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_pt1_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var navegador = new Navegador();

            navegador.NavegarPara("www.google.com");
            navegador.NavegarPara("www.caelum.com.br");
            navegador.NavegarPara("www.alura.com.br");

            Console.WriteLine();
            Console.WriteLine("Voltando páginas!");

            navegador.Anterior();
            navegador.Anterior();
            navegador.Anterior();

            Console.WriteLine();
            Console.WriteLine("Próxima página!");

            navegador.Proximo();
            navegador.Proximo();
            navegador.Proximo();
            navegador.Proximo();


            Console.WriteLine();
            Console.WriteLine("Indo e voltando de página!");

            navegador.Anterior();
            navegador.Proximo();
            navegador.Anterior();
            navegador.Proximo();
            navegador.Anterior();
            navegador.Anterior();

            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para sair da aplicação . . .");
            Console.ReadLine();
        }
    }
}
