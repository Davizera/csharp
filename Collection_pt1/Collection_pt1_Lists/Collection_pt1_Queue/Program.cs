using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_pt1_Queue
{
    class Program
    {
        static Queue<string> pedagio = new Queue<string>();

        static void Main(string[] args)
        {
            string van = "van";

            Enfileirar(van);
            Enfileirar("bmw 535i");
            Enfileirar("kombi");
            Enfileirar("audi tt");
            Enfileirar("porsche 911");
            Desenfileirar();
            Desenfileirar();

            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para sair da aplicação . . .");
            Console.ReadLine();
        }

        private static void Desenfileirar()
        {
            if (pedagio.Count > 0)
            {
                string carro = pedagio.Dequeue();
                Console.WriteLine($"{carro} saiu da fila do pedágio");
                ImprimeFila();
            }

        }

        private static void Enfileirar(string carro)
        {
            pedagio.Enqueue(carro);
            Console.WriteLine($"Entrou na fila do pedágio: {carro}");
            ImprimeFila();
        }

        private static void ImprimeFila()
        {
            Console.WriteLine("Estão na fila do pedágio: ");
            foreach (var veiculo in pedagio)
            {
                Console.WriteLine(veiculo);
            }
            Console.WriteLine();
        }
    }
}
