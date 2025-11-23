using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechFlow.Data;
using TechFlow.Models;

namespace TechFlow
{
    public partial class FrmAuditoria : Form
    {
        AuditoriaDAO dao = new AuditoriaDAO();

        public FrmAuditoria()
        {
            InitializeComponent();
        }

        // =======================================================
        // LOAD – Configura o grid e carrega tudo ao abrir
        // =======================================================
        private void FrmAuditoria_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            CarregarAuditoria();
        }

        // =======================================================
        // CONFIGURA GRID
        // =======================================================
        private void ConfigurarGrid()
        {
            dgvAuditoria.AutoGenerateColumns = false;
            dgvAuditoria.Columns.Clear();

            dgvAuditoria.Columns.Add("DataAcao", "Data");
            dgvAuditoria.Columns.Add("Usuario", "Usuário");
            dgvAuditoria.Columns.Add("Acao", "Ação");
            dgvAuditoria.Columns.Add("Descricao", "Descrição");

            dgvAuditoria.Columns["DataAcao"].DataPropertyName = "DataAcao";
            dgvAuditoria.Columns["Usuario"].DataPropertyName = "Usuario";
            dgvAuditoria.Columns["Acao"].DataPropertyName = "Acao";
            dgvAuditoria.Columns["Descricao"].DataPropertyName = "Descricao";

            dgvAuditoria.Columns["Descricao"].Width = 350;
        }

        // =======================================================
        // CARREGAR TODA AUDITORIA
        // =======================================================
        private void CarregarAuditoria()
        {
            dgvAuditoria.DataSource = dao.ListarTudo();
        }

        // =======================================================
        // BOTÃO PESQUISAR
        // =======================================================
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string acao = cboAcao.Text.Trim();

            DateTime? dataInicio = null;
            DateTime? dataFim = null;

            if (dtpDataInicio.Checked)
                dataInicio = dtpDataInicio.Value.Date;
            if (dtpDataFim.Checked)
                dataFim = dtpDataFim.Value.Date;

            dgvAuditoria.DataSource = dao.Filtrar(usuario, acao, dataInicio, dataFim);
        }

        // =======================================================
        // BOTÃO LIMPAR
        // =======================================================
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            cboAcao.SelectedIndex = -1;

            dtpDataInicio.Checked = false;
            dtpDataFim.Checked = false;

            CarregarAuditoria();
        }
    }
}
