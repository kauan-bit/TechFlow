using System.Windows.Forms;
using System.Drawing;

namespace TechFlow
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblSaudacao = new System.Windows.Forms.Label();
            this.flowMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.cardUsuarios = new System.Windows.Forms.Panel();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.cardTecnicos = new System.Windows.Forms.Panel();
            this.lblTecnicos = new System.Windows.Forms.Label();
            this.cardSetores = new System.Windows.Forms.Panel();
            this.lblSetores = new System.Windows.Forms.Label();
            this.cardCategorias = new System.Windows.Forms.Panel();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.cardRelatorios = new System.Windows.Forms.Panel();
            this.lblRelatorios = new System.Windows.Forms.Label();
            this.cardAuditoria = new System.Windows.Forms.Panel();
            this.lblAuditoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.flowMenu.SuspendLayout();
            this.cardUsuarios.SuspendLayout();
            this.cardTecnicos.SuspendLayout();
            this.cardSetores.SuspendLayout();
            this.cardCategorias.SuspendLayout();
            this.cardRelatorios.SuspendLayout();
            this.cardAuditoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(67, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(510, 90);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblSaudacao
            // 
            this.lblSaudacao.AutoSize = true;
            this.lblSaudacao.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSaudacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblSaudacao.Location = new System.Drawing.Point(20, 120);
            this.lblSaudacao.Name = "lblSaudacao";
            this.lblSaudacao.Size = new System.Drawing.Size(116, 25);
            this.lblSaudacao.TabIndex = 1;
            this.lblSaudacao.Text = "Bem-vindo!";
            // 
            // flowMenu
            // 
            this.flowMenu.AutoScroll = true;
            this.flowMenu.Controls.Add(this.cardUsuarios);
            this.flowMenu.Controls.Add(this.cardTecnicos);
            this.flowMenu.Controls.Add(this.cardSetores);
            this.flowMenu.Controls.Add(this.cardCategorias);
            this.flowMenu.Controls.Add(this.cardRelatorios);
            this.flowMenu.Controls.Add(this.cardAuditoria);
            this.flowMenu.Location = new System.Drawing.Point(20, 160);
            this.flowMenu.Name = "flowMenu";
            this.flowMenu.Size = new System.Drawing.Size(600, 520);
            this.flowMenu.TabIndex = 2;
            // 
            // cardUsuarios
            // 
            this.cardUsuarios.Controls.Add(this.lblUsuarios);
            this.cardUsuarios.Location = new System.Drawing.Point(3, 3);
            this.cardUsuarios.Name = "cardUsuarios";
            this.cardUsuarios.Size = new System.Drawing.Size(200, 100);
            this.cardUsuarios.TabIndex = 0;
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.Location = new System.Drawing.Point(0, 0);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(100, 23);
            this.lblUsuarios.TabIndex = 0;
            // 
            // cardTecnicos
            // 
            this.cardTecnicos.Controls.Add(this.lblTecnicos);
            this.cardTecnicos.Location = new System.Drawing.Point(209, 3);
            this.cardTecnicos.Name = "cardTecnicos";
            this.cardTecnicos.Size = new System.Drawing.Size(200, 100);
            this.cardTecnicos.TabIndex = 1;
            // 
            // lblTecnicos
            // 
            this.lblTecnicos.Location = new System.Drawing.Point(0, 0);
            this.lblTecnicos.Name = "lblTecnicos";
            this.lblTecnicos.Size = new System.Drawing.Size(100, 23);
            this.lblTecnicos.TabIndex = 0;
            // 
            // cardSetores
            // 
            this.cardSetores.Controls.Add(this.lblSetores);
            this.cardSetores.Location = new System.Drawing.Point(3, 109);
            this.cardSetores.Name = "cardSetores";
            this.cardSetores.Size = new System.Drawing.Size(200, 100);
            this.cardSetores.TabIndex = 2;
            // 
            // lblSetores
            // 
            this.lblSetores.Location = new System.Drawing.Point(0, 0);
            this.lblSetores.Name = "lblSetores";
            this.lblSetores.Size = new System.Drawing.Size(100, 23);
            this.lblSetores.TabIndex = 0;
            // 
            // cardCategorias
            // 
            this.cardCategorias.Controls.Add(this.lblCategorias);
            this.cardCategorias.Location = new System.Drawing.Point(209, 109);
            this.cardCategorias.Name = "cardCategorias";
            this.cardCategorias.Size = new System.Drawing.Size(200, 100);
            this.cardCategorias.TabIndex = 3;
            // 
            // lblCategorias
            // 
            this.lblCategorias.Location = new System.Drawing.Point(0, 0);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(100, 23);
            this.lblCategorias.TabIndex = 0;
            // 
            // cardRelatorios
            // 
            this.cardRelatorios.Controls.Add(this.lblRelatorios);
            this.cardRelatorios.Location = new System.Drawing.Point(3, 215);
            this.cardRelatorios.Name = "cardRelatorios";
            this.cardRelatorios.Size = new System.Drawing.Size(200, 100);
            this.cardRelatorios.TabIndex = 4;
            // 
            // lblRelatorios
            // 
            this.lblRelatorios.Location = new System.Drawing.Point(0, 0);
            this.lblRelatorios.Name = "lblRelatorios";
            this.lblRelatorios.Size = new System.Drawing.Size(100, 23);
            this.lblRelatorios.TabIndex = 0;
            // 
            // cardAuditoria
            // 
            this.cardAuditoria.Controls.Add(this.lblAuditoria);
            this.cardAuditoria.Location = new System.Drawing.Point(209, 215);
            this.cardAuditoria.Name = "cardAuditoria";
            this.cardAuditoria.Size = new System.Drawing.Size(200, 100);
            this.cardAuditoria.TabIndex = 5;
            // 
            // lblAuditoria
            // 
            this.lblAuditoria.Location = new System.Drawing.Point(0, 0);
            this.lblAuditoria.Name = "lblAuditoria";
            this.lblAuditoria.Size = new System.Drawing.Size(100, 23);
            this.lblAuditoria.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(650, 720);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblSaudacao);
            this.Controls.Add(this.flowMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard - TechFlow";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.flowMenu.ResumeLayout(false);
            this.cardUsuarios.ResumeLayout(false);
            this.cardTecnicos.ResumeLayout(false);
            this.cardSetores.ResumeLayout(false);
            this.cardCategorias.ResumeLayout(false);
            this.cardRelatorios.ResumeLayout(false);
            this.cardAuditoria.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picLogo;
        private Label lblSaudacao;
        private FlowLayoutPanel flowMenu;

        private Panel cardUsuarios;
        private Panel cardTecnicos;
        private Panel cardSetores;
        private Panel cardCategorias;
        private Panel cardRelatorios;
        private Panel cardAuditoria;

        private Label lblUsuarios;
        private Label lblTecnicos;
        private Label lblSetores;
        private Label lblCategorias;
        private Label lblRelatorios;
        private Label lblAuditoria;
    }
}
