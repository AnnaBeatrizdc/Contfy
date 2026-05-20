using Contfy.BLL;
using Contfy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Contfy.DAL;

namespace Contfy
{
    public partial class UsuarioForm : Form
    {
        public UsuarioForm()
        {
            InitializeComponent();
        }

        private void cbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            // Mostrar ou ocultar a senha com base no estado do CheckBox
            tbLoginSenha.UseSystemPasswordChar = !cbMostrarSenha.Checked;
        }

        private void lnkCriarConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Abrir a tela de cadastro
            CadastroForm telaCadastro = new CadastroForm();
            telaCadastro.Show();

            this.Hide(); // Esconder a tela de login
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            // Criar um objeto UsuarioMdl e preencher com os dados do formulário
            UsuarioMdl usuario = new UsuarioMdl();
            usuario.setEmail(tbLoginUsuario.Text);
            usuario.setSenha(tbLoginSenha.Text);

            // Validar os dados de login usando a classe UsuarioBLL
            UsuarioBLL.validaDadosLogin(usuario);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
                return;
            }
            else
            {
                // Tentar fazer login usando a classe UsuarioBLL
                usuario = UsuarioBLL.FazerLogin(usuario);
                if (usuario != null) // Verifica se o login está correto
                {
                    // Se o login for bem-sucedido, verifica o tipo de usuário e abre a tela correspondente
                    if (usuario.getTipoUsuario() == "Admin") // Se for um usuário do tipo "Admin", abre a tela de administração
                    {
                        AdminContainerForm AdminTela = new AdminContainerForm();

                        AdminTela.Show();
                    }
                    else // Se for um usuário do tipo "Usuario", abre a tela de usuário
                    {
                        UsuarioContainerForm UsuarioTela = new UsuarioContainerForm();

                        UsuarioTela.Show();
                    }

                    this.Hide();
                }
                else // Caso o login seja incorreto, exibe uma mensagem de erro
                {
                    MessageBox.Show(
                        "Email ou senha inválidos!"
                    );
                }
            }
        }

        private void UsuarioForm_Load(object sender, EventArgs e)
        {
            // Configura o TextBox de senha para ocultar os caracteres digitados por padrão
            tbLoginSenha.UseSystemPasswordChar = true;
        }
    }
}
