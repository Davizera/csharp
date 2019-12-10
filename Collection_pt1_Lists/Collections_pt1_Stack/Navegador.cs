using System;
using System.Collections.Generic;

namespace Collections_pt1_Stack
{
    public class Navegador
    {
        private readonly Stack<string> historicoAnterior = new Stack<string>();
        private readonly Stack<string> historicoProximo = new Stack<string>();
        private string atual = "vazia";
        public Navegador()
        {
            System.Console.WriteLine($"Página atual: {atual}");
        }

        public void NavegarPara(string url)
        {
            historicoAnterior.Push(atual);
            atual = url;
            System.Console.WriteLine($"Página atual: {atual}");

        }

        public void Anterior()
        {
            if (historicoAnterior.Count != 0)
            {
                historicoProximo.Push(atual);
                atual = historicoAnterior.Pop();
                System.Console.WriteLine($"Página atual: {atual}");
            }

        }

        public void Proximo()
        {
            if (historicoProximo.Count != 0)
            {
                historicoAnterior.Push(atual);
                atual = historicoProximo.Pop();
                System.Console.WriteLine($"Página atual: {atual}");
            }
        }
    }
}