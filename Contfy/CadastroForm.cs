using Contfy.BLL;
using Contfy.BLL.Utils;
using Contfy.DAL;
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

namespace Contfy
{
    public partial class CadastroForm : Form
    {
        public CadastroForm()
        {
            InitializeComponent();
        }
        private void btnCCriarConta_Click(object sender, EventArgs e)
        {

            UsuarioMdl usuario = new UsuarioMdl();

            usuario.setNome(tbNome.Text);
            usuario.setUsuario(tbUsuario.Text);
            usuario.setEmail(tbEmail.Text);
            usuario.setSenha(tbSenha.Text);
            usuario.setTelefone(mtbTelefone.Text);
            usuario.setLogradouro(tbRua.Text);
            usuario.setBairro(tbBairro.Text);
            usuario.setLocalidade(tbCidade.Text);
            usuario.setUf(tbEstado.Text);

            UsuarioBLL.ValidaDadosCadastro(usuario, 'i');

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
                return;
            }
            else
            {
                MessageBox.Show("Cadastro realizado com sucesso!");

                // ABRIR LOGIN
                UsuarioForm tela = new UsuarioForm();
                tela.Show();

                // FECHAR CADASTRO
                this.Close();


                //VERIFICA SE É USUARIO OU ADMIN E DIRECIONA PARA O FORM CONRRESPONDENTE
                UsuarioMdl usuario =
                UsuarioBLL.FazerLogin(
                txtEmail.Text,
                txtSenha.Text);

                if(usuario != null)
{
                if(usuario.getTipoUsuario() == "ADMIN")
            {
                AdminContainerForm tela =
                    new AdminContainerForm();

                    tela.Show();
            }
                else
            {
                UsuarioContainerForm tela =
                    new UsuarioContainerForm();

                    tela.Show();
            }

                    this.Hide();
                }
            else
                {
                    MessageBox.Show("Usuário ou senha inválidos");
                }

            }
        }

        private void mtbCEP_Leave(object sender, EventArgs e)
        {
            UsuarioMdl cep = CepBLL1.BuscarCEP(mtbCEP.Text);

            tbRua.Text = cep.getLogradouro();
            tbBairro.Text = cep.getBairro();
            tbCidade.Text = cep.getLocalidade();
            tbEstado.Text = cep.getUf();

        }s

        
    }
}
