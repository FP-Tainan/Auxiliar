namespace Auxiliar.View
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            PnlMenuBar = new OrcusUI.Conteiners.PainelArredondado();
            BtnScriptsSQL = new OrcusUI.Controles.BotaoArredondado();
            BtnImplantacoes = new OrcusUI.Controles.BotaoArredondado();
            BtnInstaladores = new OrcusUI.Controles.BotaoArredondado();
            BtnIntranet = new OrcusUI.Controles.BotaoArredondado();
            PnlCentral = new OrcusUI.Conteiners.PainelArredondado();
            PnlMenuBar.SuspendLayout();
            SuspendLayout();
            // 
            // BtnAjuda
            // 
            BtnAjuda.FlatAppearance.BorderSize = 0;
            BtnAjuda.Location = new Point(1672, 12);
            BtnAjuda.Raio.All = 20;
            BtnAjuda.Raio.BaixoDireito = 20;
            BtnAjuda.Raio.BaixoEsquerdo = 20;
            BtnAjuda.Raio.TopoDireito = 20;
            BtnAjuda.Raio.TopoEsquerdo = 20;
            // 
            // PnlMenuBar
            // 
            PnlMenuBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            PnlMenuBar.Controls.Add(BtnScriptsSQL);
            PnlMenuBar.Controls.Add(BtnImplantacoes);
            PnlMenuBar.Controls.Add(BtnInstaladores);
            PnlMenuBar.Controls.Add(BtnIntranet);
            PnlMenuBar.CorDeFundo = Color.FromArgb(224, 204, 255);
            PnlMenuBar.Location = new Point(12, 85);
            PnlMenuBar.Name = "PnlMenuBar";
            PnlMenuBar.Raio.All = 20;
            PnlMenuBar.Raio.BaixoDireito = 20;
            PnlMenuBar.Raio.BaixoEsquerdo = 20;
            PnlMenuBar.Raio.TopoDireito = 20;
            PnlMenuBar.Raio.TopoEsquerdo = 20;
            PnlMenuBar.Size = new Size(173, 589);
            PnlMenuBar.TabIndex = 1;
            // 
            // BtnScriptsSQL
            // 
            BtnScriptsSQL.BackColor = Color.WhiteSmoke;
            BtnScriptsSQL.CorDaBorda = Color.Black;
            BtnScriptsSQL.CorSobreposicao = Color.Transparent;
            BtnScriptsSQL.EspessuraDaBorda = 1;
            BtnScriptsSQL.FlatAppearance.BorderSize = 0;
            BtnScriptsSQL.FlatStyle = FlatStyle.Flat;
            BtnScriptsSQL.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnScriptsSQL.Icone = "seguranca_32";
            BtnScriptsSQL.Image = (Image)resources.GetObject("BtnScriptsSQL.Image");
            BtnScriptsSQL.ImageAlign = ContentAlignment.TopLeft;
            BtnScriptsSQL.Location = new Point(7, 228);
            BtnScriptsSQL.Name = "BtnScriptsSQL";
            BtnScriptsSQL.Raio.All = 20;
            BtnScriptsSQL.Raio.BaixoDireito = 20;
            BtnScriptsSQL.Raio.BaixoEsquerdo = 20;
            BtnScriptsSQL.Raio.TopoDireito = 20;
            BtnScriptsSQL.Raio.TopoEsquerdo = 20;
            BtnScriptsSQL.Size = new Size(158, 64);
            BtnScriptsSQL.TabIndex = 5;
            BtnScriptsSQL.Text = "Manutenção Banco De Dados";
            BtnScriptsSQL.TextAlign = ContentAlignment.MiddleRight;
            BtnScriptsSQL.UseVisualStyleBackColor = false;
            // 
            // BtnImplantacoes
            // 
            BtnImplantacoes.BackColor = Color.WhiteSmoke;
            BtnImplantacoes.CorDaBorda = Color.Black;
            BtnImplantacoes.CorSobreposicao = Color.Transparent;
            BtnImplantacoes.EspessuraDaBorda = 1;
            BtnImplantacoes.FlatAppearance.BorderSize = 0;
            BtnImplantacoes.FlatStyle = FlatStyle.Flat;
            BtnImplantacoes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnImplantacoes.Icone = "gestao_32";
            BtnImplantacoes.Image = (Image)resources.GetObject("BtnImplantacoes.Image");
            BtnImplantacoes.ImageAlign = ContentAlignment.MiddleLeft;
            BtnImplantacoes.Location = new Point(7, 158);
            BtnImplantacoes.Name = "BtnImplantacoes";
            BtnImplantacoes.Raio.All = 20;
            BtnImplantacoes.Raio.BaixoDireito = 20;
            BtnImplantacoes.Raio.BaixoEsquerdo = 20;
            BtnImplantacoes.Raio.TopoDireito = 20;
            BtnImplantacoes.Raio.TopoEsquerdo = 20;
            BtnImplantacoes.Size = new Size(158, 64);
            BtnImplantacoes.TabIndex = 4;
            BtnImplantacoes.Text = "Implantações";
            BtnImplantacoes.TextAlign = ContentAlignment.MiddleRight;
            BtnImplantacoes.UseVisualStyleBackColor = false;
            // 
            // BtnInstaladores
            // 
            BtnInstaladores.BackColor = Color.WhiteSmoke;
            BtnInstaladores.CorDaBorda = Color.Black;
            BtnInstaladores.CorSobreposicao = Color.Transparent;
            BtnInstaladores.EspessuraDaBorda = 1;
            BtnInstaladores.FlatAppearance.BorderSize = 0;
            BtnInstaladores.FlatStyle = FlatStyle.Flat;
            BtnInstaladores.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnInstaladores.Icone = "quebra_cabeca_32";
            BtnInstaladores.Image = (Image)resources.GetObject("BtnInstaladores.Image");
            BtnInstaladores.ImageAlign = ContentAlignment.MiddleLeft;
            BtnInstaladores.Location = new Point(7, 88);
            BtnInstaladores.Name = "BtnInstaladores";
            BtnInstaladores.Raio.All = 20;
            BtnInstaladores.Raio.BaixoDireito = 20;
            BtnInstaladores.Raio.BaixoEsquerdo = 20;
            BtnInstaladores.Raio.TopoDireito = 20;
            BtnInstaladores.Raio.TopoEsquerdo = 20;
            BtnInstaladores.Size = new Size(158, 64);
            BtnInstaladores.TabIndex = 3;
            BtnInstaladores.Text = "Instaladores";
            BtnInstaladores.TextAlign = ContentAlignment.MiddleRight;
            BtnInstaladores.UseVisualStyleBackColor = false;
            // 
            // BtnIntranet
            // 
            BtnIntranet.BackColor = Color.WhiteSmoke;
            BtnIntranet.CorDaBorda = Color.Black;
            BtnIntranet.CorSobreposicao = Color.Transparent;
            BtnIntranet.EspessuraDaBorda = 1;
            BtnIntranet.FlatAppearance.BorderSize = 0;
            BtnIntranet.FlatStyle = FlatStyle.Flat;
            BtnIntranet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnIntranet.Icone = "diagrama_32";
            BtnIntranet.Image = (Image)resources.GetObject("BtnIntranet.Image");
            BtnIntranet.ImageAlign = ContentAlignment.MiddleLeft;
            BtnIntranet.Location = new Point(7, 18);
            BtnIntranet.Name = "BtnIntranet";
            BtnIntranet.Raio.All = 20;
            BtnIntranet.Raio.BaixoDireito = 20;
            BtnIntranet.Raio.BaixoEsquerdo = 20;
            BtnIntranet.Raio.TopoDireito = 20;
            BtnIntranet.Raio.TopoEsquerdo = 20;
            BtnIntranet.Size = new Size(158, 64);
            BtnIntranet.TabIndex = 2;
            BtnIntranet.Text = "Intranet";
            BtnIntranet.TextAlign = ContentAlignment.MiddleRight;
            BtnIntranet.UseVisualStyleBackColor = false;
            BtnIntranet.Click += BtnIntranet_Click;
            // 
            // PnlCentral
            // 
            PnlCentral.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PnlCentral.CorDeFundo = Color.FromArgb(224, 204, 255);
            PnlCentral.Location = new Point(208, 85);
            PnlCentral.Name = "PnlCentral";
            PnlCentral.Raio.All = 20;
            PnlCentral.Raio.BaixoDireito = 20;
            PnlCentral.Raio.BaixoEsquerdo = 20;
            PnlCentral.Raio.TopoDireito = 20;
            PnlCentral.Raio.TopoEsquerdo = 20;
            PnlCentral.Size = new Size(666, 589);
            PnlCentral.TabIndex = 2;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            Controls.Add(PnlCentral);
            Controls.Add(PnlMenuBar);
            Name = "FrmMenu";
            Text = "FrmMenu";
            Load += FrmMenu_Load;
            Controls.SetChildIndex(PnlMenuBar, 0);
            Controls.SetChildIndex(PnlCentral, 0);
            PnlMenuBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private OrcusUI.Conteiners.PainelArredondado PnlMenuBar;
        private OrcusUI.Controles.BotaoArredondado BtnIntranet;
        private OrcusUI.Conteiners.PainelArredondado PnlCentral;
        private OrcusUI.Controles.BotaoArredondado BtnInstaladores;
        private OrcusUI.Controles.BotaoArredondado BtnScriptsSQL;
        private OrcusUI.Controles.BotaoArredondado BtnImplantacoes;
    }
}