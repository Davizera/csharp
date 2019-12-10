using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    class SistemaInterno
    {
        public bool Logar(IAutenticavel usuario, string senha)
        {
            bool usuarioAutenticado = usuario.Autenticar(senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Login feito com sucesso. Seja bem-vindo! ");
                return true;
            }
                Console.WriteLine("Senhar incorreta!");
            return false;
        }
    }
}
