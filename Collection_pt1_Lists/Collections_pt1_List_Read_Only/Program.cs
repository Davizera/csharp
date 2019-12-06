using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_pt1_List_Read_Only
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso cSharpCollections = new Curso("C# Collections", "Marcelo Oliveira");

            cSharpCollections.AddClass(new Aula("Tabalhando com Listas", 30));
            cSharpCollections.AddClass(new Aula("Criando uma aula", 15));
            cSharpCollections.AddClass(new Aula("Modelando com collection", 45));


            //Print(cSharpCollections.Aulas);

            Console.WriteLine(cSharpCollections);

            Console.WriteLine();
            Console.ReadLine();
        }

        private static void Print(IList<Aula> aulas)
        {
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }
}
