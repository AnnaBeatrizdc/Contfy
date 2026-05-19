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
            tbLoginSenha.UseSystemPasswordChar = !cbMostrarSenha.Checked;
        }

        private void lnkCriarConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastroForm telaCadastro = new CadastroForm();
            telaCadastro.Show();
            this.Hide();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            UsuarioMdl usuario = new UsuarioMdl();
            usuario.setEmail(tbLoginUsuario.Text);
            usuario.setSenha(tbLoginSenha.Text);

            UsuarioBLL.validaDadosLogin(usuario);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
                return;
            }
            else
            {
                usuario = UsuarioBLL.FazerLogin(usuario);
                if (usuario != null)
                {
                    if (usuario.getTipoUsuario() == "Admin")
                    {
                        AdminContainerForm AdminTela = new AdminContainerForm();

                        AdminTela.Show();
                    }
                    else
                    {
                        UsuarioContainerForm UsuarioTela = new UsuarioContainerForm();

                        UsuarioTela.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "Email ou senha inválidos!"
                    );
                }
            }
        }

        private void UsuarioForm_Load(object sender, EventArgs e)
        {
            tbLoginSenha.UseSystemPasswordChar = true;
        }
    }
}
