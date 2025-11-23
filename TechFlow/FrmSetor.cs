using System;
using System.Windows.Forms;
using TechFlow.Data;
using TechFlow.Models;

namespace TechFlow
{
    public partial class FrmSetor : Form
    {
        private readonly SetorDAO dao = new SetorDAO();

        public FrmSetor()
        {
            InitializeComponent();
        }

        // LOAD
        private void FrmSetor_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            CarregarSetores();
        }

        // CONFIGURAR GRID
        private void ConfigurarGrid()
        {
            dgvSetores.AutoGenerateColumns = false;
            dgvSetores.Columns.Clear();

            dgvSetores.Columns.Add("IdSetor", "ID");
            dgvSetores.Columns.Add("Nome", "Nome");

            dgvSetores.Columns["IdSetor"].DataPropertyName = "IdSetor";
            dgvSetores.Columns["Nome"].DataPropertyName = "Nome";

            dgvSetores.Columns["IdSetor"].Width = 60;
        }

        // CARREGAR DADOS
        private void CarregarSetores()
        {
            dgvSetores.DataSource = dao.Listar();
        }

        // LER FORM
        private Setor LerFormulario()
        {
            return new Setor
            {
                IdSetor = string.IsNullOrEmpty(txtId.Text) ? 0 : int.Parse(txtId.Text),
                Nome = txtNome.Text.Trim()
            };
        }

        // GRID → CAMPOS
        private void dgvSetores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var linha = dgvSetores.Rows[e.RowIndex];

            txtId.Text = linha.Cells["IdSetor"].Value.ToString();
            txtNome.Text = linha.Cells["Nome"].Value.ToString();
        }

        // INSERIR
        private void btnInserir_Click(object sender, EventArgs e)
        {
            var setor = LerFormulario();

            if (string.IsNullOrWhiteSpace(setor.Nome))
            {
                MessageBox.Show("Informe o nome do setor.");
                return;
            }

            dao.Inserir(setor);
            MessageBox.Show("Setor cadastrado com sucesso!");

            CarregarSetores();
            LimparCampos();
        }

        // ATUALIZAR
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var setor = LerFormulario();

            if (setor.IdSetor == 0)
            {
                MessageBox.Show("Selecione um setor para atualizar.");
                return;
            }

            dao.Atualizar(setor);
            MessageBox.Show("Setor atualizado!");

            CarregarSetores();
            LimparCampos();
        }

        // EXCLUIR
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Selecione um setor para excluir.");
                return;
            }

            int id = int.Parse(txtId.Text);

            dao.Excluir(id);
            MessageBox.Show("Setor removido!");

            CarregarSetores();
            LimparCampos();
        }

        // LIMPAR
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
        }

    }
}
