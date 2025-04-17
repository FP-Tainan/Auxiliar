using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Auxiliar.Controller
{
    public static class Intranet
    {
        public static ResultadoOperacao<object> RegistrarCredenciais(string ip, string usuario, string senha)
        {
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = "cmdkey.exe",
                    Arguments = $"/add:{ip} /user:{usuario} /pass:{senha}",
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                };

                using (var process = Process.Start(psi))
                {
                    string erro = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    if (process.ExitCode == 0)
                        return new ResultadoOperacao<object>(true, "Credenciais de Intranet registradas com sucesso!");

                    return new ResultadoOperacao<object>(false, $"Erro ao registrar credenciais: {erro.Trim()}");
                }
            }
            catch (Exception ex)
            {
                return new ResultadoOperacao<object>(false, $"Exceção: {ex.Message}");
            }
        }


        public static ResultadoOperacao<List<string>> ListarPastasCompartilhadas(string ip)
        {
            try
            {
                var pastas = new List<string>();
                var psi = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c net view \\\\{ip}",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var process = Process.Start(psi))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    string erro = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    if (process.ExitCode != 0)
                        return new ResultadoOperacao<List<string>>(false, $"Erro ao listar pastas: {erro.Trim()}");

                    var regex = new Regex(@"^\s+(\S+)\s+Disk", RegexOptions.Multiline);
                    var matches = regex.Matches(output);

                    foreach (Match match in matches)
                        pastas.Add(match.Groups[1].Value);

                    return new ResultadoOperacao<List<string>>(true, "Pastas compartilhadas listadas com sucesso!", pastas);
                }
            }
            catch (Exception ex)
            {
                return new ResultadoOperacao<List<string>>(false, $"Exceção: {ex.Message}");
            }
        }

        public static ResultadoOperacao<object> MapearPasta(string ip, string pastaCompartilhada, string letraUnidade)
        {
            try
            {
                var desmapear = new ProcessStartInfo("cmd.exe", $"/c net use {letraUnidade}: /delete /y")
                {
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardError = true
                };
                using (var procDesmapear = Process.Start(desmapear))
                {
                    procDesmapear?.WaitForExit(); // Ignoramos erro se não estiver mapeado
                }

                var mapear = new ProcessStartInfo("cmd.exe", $"/c net use {letraUnidade}: \\\\{ip}\\{pastaCompartilhada}")
                {
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardError = true
                };

                using (var procMapear = Process.Start(mapear))
                {
                    string erro = procMapear.StandardError.ReadToEnd();
                    procMapear.WaitForExit();

                    if (procMapear.ExitCode == 0)
                        return new ResultadoOperacao<object>(true, $"Pasta mapeada com sucesso na unidade {letraUnidade}:");

                    return new ResultadoOperacao<object>(false, $"Erro ao mapear pasta: {erro.Trim()}");
                }
            }
            catch (Exception ex)
            {
                return new ResultadoOperacao<object>(false, $"Exceção: {ex.Message}");
            }
        }

        public static ResultadoOperacao<object> ValidarCredenciaisIntranet(string ip, string usuario, string senha)
        {
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c net use \\\\{ip}\\IPC$ /user:{usuario} {senha}",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var process = Process.Start(psi))
                {
                    string erro = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    if (process.ExitCode == 0)
                    {
                        Process.Start(new ProcessStartInfo("cmd.exe", $"/c net use \\\\{ip}\\IPC$ /delete /y")
                        {
                            CreateNoWindow = true,
                            UseShellExecute = false
                        })?.WaitForExit();

                        return new ResultadoOperacao<object>(true, "Credenciais válidas!");
                    }

                    return new ResultadoOperacao<object>(false, $"Credenciais inválidas: {erro.Trim()}");
                }
            }
            catch (Exception ex)
            {
                return new ResultadoOperacao<object>(false, $"Erro ao validar credenciais: {ex.Message}");
            }
        }

        public static List<string> ObterLetrasDisponiveis()
        {
            var todasLetras = Enumerable.Range('D', 26 - 3) // D até Z, ignorando A, B, C por serem letras padrão do windows
                .Select(i => ((char)i).ToString() + ":")
                .ToList();

            var emUso = DriveInfo.GetDrives()
                .Select(d => d.Name.Substring(0, 2).ToUpper())
                .ToList();

            var livres = todasLetras.Except(emUso).ToList();
            return livres;
        }
    }
}
