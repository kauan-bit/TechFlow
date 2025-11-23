using System;
using System.Windows.Forms;
using TechFlow.Data;
using TechFlow.Models;

namespace TechFlow
{
    public partial class FrmGerenciadorCate : Form
    {
        CategoriaDAO dao = new CategoriaDAO();

        public FrmGerenciadorCate()
        {
            InitializeComponent();
        }

        // ======================================================
        // LOAD
        // ======================================================
        private void FrmGerenciadorCate_Load(object sender, EventArgs e)
        {
            label1.Text = "Gerenciar Categorias";
            ConfigurarGrid();
            CarregarCategorias();
        }

        // ======================================================
        // CONFIGURAR DATAGRIDVIEW
        // ======================================================
        private void ConfigurarGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            // ID
            var colId = new DataGridViewTextBoxColumn();
            colId.Name = "IdCategoria";
            colId.HeaderText = "ID";
            colId.DataPropertyName = "IdCategoria";
            colId.Width = 60;
            dataGridView1.Columns.Add(colId);

            // NOME
            var colNome = new DataGridViewTextBoxColumn();
            colNome.Name = "Nome";
            colNome.HeaderText = "Nome da Categoria";
            colNome.DataPropertyName = "Nome";
            colNome.Width = 300;
            dataGridView1.Columns.Add(colNome);
        }

        // ======================================================
        // CARREGAR LISTA
        // ======================================================
        private void CarregarCategorias()
        {
            dataGridView1.DataSource = dao.Listar();
        }

        // ======================================================
        // LER FORMULÁRIO
        // ======================================================
        private Categoria LerFormulario()
        {
            return new Categoria
            {
                IdCategoria = string.IsNullOrEmpty(txtId.Text)
                    ? 0
                    : int.Parse(txtId.Text),

                Nome = txtNomeCategoria.Text.Trim()
            };
        }

        // ======================================================
        // AO CLICAR EM UMA LINHA DO GRID
        // ======================================================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var linha = dataGridView1.Rows[e.RowIndex];

            txtId.Text = linha.Cells["IdCategoria"].Value.ToString();
            txtNomeCategoria.Text = linha.Cells["Nome"].Value.ToString();
        }

        // ======================================================
        // INSERIR
        // ======================================================
        private void btnInserir_Click(object sender, EventArgs e)
        {
            Categoria c = LerFormulario();

            if (string.IsNullOrWhiteSpace(c.Nome))
            {
                MessageBox.Show("Digite o nome da categoria!", "Aviso");
                return;
            }

            dao.Inserir(c);

            MessageBox.Show("Categoria cadastrada com sucesso!", "Sucesso");

            CarregarCategorias();
            LimparCampos();
        }

        // ======================================================
        // ATUALIZAR
        // ======================================================
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Categoria c = LerFormulario();

            if (c.IdCategoria == 0)
            {
                MessageBox.Show("Selecione uma categoria para atualizar!");
                return;
            }

            dao.Atualizar(c);

            MessageBox.Show("Categoria atualizada com sucesso!", "Sucesso");

            CarregarCategorias();
            LimparCampos();
        }

        // ======================================================
        // EXCLUIR
        // ======================================================
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Selecione uma categoria!", "Aviso");
                return;
            }

            int id = int.Parse(txtId.Text);

            dao.Excluir(id);

            MessageBox.Show("Categoria removida com sucesso!", "Sucesso");

            CarregarCategorias();
            LimparCampos();
        }

        // ======================================================
        // LIMPAR
        // ======================================================
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtNomeCategoria.Clear();
            txtNomeCategoria.Focus();
        }
    }
}
