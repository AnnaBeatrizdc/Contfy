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
            // Criar um objeto UsuarioMdl e preencher com os dados do formulário
            UsuarioMdl usuario = new UsuarioMdl();

            // Preencher o objeto usuario com os dados do formulário
            usuario.setNome(tbNome.Text);
            usuario.setTipoUsuario(cbTipoConta.Text);
            usuario.setEmail(tbEmail.Text);
            usuario.setSenha(tbSenha.Text);
            usuario.setTelefone(mtbTelefone.Text);
            usuario.setCep(mtbCEP.Text);
            usuario.setLogradouro(tbRua.Text);
            usuario.setBairro(tbBairro.Text);
            usuario.setLocalidade(tbCidade.Text);
            usuario.setUf(tbEstado.Text);

            // Validar os dados do usuário usando a classe UsuarioBLL e exibir mensagens de erro ou sucesso
            UsuarioBLL.ValidaDadosCadastro(usuario, 'I');
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
                return;
            }
            else
            {
                // Se os dados forem válidos, inserir o usuário no banco de dados usando a classe UsuarioDAL e exibir uma mensagem de sucesso
                MessageBox.Show("Cadastro realizado com sucesso!");
                this.Close();
                UsuarioForm telaUsuario = new UsuarioForm();
                telaUsuario.Show();
            }

            
        }

        private void mtbCEP_Leave(object sender, EventArgs e)
        {
            
        }

        private void cbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            // Mostrar ou ocultar a senha com base no estado do CheckBox
            tbSenha.UseSystemPasswordChar = !cbMostrarSenha.Checked;
        }

        private void CadastroForm_Load(object sender, EventArgs e)
        {
            // Configura o TextBox de senha para ocultar os caracteres digitados por padrão
            tbSenha.UseSystemPasswordChar = true;
        }

        private void mtbCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Quando o usuário sair do campo de CEP, buscar as informações do endereço usando a classe CepBLL e preencher os campos de rua, bairro, cidade e estado
            UsuarioMdl cep = CepBLL1.BuscarCEP(mtbCEP.Text);

            tbRua.Text = cep.getLogradouro();
            tbBairro.Text = cep.getBairro();
            tbCidade.Text = cep.getLocalidade();
            tbEstado.Text = cep.getUf();
        }
    }
}
