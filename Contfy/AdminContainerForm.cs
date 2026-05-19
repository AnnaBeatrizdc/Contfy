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

namespace Contfy
{
    public partial class AdminContainerForm : Form
    {
        public AdminContainerForm()
        {
            InitializeComponent();

            this.Load += AdminContainerForm_Load;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ContainerMdl container = new ContainerMdl();

            container.setCodigo(tbCodigo.Text);
            container.setNome(tbNome.Text);
            container.setStatus(cbStatus.Text);
            container.setLocalizacao(tbLocalizacao.Text);
            container.setResponsavel(tbResponsavel.Text);

            ContainerAdminBLL.validaDadosAdicionar(container, 'I');

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
                return;
            }
            else
            {
                MessageBox.Show("Cadastro do container realizado com sucesso!");
                
                tbCodigo.Clear();
                tbNome.Clear();
                cbStatus.Text = "";
                tbLocalizacao.Clear();
                tbResponsavel.Clear();
                CarregarGrid();

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ContainerMdl container = new ContainerMdl();

            container.setCodigo(tbCodigo.Text);

            container.setNome(tbNome.Text);

            container.setStatus(cbStatus.Text);

            container.setLocalizacao(tbLocalizacao.Text);

            container.setResponsavel(tbResponsavel.Text);

            ContainerAdminBLL.validaDadosAlterar(container, 'U');

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
                return;
            }

            MessageBox.Show("Container alterado com sucesso!");

            CarregarGrid();
        
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ContainerMdl container = new ContainerMdl();

            container.setCodigo(tbCodigo.Text);

            ContainerAdminBLL.validaDadosDeletar(container, 'D');

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
                return;
            }
            else
            {
                MessageBox.Show("Exclusão do container realizada com sucesso!");

                CarregarGrid();

                tbCodigo.Clear();
                tbNome.Clear();
                cbStatus.Text = "";
                tbLocalizacao.Clear();
                tbResponsavel.Clear();
            }
        }

        private void dgvContainer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CarregarGrid()
        {
            dgvContainer.DataSource = ContainerAdminBLL.ListarContainers();
        }

        private void AdminContainerForm_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void dgvContainer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                tbCodigo.Text =
                dgvContainer.Rows[e.RowIndex]
                .Cells["Codigo"]
                .Value.ToString();

                tbNome.Text =
                dgvContainer.Rows[e.RowIndex]
                .Cells["Nome"]
                .Value.ToString();

                cbStatus.Text =
                dgvContainer.Rows[e.RowIndex]
                .Cells["Status"]
                .Value.ToString();

                tbLocalizacao.Text =
                dgvContainer.Rows[e.RowIndex]
                .Cells["Localizacao"]
                .Value.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ContainerMdl container = ContainerAdminBLL.BuscarPorCodigo(tbCodigo.Text);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
                return;
            }

            if (container == null)
            {
                MessageBox.Show("Container não encontrado.");
                return;
            }

            tbNome.Text = container.getNome();

            cbStatus.Text = container.getStatus();

            tbLocalizacao.Text = container.getLocalizacao();

            tbResponsavel.Text = container.getResponsavel();
        }
    }
}
