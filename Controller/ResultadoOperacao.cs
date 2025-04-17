using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auxiliar.Controller
{
    public class ResultadoOperacao<T>
    {
        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
        public T Dados { get; set; }

        public ResultadoOperacao(bool sucesso, string mensagem, T dados = default)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
            Dados = dados;
        }
    }
}
