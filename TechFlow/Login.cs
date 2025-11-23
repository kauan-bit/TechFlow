using System;
using System.Windows.Forms;
using TechFlow.Data;
using TechFlow.Models;

namespace TechFlow
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (email == "" || senha == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UsuarioDAO dao = new UsuarioDAO();
            Usuario usuarioLogado = dao.Login(email, senha); // <-- CORRIGIDO

            if (usuarioLogado == null)
            {
                MessageBox.Show("E-mail ou senha incorretos!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica se é administrador
            if (usuarioLogado.Perfil != "Administrador")
            {
                MessageBox.Show(
                    "Apenas Administradores podem acessar o sistema Desktop.",
                    "Acesso Negado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop
                );
                return;
            }

            // LOGIN OK
            MessageBox.Show($"Bem-vindo, {usuarioLogado.Nome}!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Abrir Dashboard
            Dashboard tela = new Dashboard(usuarioLogado);
            tela.Show();
            this.Hide();
        }
    }
}
