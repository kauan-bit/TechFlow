using System;
using System.Windows.Forms;
using TechFlow.Data;
using TechFlow.Models;

namespace TechFlow
{
    public partial class FrmUsuario : Form
    {
        private UsuarioDAO dao = new UsuarioDAO();

        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            CarregarUsuarios();
        }

        // =========================================================
        // CONFIGURAR GRID
        // =========================================================
        private void ConfigurarGrid()
        {
            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.Columns.Clear();

            dgvUsuarios.Columns.Add("IdUsuario", "ID");
            dgvUsuarios.Columns.Add("Nome", "Nome");
            dgvUsuarios.Columns.Add("Email", "Email");
            dgvUsuarios.Columns.Add("Perfil", "Perfil");
            dgvUsuarios.Columns.Add("SetorId", "Setor");

            dgvUsuarios.Columns["IdUsuario"].DataPropertyName = "IdUsuario";
            dgvUsuarios.Columns["Nome"].DataPropertyName = "Nome";
            dgvUsuarios.Columns["Email"].DataPropertyName = "Email";
            dgvUsuarios.Columns["Perfil"].DataPropertyName = "Perfil";
            dgvUsuarios.Columns["SetorId"].DataPropertyName = "SetorId";

            dgvUsuarios.Columns["IdUsuario"].Width = 50;
            dgvUsuarios.Columns["Nome"].Width = 150;
            dgvUsuarios.Columns["Email"].Width = 150;
        }

        // =========================================================
        // CARREGAR LISTA DE USUÁRIOS
        // =========================================================
        private void CarregarUsuarios()
        {
            dgvUsuarios.DataSource = dao.Listar();
        }

        // =========================================================
        // LEITURA DO FORMULÁRIO – converte para model Usuario
        // =========================================================
        private Usuario LerFormulario()
        {
            return new Usuario
            {
                IdUsuario = string.IsNullOrWhiteSpace(txtId.Text) ? 0 : int.Parse(txtId.Text),
                Nome = txtNome.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                SenhaHash = txtSenha.Text.Trim(),
                Perfil = cboPerfil.Text,
                SetorId = string.IsNullOrWhiteSpace(txtSetorId.Text)
                    ? (int?)null
                    : int.Parse(txtSetorId.Text)
            };
        }

        // =========================================================
        // PREENCHER CAMPOS AO CLICAR NO GRID
        // =========================================================
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvUsuarios.Rows[e.RowIndex];

            txtId.Text = row.Cells["IdUsuario"].Value.ToString();
            txtNome.Text = row.Cells["Nome"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value.ToString();
            cboPerfil.Text = row.Cells["Perfil"].Value.ToString();

            txtSetorId.Text = row.Cells["SetorId"].Value?.ToString();
        }

        
        private void btnInserir_Click(object sender, EventArgs e)
        {
            Usuario u = LerFormulario();

            dao.Inserir(u);
            MessageBox.Show("Usuário cadastrado com sucesso!");

            CarregarUsuarios();
            LimparCampos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Usuario u = LerFormulario();

            if (u.IdUsuario == 0)
            {
                MessageBox.Show("Selecione um usuário para editar.");
                return;
            }

            dao.Atualizar(u);
            MessageBox.Show("Usuário atualizado com sucesso!");

            CarregarUsuarios();
            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Selecione um usuário para excluir.");
                return;
            }

            int id = int.Parse(txtId.Text);

            dao.Excluir(id);
            MessageBox.Show("Usuário excluído!");

            CarregarUsuarios();
            LimparCampos();
        }

        // =========================================================
        // LIMPAR CAMPOS
        // =========================================================
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtSetorId.Clear();
            cboPerfil.SelectedIndex = -1;
        }
    }
}
