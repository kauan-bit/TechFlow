using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TechFlow.Models;

namespace TechFlow
{
    public partial class Dashboard : Form
    {
        private Usuario usuarioLogado;

        // ============================================
        // CONSTRUTOR — RECEBE O MODEL Usuario
        // ============================================
        public Dashboard(Usuario usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario;

            lblSaudacao.Text = $"Bem-vindo, {usuarioLogado.Nome}";

            AplicarEstiloCards();
            AplicarTextoCards();
            RegistrarEventosDeClique();
        }

        // ============================================
        // CRIAR 1 CARD COMPLETO
        // ============================================
        private void SetupCard(Panel panel, Label label, string texto)
        {
            panel.BackColor = Color.White;
            panel.Size = new Size(250, 110);
            panel.Margin = new Padding(12);
            panel.Padding = new Padding(4);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Cursor = Cursors.Hand;

            label.Text = texto;
            label.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label.ForeColor = ColorTranslator.FromHtml("#333333");
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Dock = DockStyle.Fill;
        }

        // ============================================
        // APLICAR ESTILO DE TODOS OS CARDS
        // ============================================
        private void AplicarEstiloCards()
        {
            List<Panel> cards = new List<Panel>
            {
                cardUsuarios,
                cardTecnicos,
                cardSetores,
                cardCategorias,
                cardRelatorios,
                cardAuditoria
            };

            foreach (var card in cards)
            {
                card.BackColor = Color.White;
                card.BorderStyle = BorderStyle.FixedSingle;
                card.Margin = new Padding(12);
                card.Padding = new Padding(5);
                card.Size = new Size(250, 110);
                card.Cursor = Cursors.Hand;
            }
        }

        // ============================================
        // APLICAR TEXTO + FONTE
        // ============================================
        private void AplicarTextoCards()
        {
            SetupCard(cardUsuarios, lblUsuarios, "Gerenciar Usuários");
            SetupCard(cardTecnicos, lblTecnicos, "Gerenciar Técnicos");
            SetupCard(cardSetores, lblSetores, "Gerenciar Setores");
            SetupCard(cardCategorias, lblCategorias, "Gerenciar Categorias");
            SetupCard(cardRelatorios, lblRelatorios, "Relatórios");
            SetupCard(cardAuditoria, lblAuditoria, "Auditoria do Sistema");
        }

        // ============================================
        // REGISTRAR EVENTOS DE CLICK
        // ============================================
        private void RegistrarEventosDeClique()
        {
            // Usuários
            cardUsuarios.Click += (s, e) => AbrirUsuarios();
            lblUsuarios.Click += (s, e) => AbrirUsuarios();

            // Técnicos
            cardTecnicos.Click += (s, e) => AbrirTecnicos();
            lblTecnicos.Click += (s, e) => AbrirTecnicos();

            // Setores
            cardSetores.Click += (s, e) => AbrirSetores();
            lblSetores.Click += (s, e) => AbrirSetores();

            // Categorias
            cardCategorias.Click += (s, e) => AbrirCategorias();
            lblCategorias.Click += (s, e) => AbrirCategorias();

            // Relatórios
            cardRelatorios.Click += (s, e) => AbrirRelatorios();
            lblRelatorios.Click += (s, e) => AbrirRelatorios();

            // Auditoria
            cardAuditoria.Click += (s, e) => AbrirAuditoria();
            lblAuditoria.Click += (s, e) => AbrirAuditoria();
        }

        // ============================================
        // MÉTODOS QUE ABREM AS TELAS
        // ============================================
        private void AbrirUsuarios()
        {
            FrmUsuario tela = new FrmUsuario();
            tela.ShowDialog();
        }

        private void AbrirTecnicos()
        {
            FrmTecnico tela = new FrmTecnico();
            tela.ShowDialog();
        }

        private void AbrirSetores()
        {
            FrmSetor tela = new FrmSetor();
            tela.ShowDialog();
        }

        private void AbrirCategorias()
        {
            FrmGerenciadorCate tela = new FrmGerenciadorCate();
            tela.ShowDialog();
        }

        private void AbrirRelatorios()
        {
            FrmRelatorio tela = new FrmRelatorio();
            tela.ShowDialog();
        }

        private void AbrirAuditoria()
        {
            FrmAuditoria tela = new FrmAuditoria();
            tela.ShowDialog();
        }
    }
}
