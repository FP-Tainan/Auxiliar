using Auxiliar.Controller;
using Auxiliar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auxiliar.Service
{
    public class IntranetService
    {
        public ResultadoOperacao<object> RegistrarCredenciais(IntranetInfo info)
        {
            if (string.IsNullOrWhiteSpace(info.IP))
                return new ResultadoOperacao<object>(false, "O campo IP é obrigatório.");

            if (string.IsNullOrWhiteSpace(info.Usuario))
                return new ResultadoOperacao<object>(false, "O campo Usuário é obrigatório.");

            if (string.IsNullOrWhiteSpace(info.Senha))
                return new ResultadoOperacao<object>(false, "O campo Senha é obrigatório.");

            return Intranet.RegistrarCredenciais(info.IP, info.Usuario, info.Senha);
        }

        public ResultadoOperacao<List<string>> ListarPastasCompartilhadas(string ip)
        {
            if (string.IsNullOrWhiteSpace(ip))
                return new ResultadoOperacao<List<string>>(false, "O campo IP é obrigatório.");

            return Intranet.ListarPastasCompartilhadas(ip);
        }

        public ResultadoOperacao<object> MapearPasta(string ip, string pasta, string letra)
        {
            if (string.IsNullOrWhiteSpace(ip))
                return new ResultadoOperacao<object>(false, "O campo IP é obrigatório.");

            if (string.IsNullOrWhiteSpace(pasta))
                return new ResultadoOperacao<object>(false, "Você precisa selecionar uma pasta compartilhada.");

            if (string.IsNullOrWhiteSpace(letra))
                return new ResultadoOperacao<object>(false, "Você precisa selecionar a letra da unidade.");

            return Intranet.MapearPasta(ip, pasta, letra);
        }

        public ResultadoOperacao<object> ValidarCredenciais(IntranetInfo info)
        {
            if (string.IsNullOrWhiteSpace(info.IP))
                return new ResultadoOperacao<object>(false, "O campo IP é obrigatório.");

            if (string.IsNullOrWhiteSpace(info.Usuario))
                return new ResultadoOperacao<object>(false, "O campo Usuário é obrigatório.");

            if (string.IsNullOrWhiteSpace(info.Senha))
                return new ResultadoOperacao<object>(false, "O campo Senha é obrigatório.");

            return Intranet.ValidarCredenciaisIntranet(info.IP, info.Usuario, info.Senha);
        }

        public ResultadoOperacao<List<string>> ObterLetrasLivres()
        {
            var letras = Intranet.ObterLetrasDisponiveis();
            return new ResultadoOperacao<List<string>>(true, "Letras disponíveis carregadas.", letras);
        }
    }
}
