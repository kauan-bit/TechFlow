namespace TechFlow
{
    partial class FrmRelatorio
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Design

        private void InitializeComponent()
        {
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCardTotal = new System.Windows.Forms.Panel();
            this.lblCardTotalTitulo = new System.Windows.Forms.Label();
            this.lblCardTotalValor = new System.Windows.Forms.Label();
            this.pnlCardAbertos = new System.Windows.Forms.Panel();
            this.lblCardAbertosTitulo = new System.Windows.Forms.Label();
            this.lblCardAbertosValor = new System.Windows.Forms.Label();
            this.pnlCardAtrasados = new System.Windows.Forms.Panel();
            this.lblCardAtrasadosTitulo = new System.Windows.Forms.Label();
            this.lblCardAtrasadosValor = new System.Windows.Forms.Label();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.lblDataFim = new System.Windows.Forms.Label();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblTecnico = new System.Windows.Forms.Label();
            this.cmbTecnico = new System.Windows.Forms.ComboBox();
            this.lblSetor = new System.Windows.Forms.Label();
            this.cmbSetor = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExportarPDF = new System.Windows.Forms.Button();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.dgvRelatorios = new System.Windows.Forms.DataGridView();
            this.lblGraficoStatusTitulo = new System.Windows.Forms.Label();
            this.chartStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblGraficoSetorTitulo = new System.Windows.Forms.Label();
            this.chartSetor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblGraficoMensalTitulo = new System.Windows.Forms.Label();
            this.chartMensal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlContainer.SuspendLayout();
            this.pnlCardTotal.SuspendLayout();
            this.pnlCardAbertos.SuspendLayout();
            this.pnlCardAtrasados.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSetor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMensal)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContainer.Controls.Add(this.lblTitulo);
            this.pnlContainer.Controls.Add(this.pnlCardTotal);
            this.pnlContainer.Controls.Add(this.pnlCardAbertos);
            this.pnlContainer.Controls.Add(this.pnlCardAtrasados);
            this.pnlContainer.Controls.Add(this.pnlFiltros);
            this.pnlContainer.Controls.Add(this.dgvRelatorios);
            this.pnlContainer.Controls.Add(this.lblGraficoStatusTitulo);
            this.pnlContainer.Controls.Add(this.chartStatus);
            this.pnlContainer.Controls.Add(this.lblGraficoSetorTitulo);
            this.pnlContainer.Controls.Add(this.chartSetor);
            this.pnlContainer.Controls.Add(this.lblGraficoMensalTitulo);
            this.pnlContainer.Controls.Add(this.chartMensal);
            this.pnlContainer.Location = new System.Drawing.Point(20, 20);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContainer.Size = new System.Drawing.Size(1160, 760);
            this.pnlContainer.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTitulo.Location = new System.Drawing.Point(20, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(261, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Relatórios e Indicadores";
            // 
            // pnlCardTotal
            // 
            this.pnlCardTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCardTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardTotal.Controls.Add(this.lblCardTotalTitulo);
            this.pnlCardTotal.Controls.Add(this.lblCardTotalValor);
            this.pnlCardTotal.Location = new System.Drawing.Point(20, 60);
            this.pnlCardTotal.Name = "pnlCardTotal";
            this.pnlCardTotal.Size = new System.Drawing.Size(250, 100);
            this.pnlCardTotal.TabIndex = 1;
            // 
            // lblCardTotalTitulo
            // 
            this.lblCardTotalTitulo.AutoSize = true;
            this.lblCardTotalTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCardTotalTitulo.Location = new System.Drawing.Point(10, 10);
            this.lblCardTotalTitulo.Name = "lblCardTotalTitulo";
            this.lblCardTotalTitulo.Size = new System.Drawing.Size(137, 19);
            this.lblCardTotalTitulo.TabIndex = 0;
            this.lblCardTotalTitulo.Text = "Total de Chamados";
            // 
            // lblCardTotalValor
            // 
            this.lblCardTotalValor.AutoSize = true;
            this.lblCardTotalValor.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblCardTotalValor.Location = new System.Drawing.Point(10, 40);
            this.lblCardTotalValor.Name = "lblCardTotalValor";
            this.lblCardTotalValor.Size = new System.Drawing.Size(35, 41);
            this.lblCardTotalValor.TabIndex = 1;
            this.lblCardTotalValor.Text = "0";
            // 
            // pnlCardAbertos
            // 
            this.pnlCardAbertos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCardAbertos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardAbertos.Controls.Add(this.lblCardAbertosTitulo);
            this.pnlCardAbertos.Controls.Add(this.lblCardAbertosValor);
            this.pnlCardAbertos.Location = new System.Drawing.Point(290, 60);
            this.pnlCardAbertos.Name = "pnlCardAbertos";
            this.pnlCardAbertos.Size = new System.Drawing.Size(250, 100);
            this.pnlCardAbertos.TabIndex = 2;
            // 
            // lblCardAbertosTitulo
            // 
            this.lblCardAbertosTitulo.AutoSize = true;
            this.lblCardAbertosTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCardAbertosTitulo.Location = new System.Drawing.Point(10, 10);
            this.lblCardAbertosTitulo.Name = "lblCardAbertosTitulo";
            this.lblCardAbertosTitulo.Size = new System.Drawing.Size(136, 19);
            this.lblCardAbertosTitulo.TabIndex = 0;
            this.lblCardAbertosTitulo.Text = "Chamados Abertos";
            // 
            // lblCardAbertosValor
            // 
            this.lblCardAbertosValor.AutoSize = true;
            this.lblCardAbertosValor.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblCardAbertosValor.Location = new System.Drawing.Point(10, 40);
            this.lblCardAbertosValor.Name = "lblCardAbertosValor";
            this.lblCardAbertosValor.Size = new System.Drawing.Size(35, 41);
            this.lblCardAbertosValor.TabIndex = 1;
            this.lblCardAbertosValor.Text = "0";
            // 
            // pnlCardAtrasados
            // 
            this.pnlCardAtrasados.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCardAtrasados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardAtrasados.Controls.Add(this.lblCardAtrasadosTitulo);
            this.pnlCardAtrasados.Controls.Add(this.lblCardAtrasadosValor);
            this.pnlCardAtrasados.Location = new System.Drawing.Point(560, 60);
            this.pnlCardAtrasados.Name = "pnlCardAtrasados";
            this.pnlCardAtrasados.Size = new System.Drawing.Size(250, 100);
            this.pnlCardAtrasados.TabIndex = 3;
            // 
            // lblCardAtrasadosTitulo
            // 
            this.lblCardAtrasadosTitulo.AutoSize = true;
            this.lblCardAtrasadosTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCardAtrasadosTitulo.Location = new System.Drawing.Point(10, 10);
            this.lblCardAtrasadosTitulo.Name = "lblCardAtrasadosTitulo";
            this.lblCardAtrasadosTitulo.Size = new System.Drawing.Size(150, 19);
            this.lblCardAtrasadosTitulo.TabIndex = 0;
            this.lblCardAtrasadosTitulo.Text = "Chamados Atrasados";
            // 
            // lblCardAtrasadosValor
            // 
            this.lblCardAtrasadosValor.AutoSize = true;
            this.lblCardAtrasadosValor.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblCardAtrasadosValor.Location = new System.Drawing.Point(10, 40);
            this.lblCardAtrasadosValor.Name = "lblCardAtrasadosValor";
            this.lblCardAtrasadosValor.Size = new System.Drawing.Size(35, 41);
            this.lblCardAtrasadosValor.TabIndex = 1;
            this.lblCardAtrasadosValor.Text = "0";
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFiltros.Controls.Add(this.lblDataInicio);
            this.pnlFiltros.Controls.Add(this.dtpDataInicio);
            this.pnlFiltros.Controls.Add(this.lblDataFim);
            this.pnlFiltros.Controls.Add(this.dtpDataFim);
            this.pnlFiltros.Controls.Add(this.lblStatus);
            this.pnlFiltros.Controls.Add(this.cmbStatus);
            this.pnlFiltros.Controls.Add(this.lblTecnico);
            this.pnlFiltros.Controls.Add(this.cmbTecnico);
            this.pnlFiltros.Controls.Add(this.lblSetor);
            this.pnlFiltros.Controls.Add(this.cmbSetor);
            this.pnlFiltros.Controls.Add(this.lblCategoria);
            this.pnlFiltros.Controls.Add(this.cmbCategoria);
            this.pnlFiltros.Controls.Add(this.btnFiltrar);
            this.pnlFiltros.Controls.Add(this.btnLimpar);
            this.pnlFiltros.Controls.Add(this.btnExportarPDF);
            this.pnlFiltros.Controls.Add(this.btnExportarExcel);
            this.pnlFiltros.Location = new System.Drawing.Point(20, 180);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Padding = new System.Windows.Forms.Padding(10);
            this.pnlFiltros.Size = new System.Drawing.Size(1120, 100);
            this.pnlFiltros.TabIndex = 4;
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.Location = new System.Drawing.Point(10, 10);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(89, 23);
            this.lblDataInicio.TabIndex = 0;
            this.lblDataInicio.Text = "Data Início:";
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Location = new System.Drawing.Point(105, 11);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpDataInicio.TabIndex = 1;
            // 
            // lblDataFim
            // 
            this.lblDataFim.Location = new System.Drawing.Point(10, 40);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(89, 23);
            this.lblDataFim.TabIndex = 2;
            this.lblDataFim.Text = "Data Fim:";
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Location = new System.Drawing.Point(105, 40);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.Size = new System.Drawing.Size(200, 20);
            this.dtpDataFim.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(320, 10);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(80, 23);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Location = new System.Drawing.Point(426, 9);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 5;
            // 
            // lblTecnico
            // 
            this.lblTecnico.Location = new System.Drawing.Point(320, 41);
            this.lblTecnico.Name = "lblTecnico";
            this.lblTecnico.Size = new System.Drawing.Size(80, 23);
            this.lblTecnico.TabIndex = 6;
            this.lblTecnico.Text = "Técnico:";
            // 
            // cmbTecnico
            // 
            this.cmbTecnico.Location = new System.Drawing.Point(426, 37);
            this.cmbTecnico.Name = "cmbTecnico";
            this.cmbTecnico.Size = new System.Drawing.Size(121, 21);
            this.cmbTecnico.TabIndex = 7;
            // 
            // lblSetor
            // 
            this.lblSetor.Location = new System.Drawing.Point(600, 10);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(100, 23);
            this.lblSetor.TabIndex = 8;
            this.lblSetor.Text = "Setor:";
            // 
            // cmbSetor
            // 
            this.cmbSetor.Location = new System.Drawing.Point(706, 10);
            this.cmbSetor.Name = "cmbSetor";
            this.cmbSetor.Size = new System.Drawing.Size(121, 21);
            this.cmbSetor.TabIndex = 9;
            // 
            // lblCategoria
            // 
            this.lblCategoria.Location = new System.Drawing.Point(600, 40);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(100, 23);
            this.lblCategoria.TabIndex = 10;
            this.lblCategoria.Text = "Categoria:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Location = new System.Drawing.Point(706, 36);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 11;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(900, 10);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 30);
            this.btnFiltrar.TabIndex = 12;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(900, 50);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExportarPDF
            // 
            this.btnExportarPDF.Location = new System.Drawing.Point(1010, 10);
            this.btnExportarPDF.Name = "btnExportarPDF";
            this.btnExportarPDF.Size = new System.Drawing.Size(80, 30);
            this.btnExportarPDF.TabIndex = 14;
            this.btnExportarPDF.Text = "PDF";
            this.btnExportarPDF.Click += new System.EventHandler(this.btnExportarPDF_Click);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Location = new System.Drawing.Point(1010, 50);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(80, 30);
            this.btnExportarExcel.TabIndex = 15;
            this.btnExportarExcel.Text = "Excel";
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // dgvRelatorios
            // 
            this.dgvRelatorios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRelatorios.BackgroundColor = System.Drawing.Color.White;
            this.dgvRelatorios.Location = new System.Drawing.Point(20, 300);
            this.dgvRelatorios.Name = "dgvRelatorios";
            this.dgvRelatorios.Size = new System.Drawing.Size(1120, 200);
            this.dgvRelatorios.TabIndex = 5;
            // 
            // lblGraficoStatusTitulo
            // 
            this.lblGraficoStatusTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGraficoStatusTitulo.Location = new System.Drawing.Point(20, 520);
            this.lblGraficoStatusTitulo.Name = "lblGraficoStatusTitulo";
            this.lblGraficoStatusTitulo.Size = new System.Drawing.Size(100, 23);
            this.lblGraficoStatusTitulo.TabIndex = 6;
            this.lblGraficoStatusTitulo.Text = "Distribuição por Status";
            // 
            // chartStatus
            // 
            this.chartStatus.Location = new System.Drawing.Point(20, 550);
            this.chartStatus.Name = "chartStatus";
            this.chartStatus.Size = new System.Drawing.Size(350, 200);
            this.chartStatus.TabIndex = 7;
            // 
            // lblGraficoSetorTitulo
            // 
            this.lblGraficoSetorTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGraficoSetorTitulo.Location = new System.Drawing.Point(400, 520);
            this.lblGraficoSetorTitulo.Name = "lblGraficoSetorTitulo";
            this.lblGraficoSetorTitulo.Size = new System.Drawing.Size(100, 23);
            this.lblGraficoSetorTitulo.TabIndex = 8;
            this.lblGraficoSetorTitulo.Text = "Chamados por Setor";
            // 
            // chartSetor
            // 
            this.chartSetor.Location = new System.Drawing.Point(400, 550);
            this.chartSetor.Name = "chartSetor";
            this.chartSetor.Size = new System.Drawing.Size(350, 200);
            this.chartSetor.TabIndex = 9;
            // 
            // lblGraficoMensalTitulo
            // 
            this.lblGraficoMensalTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGraficoMensalTitulo.Location = new System.Drawing.Point(780, 520);
            this.lblGraficoMensalTitulo.Name = "lblGraficoMensalTitulo";
            this.lblGraficoMensalTitulo.Size = new System.Drawing.Size(100, 23);
            this.lblGraficoMensalTitulo.TabIndex = 10;
            this.lblGraficoMensalTitulo.Text = "Atendimentos por Mês";
            // 
            // chartMensal
            // 
            this.chartMensal.Location = new System.Drawing.Point(780, 550);
            this.chartMensal.Name = "chartMensal";
            this.chartMensal.Size = new System.Drawing.Size(360, 200);
            this.chartMensal.TabIndex = 11;
            // 
            // FrmRelatorio
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.pnlContainer);
            this.Name = "FrmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatórios e Indicadores";
            this.Load += new System.EventHandler(this.FrmRelatorio_Load);
            this.Click += new System.EventHandler(this.FrmRelatorio_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.pnlCardTotal.ResumeLayout(false);
            this.pnlCardTotal.PerformLayout();
            this.pnlCardAbertos.ResumeLayout(false);
            this.pnlCardAbertos.PerformLayout();
            this.pnlCardAtrasados.ResumeLayout(false);
            this.pnlCardAtrasados.PerformLayout();
            this.pnlFiltros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSetor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMensal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;

        private System.Windows.Forms.Panel pnlCardTotal;
        private System.Windows.Forms.Label lblCardTotalTitulo;
        private System.Windows.Forms.Label lblCardTotalValor;

        private System.Windows.Forms.Panel pnlCardAbertos;
        private System.Windows.Forms.Label lblCardAbertosTitulo;
        private System.Windows.Forms.Label lblCardAbertosValor;

        private System.Windows.Forms.Panel pnlCardAtrasados;
        private System.Windows.Forms.Label lblCardAtrasadosTitulo;
        private System.Windows.Forms.Label lblCardAtrasadosValor;

        private System.Windows.Forms.Panel pnlFiltros;

        private System.Windows.Forms.Label lblTitulo;

        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private System.Windows.Forms.DateTimePicker dtpDataFim;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbTecnico;
        private System.Windows.Forms.ComboBox cmbSetor;
        private System.Windows.Forms.ComboBox cmbCategoria;

        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.Label lblDataFim;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTecnico;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.Label lblCategoria;

        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExportarPDF;
        private System.Windows.Forms.Button btnExportarExcel;

        private System.Windows.Forms.DataGridView dgvRelatorios;

        private System.Windows.Forms.Label lblGraficoStatusTitulo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatus;

        private System.Windows.Forms.Label lblGraficoSetorTitulo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSetor;

        private System.Windows.Forms.Label lblGraficoMensalTitulo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMensal;
    }
}
