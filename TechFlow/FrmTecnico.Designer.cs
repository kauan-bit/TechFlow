namespace TechFlow
{
    partial class FrmTecnico
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código do Designer
        private void InitializeComponent()
        {
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvTecnicos = new System.Windows.Forms.DataGridView();
            this.pnlForm = new System.Windows.Forms.Panel();

            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();

            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();

            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();

            this.lblEspecialidade = new System.Windows.Forms.Label();
            this.txtEspecialidade = new System.Windows.Forms.TextBox();

            this.lblSetor = new System.Windows.Forms.Label();
            this.txtSetorId = new System.Windows.Forms.TextBox();

            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();

            this.pnlContainer.SuspendLayout();
            this.pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecnicos)).BeginInit();
            this.SuspendLayout();

            // =====================================================
            // FORM PRINCIPAL
            // =====================================================
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#F2F2F2");
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Técnicos";

            // =====================================================
            // PAINEL CONTAINER
            // =====================================================
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContainer.Location = new System.Drawing.Point(20, 20);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContainer.Size = new System.Drawing.Size(860, 610);

            // =====================================================
            // TÍTULO
            // =====================================================
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.ColorTranslator.FromHtml("#333333");
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(290, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gerenciamento de Técnicos";

            // =====================================================
            // GRID
            // =====================================================
            this.dgvTecnicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTecnicos.BackgroundColor = System.Drawing.Color.White;
            this.dgvTecnicos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvTecnicos.Location = new System.Drawing.Point(20, 60);
            this.dgvTecnicos.Name = "dgvTecnicos";
            this.dgvTecnicos.ReadOnly = true;
            this.dgvTecnicos.RowHeadersVisible = false;
            this.dgvTecnicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTecnicos.Size = new System.Drawing.Size(820, 260);
            this.dgvTecnicos.TabIndex = 1;
            this.dgvTecnicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTecnicos_CellClick);

            // =====================================================
            // PAINEL FORM
            // =====================================================
            this.pnlForm.BackColor = System.Drawing.ColorTranslator.FromHtml("#FAFAFA");
            this.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlForm.Location = new System.Drawing.Point(20, 340);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Padding = new System.Windows.Forms.Padding(10);
            this.pnlForm.Size = new System.Drawing.Size(820, 230);

            // =====================================================
            // CAMPOS
            // =====================================================

            // ID
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(20, 25);
            this.lblId.Text = "ID:";

            this.txtId.Location = new System.Drawing.Point(110, 22);
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(120, 20);

            // Nome
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(20, 65);
            this.lblNome.Text = "Nome:";

            this.txtNome.Location = new System.Drawing.Point(110, 62);
            this.txtNome.Size = new System.Drawing.Size(260, 20);

            // Email
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 105);
            this.lblEmail.Text = "Email:";

            this.txtEmail.Location = new System.Drawing.Point(110, 102);
            this.txtEmail.Size = new System.Drawing.Size(260, 20);

            // Especialidade
            this.lblEspecialidade.AutoSize = true;
            this.lblEspecialidade.Location = new System.Drawing.Point(420, 25);
            this.lblEspecialidade.Text = "Especialidade:";

            this.txtEspecialidade.Location = new System.Drawing.Point(500, 22);
            this.txtEspecialidade.Size = new System.Drawing.Size(260, 20);

            // Setor ID
            this.lblSetor.AutoSize = true;
            this.lblSetor.Location = new System.Drawing.Point(420, 65);
            this.lblSetor.Text = "Setor ID:";

            this.txtSetorId.Location = new System.Drawing.Point(500, 62);
            this.txtSetorId.Size = new System.Drawing.Size(80, 20);

            // =====================================================
            // BOTÕES
            // =====================================================
            this.btnInserir.Location = new System.Drawing.Point(420, 170);
            this.btnInserir.Size = new System.Drawing.Size(90, 30);
            this.btnInserir.Text = "Salvar";
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);

            this.btnAtualizar.Location = new System.Drawing.Point(520, 170);
            this.btnAtualizar.Size = new System.Drawing.Size(90, 30);
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);

            this.btnExcluir.Location = new System.Drawing.Point(620, 170);
            this.btnExcluir.Size = new System.Drawing.Size(90, 30);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);

            this.btnLimpar.Location = new System.Drawing.Point(720, 170);
            this.btnLimpar.Size = new System.Drawing.Size(80, 30);
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);

            // =====================================================
            // ADD CONTROLES AO FORM
            // =====================================================
            this.pnlForm.Controls.Add(this.lblId);
            this.pnlForm.Controls.Add(this.txtId);

            this.pnlForm.Controls.Add(this.lblNome);
            this.pnlForm.Controls.Add(this.txtNome);

            this.pnlForm.Controls.Add(this.lblEmail);
            this.pnlForm.Controls.Add(this.txtEmail);

            this.pnlForm.Controls.Add(this.lblEspecialidade);
            this.pnlForm.Controls.Add(this.txtEspecialidade);

            this.pnlForm.Controls.Add(this.lblSetor);
            this.pnlForm.Controls.Add(this.txtSetorId);

            this.pnlForm.Controls.Add(this.btnInserir);
            this.pnlForm.Controls.Add(this.btnAtualizar);
            this.pnlForm.Controls.Add(this.btnExcluir);
            this.pnlForm.Controls.Add(this.btnLimpar);

            // =====================================================
            // ADD AO CONTAINER
            // =====================================================
            this.pnlContainer.Controls.Add(this.lblTitulo);
            this.pnlContainer.Controls.Add(this.dgvTecnicos);
            this.pnlContainer.Controls.Add(this.pnlForm);

            // =====================================================
            // ADD AO FORM
            // =====================================================
            this.Controls.Add(this.pnlContainer);

            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecnicos)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlForm;

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEspecialidade;
        private System.Windows.Forms.TextBox txtEspecialidade;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.TextBox txtSetorId;

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;

        private System.Windows.Forms.DataGridView dgvTecnicos;
    }
}
