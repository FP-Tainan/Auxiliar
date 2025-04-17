using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Auxiliar.Controller;
using Auxiliar.Model;
using Auxiliar.Service;
using OrcusUI;

namespace Auxiliar.View
{
    public partial class FrmIntranet : FrmPadrao
    {
        private readonly IntranetService _service = new IntranetService();

        public FrmIntranet()
        {
            InitializeComponent();
        }

        private void FrmIntranet_Load(object sender, EventArgs e)
        {
            this.AlterarTitulo("Intranet", Color.Black);
            this.AlterarIcone(Icones.diagrama_32);
        }

        private void BtnSalvarCredenciais_Click(object sender, EventArgs e)
        {
            Utilitarios.Aguarde.Mostrar("Registrando...");

            var info = new IntranetInfo
            {
                IP = TxtServidorIP.Text.Trim(),
                Usuario = TxtServidorUsuario.Text.Trim(),
                Senha = TxtServidorSenha.Text
            };

            var validacao = _service.ValidarCredenciais(info);
            if (!validacao.Sucesso)
            {
                Utilitarios.Aguarde.Fechar();
                MessageBox.Show(validacao.Mensagem, "Erro ao validar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtServidorSenha.Focus();
                return;
            }

            var resultado = _service.RegistrarCredenciais(info);
            if (resultado.Sucesso)
            {
                Utilitarios.Aguarde.Fechar();
                MessageBox.Show(resultado.Mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Utilitarios.Aguarde.Fechar();
                MessageBox.Show(resultado.Mensagem, "Erro ao registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            TxtServidorSenha.Focus();
        }

        private void BtnAjuda_Click(object sender, EventArgs e)
        {
            FrmAjuda frm = new FrmAjuda();
            frm.AlterarDados("Intranet");
            frm.ShowDialog();
        }
    }
}
