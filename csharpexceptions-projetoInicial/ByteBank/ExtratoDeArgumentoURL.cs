using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class ExtratoDeArgumentoURL
    {
        private readonly string _argumentos;
        public string URL { get; }

        public ExtratoDeArgumentoURL(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento url não pode ser vazio ou nulo.", nameof(url));
            }

            int indexOfQuestionMark = url.IndexOf('?');
            _argumentos = url.Substring(indexOfQuestionMark + 1);

            URL = url;
        }

        public string GetValor(string nomeParamentro)
        {
            //_argumentos = moedaOrigem=real&moedaDestino=dolar&valor=1500;
            string upperArgumentos = _argumentos.ToUpper();

            string termo = nomeParamentro.ToUpper() + '=';
            int indexOfTermo = upperArgumentos.IndexOf(termo);

            string resultado = _argumentos.Substring(indexOfTermo + termo.Length);
            int indexOfAnd = resultado.IndexOf('&');
            if (indexOfAnd == -1)
            {
                return resultado;
            }
            return resultado.Remove(indexOfAnd);
        }
    }
}
