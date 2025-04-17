namespace Auxiliar.View
{
    partial class FrmAjuda
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
            SuspendLayout();
            // 
            // BtnAjuda
            // 
            BtnAjuda.FlatAppearance.BorderSize = 0;
            BtnAjuda.Location = new Point(610, 12);
            BtnAjuda.Raio.All = 20;
            BtnAjuda.Raio.BaixoDireito = 20;
            BtnAjuda.Raio.BaixoEsquerdo = 20;
            BtnAjuda.Raio.TopoDireito = 20;
            BtnAjuda.Raio.TopoEsquerdo = 20;
            // 
            // FrmAjuda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "FrmAjuda";
            Text = "FrmAjuda";
            Load += FrmAjuda_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}