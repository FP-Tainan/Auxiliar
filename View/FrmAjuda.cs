using OrcusUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auxiliar.View
{
    public partial class FrmAjuda : FrmPadrao
    {
        public FrmAjuda()
        {
            InitializeComponent();
        }

        private void FrmAjuda_Load(object sender, EventArgs e)
        {
            BtnAjuda.Enabled =
            BtnAjuda.Visible = false;
            this.AlterarIcone(Icones.Ajuda_32);
        }

        public void AlterarDados(string titulo)
        {
            string cabecalho = $"Ajuda Integrada - {titulo}";
            this.AlterarTitulo(cabecalho, Color.Black);
        }

    }
}
