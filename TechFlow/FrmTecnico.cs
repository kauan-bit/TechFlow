using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechFlow.Data;
using TechFlow.Models;

namespace TechFlow
{
    public partial class FrmTecnico : Form
    {
        private readonly TecnicoDAO dao = new TecnicoDAO();

        public FrmTecnico()
        {
            InitializeComponent();
        }

        // ============================================
        // LOAD — CONFIGURAR GRID + CARREGAR DADOS
        // ============================================
        private void FrmTecnico_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            CarregarTecnicos();
        }

        // ============================================
        // CONFIGURA O GRID
        // ============================================
        private void ConfigurarGrid()
        {
            dgvTecnicos.AutoGenerateColumns = false;
            dgvTecnicos.Columns.Clear();

            dgvTecnicos.Columns.Add("IdTecnico", "ID");
            dgvTecnicos.Columns.Add("Nome", "Nome");
            dgvTecnicos.Columns.Add("Email", "Email");
            dgvTecnicos.Columns.Add("Especialidade", "Especialidade");
            dgvTecnicos.Columns.Add("SetorId", "Setor");

            dgvTecnicos.Columns["IdTecnico"].DataPropertyName = "IdTecnico";
            dgvTecnicos.Columns["Nome"].DataPropertyName = "Nome";
            dgvTecnicos.Columns["Email"].DataPropertyName = "Email";
            dgvTecnicos.Columns["Especialidade"].DataPropertyName = "Especialidade";
            dgvTecnicos.Columns["SetorId"].DataPropertyName = "SetorId";

            dgvTecnicos.Columns["IdTecnico"].Width = 50;
            dgvTecnicos.Columns["Nome"].Width = 180;
            dgvTecnicos.Columns["Email"].Width = 170;
            dgvTecnicos.Columns["Especialidade"].Width = 150;
        }

        // ============================================
        // LISTAR TÉCNICOS
        // ============================================
        private void CarregarTecnicos()
        {
            dgvTecnicos.DataSource = dao.Listar();
        }

        // ============================================
        // LER CAMPOS DO FORMULÁRIO
        // ============================================
        private FrmTecnicoModel LerFormulario()
        {
            return new FrmTecnicoModel
            {
                IdTecnico = string.IsNullOrEmpty(txtId.Text) ? 0 : int.Parse(txtId.Text),
                Nome = txtNome.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Especialidade = txtEspecialidade.Text.Trim(),
                SetorId = string.IsNullOrEmpty(txtSetorId.Text)
                            ? (int?)null
                            : int.Parse(txtSetorId.Text)
            };
        }

        // ============================================
        // POPULAR CAMPOS AO CLICAR NO GRID
        // ============================================
        private void dgvTecnicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var linha = dgvTecnicos.Rows[e.RowIndex];

            txtId.Text = linha.Cells["IdTecnico"].Value.ToString();
            txtNome.Text = linha.Cells["Nome"].Value.ToString();
            txtEmail.Text = linha.Cells["Email"].Value.ToString();
            txtEspecialidade.Text = linha.Cells["Especialidade"].Value.ToString();
            txtSetorId.Text = linha.Cells["SetorId"].Value?.ToString();
        }

        // ============================================
        // CONVERTER MODEL → ENTIDADE REAL
        // ============================================
        private Tecnico ConverterParaTecnico(FrmTecnicoModel model)
        {
            return new Tecnico
            {
                IdTecnico = model.IdTecnico,
                Nome = model.Nome,
                Email = model.Email,
                Especialidade = model.Especialidade,
                SetorId = model.SetorId
            };
        }

        // ============================================
        // SALVAR
        // ============================================
        private void btnInserir_Click(object sender, EventArgs e)
        {
            var model = LerFormulario();

            dao.Inserir(ConverterParaTecnico(model));

            MessageBox.Show("Técnico cadastrado com sucesso!");

            CarregarTecnicos();
            LimparCampos();
        }

        // ============================================
        // ATUALIZAR
        // ============================================
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var model = LerFormulario();

            if (model.IdTecnico == 0)
            {
                MessageBox.Show("Selecione um técnico para atualizar.");
                return;
            }

            dao.Atualizar(ConverterParaTecnico(model));

            MessageBox.Show("Técnico atualizado!");

            CarregarTecnicos();
            LimparCampos();
        }

        // ============================================
        // EXCLUIR
        // ============================================
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Selecione um técnico.");
                return;
            }

            int id = int.Parse(txtId.Text);

            dao.Excluir(id);

            MessageBox.Show("Técnico removido!");

            CarregarTecnicos();
            LimparCampos();
        }

        // ============================================
        // LIMPAR CAMPOS
        // ============================================
        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtEspecialidade.Clear();
            txtSetorId.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }

    // ============================================
    // MODEL EXCLUSIVO DO FORM
    // ============================================
    public class FrmTecnicoModel
    {
        public int IdTecnico { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Especialidade { get; set; }
        public int? SetorId { get; set; }
    }
}
