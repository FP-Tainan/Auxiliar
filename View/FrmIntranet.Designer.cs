namespace Auxiliar.View
{
    partial class FrmIntranet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIntranet));
            PnlCentral = new OrcusUI.Conteiners.PainelArredondado();
            PnlDadosServidor = new OrcusUI.Conteiners.PainelArredondado();
            BtnSalvarCredenciais = new OrcusUI.Controles.BotaoArredondado();
            TxtServidorSenha = new OrcusUI.Textos.TextBoxArredondado();
            TxtServidorUsuario = new OrcusUI.Textos.TextBoxArredondado();
            LblSenhaUsuarioRede = new Label();
            LblUsuarioRede = new Label();
            LblServidorMaquinaIP = new Label();
            TxtServidorIP = new OrcusUI.Textos.TextBoxArredondado();
            PnlCentral.SuspendLayout();
            PnlDadosServidor.SuspendLayout();
            SuspendLayout();
            // 
            // BtnAjuda
            // 
            BtnAjuda.FlatAppearance.BorderSize = 0;
            BtnAjuda.Raio.All = 20;
            BtnAjuda.Raio.BaixoDireito = 20;
            BtnAjuda.Raio.BaixoEsquerdo = 20;
            BtnAjuda.Raio.TopoDireito = 20;
            BtnAjuda.Raio.TopoEsquerdo = 20;
            BtnAjuda.Click += BtnAjuda_Click;
            // 
            // PnlCentral
            // 
            PnlCentral.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PnlCentral.Controls.Add(PnlDadosServidor);
            PnlCentral.CorDeFundo = Color.FromArgb(224, 204, 255);
            PnlCentral.Location = new Point(22, 77);
            PnlCentral.Name = "PnlCentral";
            PnlCentral.Raio.All = 20;
            PnlCentral.Raio.BaixoDireito = 20;
            PnlCentral.Raio.BaixoEsquerdo = 20;
            PnlCentral.Raio.TopoDireito = 20;
            PnlCentral.Raio.TopoEsquerdo = 20;
            PnlCentral.Size = new Size(851, 601);
            PnlCentral.TabIndex = 3;
            // 
            // PnlDadosServidor
            // 
            PnlDadosServidor.Controls.Add(BtnSalvarCredenciais);
            PnlDadosServidor.Controls.Add(TxtServidorSenha);
            PnlDadosServidor.Controls.Add(TxtServidorUsuario);
            PnlDadosServidor.Controls.Add(LblSenhaUsuarioRede);
            PnlDadosServidor.Controls.Add(LblUsuarioRede);
            PnlDadosServidor.Controls.Add(LblServidorMaquinaIP);
            PnlDadosServidor.Controls.Add(TxtServidorIP);
            PnlDadosServidor.CorDeFundo = Color.White;
            PnlDadosServidor.Location = new Point(18, 16);
            PnlDadosServidor.Name = "PnlDadosServidor";
            PnlDadosServidor.Raio.All = 25;
            PnlDadosServidor.Raio.BaixoDireito = 25;
            PnlDadosServidor.Raio.BaixoEsquerdo = 25;
            PnlDadosServidor.Raio.TopoDireito = 25;
            PnlDadosServidor.Raio.TopoEsquerdo = 25;
            PnlDadosServidor.Size = new Size(292, 298);
            PnlDadosServidor.TabIndex = 1;
            // 
            // BtnSalvarCredenciais
            // 
            BtnSalvarCredenciais.BackColor = Color.WhiteSmoke;
            BtnSalvarCredenciais.CorDaBorda = Color.Black;
            BtnSalvarCredenciais.CorSobreposicao = Color.Transparent;
            BtnSalvarCredenciais.EspessuraDaBorda = 1;
            BtnSalvarCredenciais.FlatAppearance.BorderSize = 0;
            BtnSalvarCredenciais.FlatStyle = FlatStyle.Flat;
            BtnSalvarCredenciais.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalvarCredenciais.Icone = "Salvar_32";
            BtnSalvarCredenciais.Image = (Image)resources.GetObject("BtnSalvarCredenciais.Image");
            BtnSalvarCredenciais.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSalvarCredenciais.Location = new Point(46, 218);
            BtnSalvarCredenciais.Name = "BtnSalvarCredenciais";
            BtnSalvarCredenciais.Raio.All = 20;
            BtnSalvarCredenciais.Raio.BaixoDireito = 20;
            BtnSalvarCredenciais.Raio.BaixoEsquerdo = 20;
            BtnSalvarCredenciais.Raio.TopoDireito = 20;
            BtnSalvarCredenciais.Raio.TopoEsquerdo = 20;
            BtnSalvarCredenciais.Size = new Size(200, 64);
            BtnSalvarCredenciais.TabIndex = 3;
            BtnSalvarCredenciais.Text = "Salvar Credênciais";
            BtnSalvarCredenciais.TextAlign = ContentAlignment.MiddleRight;
            BtnSalvarCredenciais.UseVisualStyleBackColor = false;
            BtnSalvarCredenciais.Click += BtnSalvarCredenciais_Click;
            // 
            // TxtServidorSenha
            // 
            TxtServidorSenha.BackColor = Color.Transparent;
            TxtServidorSenha.CorDaBorda = Color.Black;
            TxtServidorSenha.CorDeFundo = Color.White;
            TxtServidorSenha.CorDoTexto = Color.Black;
            TxtServidorSenha.EspessuraDaBorda = 1;
            TxtServidorSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtServidorSenha.Leitura = false;
            TxtServidorSenha.Location = new Point(17, 169);
            TxtServidorSenha.MultiLinhas = false;
            TxtServidorSenha.Name = "TxtServidorSenha";
            TxtServidorSenha.Padding = new Padding(10, 5, 10, 10);
            TxtServidorSenha.Raio.All = 20;
            TxtServidorSenha.Raio.BaixoDireito = 20;
            TxtServidorSenha.Raio.BaixoEsquerdo = 20;
            TxtServidorSenha.Raio.TopoDireito = 20;
            TxtServidorSenha.Raio.TopoEsquerdo = 20;
            TxtServidorSenha.ScrollVertical = false;
            TxtServidorSenha.Senha = false;
            TxtServidorSenha.Size = new Size(255, 37);
            TxtServidorSenha.TabIndex = 2;
            TxtServidorSenha.Texto = "";
            // 
            // TxtServidorUsuario
            // 
            TxtServidorUsuario.BackColor = Color.Transparent;
            TxtServidorUsuario.CorDaBorda = Color.Black;
            TxtServidorUsuario.CorDeFundo = Color.White;
            TxtServidorUsuario.CorDoTexto = Color.Black;
            TxtServidorUsuario.EspessuraDaBorda = 1;
            TxtServidorUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtServidorUsuario.Leitura = false;
            TxtServidorUsuario.Location = new Point(17, 102);
            TxtServidorUsuario.MultiLinhas = false;
            TxtServidorUsuario.Name = "TxtServidorUsuario";
            TxtServidorUsuario.Padding = new Padding(10, 5, 10, 10);
            TxtServidorUsuario.Raio.All = 20;
            TxtServidorUsuario.Raio.BaixoDireito = 20;
            TxtServidorUsuario.Raio.BaixoEsquerdo = 20;
            TxtServidorUsuario.Raio.TopoDireito = 20;
            TxtServidorUsuario.Raio.TopoEsquerdo = 20;
            TxtServidorUsuario.ScrollVertical = false;
            TxtServidorUsuario.Senha = false;
            TxtServidorUsuario.Size = new Size(255, 37);
            TxtServidorUsuario.TabIndex = 1;
            TxtServidorUsuario.Texto = "";
            // 
            // LblSenhaUsuarioRede
            // 
            LblSenhaUsuarioRede.AutoSize = true;
            LblSenhaUsuarioRede.Font = new Font("Segoe UI", 12F);
            LblSenhaUsuarioRede.Location = new Point(34, 146);
            LblSenhaUsuarioRede.Name = "LblSenhaUsuarioRede";
            LblSenhaUsuarioRede.Size = new Size(53, 21);
            LblSenhaUsuarioRede.TabIndex = 1;
            LblSenhaUsuarioRede.Text = "Senha";
            // 
            // LblUsuarioRede
            // 
            LblUsuarioRede.AutoSize = true;
            LblUsuarioRede.Font = new Font("Segoe UI", 12F);
            LblUsuarioRede.Location = new Point(34, 78);
            LblUsuarioRede.Name = "LblUsuarioRede";
            LblUsuarioRede.Size = new Size(124, 21);
            LblUsuarioRede.TabIndex = 1;
            LblUsuarioRede.Text = "Usuário de Rede";
            // 
            // LblServidorMaquinaIP
            // 
            LblServidorMaquinaIP.AutoSize = true;
            LblServidorMaquinaIP.Font = new Font("Segoe UI", 12F);
            LblServidorMaquinaIP.Location = new Point(17, 12);
            LblServidorMaquinaIP.Name = "LblServidorMaquinaIP";
            LblServidorMaquinaIP.Size = new Size(255, 21);
            LblServidorMaquinaIP.TabIndex = 1;
            LblServidorMaquinaIP.Text = "IP do Servidor ou Máquina da Rede";
            // 
            // TxtServidorIP
            // 
            TxtServidorIP.BackColor = Color.Transparent;
            TxtServidorIP.CorDaBorda = Color.Black;
            TxtServidorIP.CorDeFundo = Color.White;
            TxtServidorIP.CorDoTexto = Color.Black;
            TxtServidorIP.EspessuraDaBorda = 1;
            TxtServidorIP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtServidorIP.Leitura = false;
            TxtServidorIP.Location = new Point(17, 36);
            TxtServidorIP.MultiLinhas = false;
            TxtServidorIP.Name = "TxtServidorIP";
            TxtServidorIP.Padding = new Padding(10, 6, 10, 10);
            TxtServidorIP.Raio.All = 20;
            TxtServidorIP.Raio.BaixoDireito = 20;
            TxtServidorIP.Raio.BaixoEsquerdo = 20;
            TxtServidorIP.Raio.TopoDireito = 20;
            TxtServidorIP.Raio.TopoEsquerdo = 20;
            TxtServidorIP.ScrollVertical = false;
            TxtServidorIP.Senha = false;
            TxtServidorIP.Size = new Size(255, 37);
            TxtServidorIP.TabIndex = 0;
            TxtServidorIP.Texto = "";
            // 
            // FrmIntranet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            Controls.Add(PnlCentral);
            Name = "FrmIntranet";
            Text = "FrmIntranet";
            Load += FrmIntranet_Load;
            Controls.SetChildIndex(PnlCentral, 0);
            PnlCentral.ResumeLayout(false);
            PnlDadosServidor.ResumeLayout(false);
            PnlDadosServidor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private OrcusUI.Conteiners.PainelArredondado PnlCentral;
        private OrcusUI.Textos.TextBoxArredondado TxtServidorIP;
        private OrcusUI.Conteiners.PainelArredondado PnlDadosServidor;
        private OrcusUI.Textos.TextBoxArredondado TxtServidorSenha;
        private OrcusUI.Textos.TextBoxArredondado TxtServidorUsuario;
        private Label LblSenhaUsuarioRede;
        private Label LblUsuarioRede;
        private Label LblServidorMaquinaIP;
        private OrcusUI.Controles.BotaoArredondado BtnSalvarCredenciais;
    }
}