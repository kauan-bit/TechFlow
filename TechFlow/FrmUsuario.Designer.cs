namespace TechFlow
{
    partial class FrmUsuario
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

        #region Código do Designer

        private void InitializeComponent()
        {
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.pnlForm = new System.Windows.Forms.Panel();

            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();

            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();

            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();

            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();

            this.lblPerfil = new System.Windows.Forms.Label();
            this.cboPerfil = new System.Windows.Forms.ComboBox();

            this.lblSetor = new System.Windows.Forms.Label();
            this.txtSetorId = new System.Windows.Forms.TextBox();

            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();

            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();

            // =====================================================
            // FORM PRINCIPAL
            // =====================================================
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#F2F2F2");
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Usuários";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);

            // =====================================================
            // PAINEL CONTAINER (CARD BRANCO)
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
            this.lblTitulo.Size = new System.Drawing.Size(270, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gerenciamento de Usuários";

            // =====================================================
            // GRID DE USUÁRIOS
            // =====================================================
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(20, 60);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(820, 260);
            this.dgvUsuarios.TabIndex = 1;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);

            // =====================================================
            // PAINEL DO FORMULÁRIO
            // =====================================================
            this.pnlForm.BackColor = System.Drawing.ColorTranslator.FromHtml("#FAFAFA");
            this.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlForm.Location = new System.Drawing.Point(20, 340);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Padding = new System.Windows.Forms.Padding(10);
            this.pnlForm.Size = new System.Drawing.Size(820, 230);

            // ================== CAMPOS ==================

            // ID
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(20, 25);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.Text = "ID:";

            this.txtId.Location = new System.Drawing.Point(110, 22);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(120, 20);

            // Nome
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(20, 65);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.Text = "Nome:";

            this.txtNome.Location = new System.Drawing.Point(110, 62);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(260, 20);

            // Email
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 105);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.Text = "Email:";

            this.txtEmail.Location = new System.Drawing.Point(110, 102);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 20);

            // Senha
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(20, 145);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.Text = "Senha:";

            this.txtSenha.Location = new System.Drawing.Point(110, 142);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(260, 20);

            // Perfil
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(420, 65);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(33, 13);
            this.lblPerfil.Text = "Perfil:";

            this.cboPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPerfil.Items.AddRange(new object[] {
                "Administrador",
                "Tecnico",
                "Usuario"
            });
            this.cboPerfil.Location = new System.Drawing.Point(500, 62);
            this.cboPerfil.Name = "cboPerfil";
            this.cboPerfil.Size = new System.Drawing.Size(220, 21);

            // Setor
            this.lblSetor.AutoSize = true;
            this.lblSetor.Location = new System.Drawing.Point(420, 105);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(49, 13);
            this.lblSetor.Text = "Setor ID:";

            this.txtSetorId.Location = new System.Drawing.Point(500, 102);
            this.txtSetorId.Name = "txtSetorId";
            this.txtSetorId.Size = new System.Drawing.Size(80, 20);

            // ================== BOTÕES ==================

            // Salvar
            this.btnInserir.Location = new System.Drawing.Point(420, 170);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(90, 30);
            this.btnInserir.TabIndex = 13;
            this.btnInserir.Text = "Salvar";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);

            // Atualizar
            this.btnAtualizar.Location = new System.Drawing.Point(520, 170);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(90, 30);
            this.btnAtualizar.TabIndex = 14;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);

            // Excluir
            this.btnExcluir.Location = new System.Drawing.Point(620, 170);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 30);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);

            // Limpar
            this.btnLimpar.Location = new System.Drawing.Point(720, 170);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(80, 30);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);

            // =====================================================
            // ADD CONTROLES AO PAINEL DO FORM
            // =====================================================
            this.pnlForm.Controls.Add(this.lblId);
            this.pnlForm.Controls.Add(this.txtId);
            this.pnlForm.Controls.Add(this.lblNome);
            this.pnlForm.Controls.Add(this.txtNome);
            this.pnlForm.Controls.Add(this.lblEmail);
            this.pnlForm.Controls.Add(this.txtEmail);
            this.pnlForm.Controls.Add(this.lblSenha);
            this.pnlForm.Controls.Add(this.txtSenha);
            this.pnlForm.Controls.Add(this.lblPerfil);
            this.pnlForm.Controls.Add(this.cboPerfil);
            this.pnlForm.Controls.Add(this.lblSetor);
            this.pnlForm.Controls.Add(this.txtSetorId);
            this.pnlForm.Controls.Add(this.btnInserir);
            this.pnlForm.Controls.Add(this.btnAtualizar);
            this.pnlForm.Controls.Add(this.btnExcluir);
            this.pnlForm.Controls.Add(this.btnLimpar);

            // =====================================================
            // ADD CONTROLES AO CONTAINER
            // =====================================================
            this.pnlContainer.Controls.Add(this.lblTitulo);
            this.pnlContainer.Controls.Add(this.dgvUsuarios);
            this.pnlContainer.Controls.Add(this.pnlForm);

            // =====================================================
            // ADD AO FORM
            // =====================================================
            this.Controls.Add(this.pnlContainer);

            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlForm;

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lblTitulo;

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;

        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;

        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.ComboBox cboPerfil;

        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.TextBox txtSetorId;

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
    }
}
