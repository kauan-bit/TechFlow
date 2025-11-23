using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using TechFlow.Data;

// Bibliotecas de exportação
using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace TechFlow
{
    public partial class FrmRelatorio : Form
    {
        private readonly RelatorioDAO dao = new RelatorioDAO();

        public FrmRelatorio()
        {
            InitializeComponent();
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            ConfigurarTela();
            CarregarFiltros();
            CarregarRelatorioCompleto();
        }

        // ============================================================
        // CONFIGURAÇÃO VISUAL PADRÃO TECHFLOW
        // ============================================================
        private void ConfigurarTela()
        {
            dgvRelatorios.AutoGenerateColumns = true;
            dgvRelatorios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRelatorios.MultiSelect = false;
            dgvRelatorios.ReadOnly = true;
            dgvRelatorios.RowHeadersVisible = false;
            dgvRelatorios.BackgroundColor = Color.White;
            dgvRelatorios.BorderStyle = BorderStyle.FixedSingle;

            dgvRelatorios.DefaultCellStyle.BackColor = Color.White;
            dgvRelatorios.DefaultCellStyle.ForeColor = Color.Black;
            dgvRelatorios.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);

            dgvRelatorios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dgvRelatorios.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvRelatorios.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11, FontStyle.Bold);
            dgvRelatorios.EnableHeadersVisualStyles = false;

            // Configuração dos gráficos
            ConfigurarGraficos();
        }

        private void ConfigurarGraficos()
        {
            // ChartStatus
            if (chartStatus.ChartAreas.Count == 0)
                chartStatus.ChartAreas.Add(new ChartArea("Area1"));
            if (chartStatus.Series.Count == 0)
                chartStatus.Series.Add(new Series("Status"));

            chartStatus.Series["Status"].ChartType = SeriesChartType.Pie;
            chartStatus.Series["Status"].IsValueShownAsLabel = true;
            chartStatus.Legends.Clear();
            chartStatus.Legends.Add(new Legend() { Enabled = true });

            // ChartSetor
            if (chartSetor.ChartAreas.Count == 0)
                chartSetor.ChartAreas.Add(new ChartArea("Area1"));
            if (chartSetor.Series.Count == 0)
                chartSetor.Series.Add(new Series("Setor"));

            chartSetor.Series["Setor"].ChartType = SeriesChartType.Column;
            chartSetor.Series["Setor"].IsValueShownAsLabel = true;
            chartSetor.Legends.Clear();

            // ChartMensal
            if (chartMensal.ChartAreas.Count == 0)
                chartMensal.ChartAreas.Add(new ChartArea("Area1"));
            if (chartMensal.Series.Count == 0)
                chartMensal.Series.Add(new Series("Mensal"));

            chartMensal.Series["Mensal"].ChartType = SeriesChartType.Line;
            chartMensal.Series["Mensal"].BorderWidth = 3;
            chartMensal.Series["Mensal"].Color = Color.FromArgb(0, 120, 215);
            chartMensal.Legends.Clear();
        }

        // ============================================================
        // CARREGAR COMBOS (STATUS, TÉCNICO, SETOR, CATEGORIA)
        // ============================================================
        private void CarregarFiltros()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Aberto");
            cmbStatus.Items.Add("Em Atendimento");
            cmbStatus.Items.Add("Resolvido");
            cmbStatus.Items.Add("Fechado");
            cmbStatus.SelectedIndex = -1;

            cmbTecnico.DataSource = dao.ListarTecnicos();
            cmbTecnico.DisplayMember = "Nome";
            cmbTecnico.ValueMember = "IdTecnico";
            cmbTecnico.SelectedIndex = -1;

            cmbSetor.DataSource = dao.ListarSetores();
            cmbSetor.DisplayMember = "Nome";
            cmbSetor.ValueMember = "IdSetor";
            cmbSetor.SelectedIndex = -1;

            cmbCategoria.DataSource = dao.ListarCategorias();
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "IdCategoria";
            cmbCategoria.SelectedIndex = -1;

            dtpDataInicio.Value = DateTime.Now.AddMonths(-1);
            dtpDataFim.Value = DateTime.Now;
        }

        // ============================================================
        // CARREGAR RELATÓRIO COMPLETO (GRID + CARDS + GRÁFICOS)
        // ============================================================
        private void CarregarRelatorioCompleto()
        {
            DataTable tabela = dao.RelatorioCompleto();
            dgvRelatorios.DataSource = tabela;

            AtualizarCards();
            AtualizarGraficos();
        }

        // ============================================================
        // BOTÃO FILTRAR
        // ============================================================
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string status = cmbStatus.Text == "" ? null : cmbStatus.Text;
            int? tecnicoId = cmbTecnico.SelectedIndex == -1 ? null : (int?)cmbTecnico.SelectedValue;
            int? setorId = cmbSetor.SelectedIndex == -1 ? null : (int?)cmbSetor.SelectedValue;
            int? categoriaId = cmbCategoria.SelectedIndex == -1 ? null : (int?)cmbCategoria.SelectedValue;

            dgvRelatorios.DataSource =
                dao.FiltrarRelatorio(
                    dtpDataInicio.Value,
                    dtpDataFim.Value,
                    status,
                    tecnicoId,
                    setorId,
                    categoriaId);

            AtualizarCards();
            AtualizarGraficos();
        }

        // ============================================================
        // BOTÃO LIMPAR
        // ============================================================
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = -1;
            cmbTecnico.SelectedIndex = -1;
            cmbSetor.SelectedIndex = -1;
            cmbCategoria.SelectedIndex = -1;

            dtpDataInicio.Value = DateTime.Now.AddMonths(-1);
            dtpDataFim.Value = DateTime.Now;

            CarregarRelatorioCompleto();
        }

        // ============================================================
        // ATUALIZAR CARDS
        // ============================================================
        private void AtualizarCards()
        {
            lblCardTotalValor.Text = dao.GetTotalChamados().ToString();
            lblCardAbertosValor.Text = dao.GetChamadosAbertos().ToString();
            lblCardAtrasadosValor.Text = dao.GetChamadosAtrasados().ToString();
        }

        // ============================================================
        // ATUALIZAR GRÁFICOS
        // ============================================================
        private void AtualizarGraficos()
        {
            chartStatus.Series[0].Points.Clear();
            chartSetor.Series[0].Points.Clear();
            chartMensal.Series[0].Points.Clear();

            foreach (DataRow row in dao.GraficoPorStatus().Rows)
                chartStatus.Series[0].Points.AddXY(row["Status"], row["Qtd"]);

            foreach (DataRow row in dao.GraficoPorSetor().Rows)
                chartSetor.Series[0].Points.AddXY(row["Nome"], row["Qtd"]);

            foreach (DataRow row in dao.GraficoMensal().Rows)
                chartMensal.Series[0].Points.AddXY(row["Mes"], row["Qtd"]);
        }

        // ============================================================
        // EXPORTAR PARA EXCEL
        // ============================================================
        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if (dgvRelatorios.Rows.Count == 0)
            {
                MessageBox.Show("Não há dados para exportar.");
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Arquivo Excel (*.xlsx)|*.xlsx";
            save.FileName = "Relatorio_TechFlow.xlsx";

            if (save.ShowDialog() == DialogResult.OK)
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn col in dgvRelatorios.Columns)
                    dt.Columns.Add(col.HeaderText);

                foreach (DataGridViewRow row in dgvRelatorios.Rows)
                {
                    DataRow linha = dt.NewRow();
                    for (int i = 0; i < dgvRelatorios.Columns.Count; i++)
                        linha[i] = row.Cells[i].Value;

                    dt.Rows.Add(linha);
                }

                using (XLWorkbook wb = new XLWorkbook())
                {
                    var ws = wb.Worksheets.Add(dt, "Relatório");
                    ws.Columns().AdjustToContents();
                    wb.SaveAs(save.FileName);
                }

                MessageBox.Show("Relatório exportado para Excel com sucesso!");
            }
        }

        // ============================================================
        // EXPORTAR PARA PDF
        // ============================================================
        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            if (dgvRelatorios.Rows.Count == 0)
            {
                MessageBox.Show("Não há dados para exportar.");
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Arquivo PDF (*.pdf)|*.pdf";
            save.FileName = "Relatorio_TechFlow.pdf";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Document pdfDoc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);

                using (FileStream stream = new FileStream(save.FileName, FileMode.Create))
                {
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    var titulo = new Paragraph("Relatório de Chamados - TechFlow\n\n",
                        FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18))
                    {
                        Alignment = Element.ALIGN_CENTER
                    };
                    pdfDoc.Add(titulo);

                    PdfPTable pdfTable = new PdfPTable(dgvRelatorios.Columns.Count)
                    {
                        WidthPercentage = 100
                    };

                    foreach (DataGridViewColumn column in dgvRelatorios.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText))
                        {
                            BackgroundColor = BaseColor.LIGHT_GRAY
                        };
                        pdfTable.AddCell(cell);
                    }

                    foreach (DataGridViewRow row in dgvRelatorios.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.AddCell(cell.Value?.ToString());
                        }
                    }

                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }

                MessageBox.Show("PDF gerado com sucesso!");
            }
        }
    }
}
