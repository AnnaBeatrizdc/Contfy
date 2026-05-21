using Contfy.BLL;
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
    public partial class UsuarioContainerForm : Form
    {
        public UsuarioContainerForm()
        {
            InitializeComponent();
        }

        // Metodo para filtrar os containers com base no texto de pesquisa e no status selecionado
        private void FiltrarGrid()
        {
            // Chama o método FiltrarContainers da camada BLL, passando o texto de pesquisa e o status selecionado
            dgvContainers.DataSource = ContainerAdminBLL.FiltrarContainers(txtPesquisar.Text, cbFiltroStatus.Text);
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            // Sempre que o texto de pesquisa for alterado, chama o método FiltrarGrid para atualizar a exibição dos containers
            FiltrarGrid();
        }

        private void cbFiltroStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sempre que o status selecionado for alterado, chama o método FiltrarGrid para atualizar a exibição dos containers
            FiltrarGrid();
        }

        private void UsuarioContainerForm_Load_1(object sender, EventArgs e)
        {
            // Adiciona as opções de filtro de status ao ComboBox cbFiltroStatus
            cbFiltroStatus.Items.Add("Todos");
            cbFiltroStatus.Items.Add("No porto");
            cbFiltroStatus.Items.Add("Em trânsito");
            cbFiltroStatus.Items.Add("Entregue");

            cbFiltroStatus.SelectedIndex = 0;
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            // Chama o método GerarPdfContainers da camada DAL para gerar um PDF com os containers listados
            AdminContainerDAL.GerarPdfContainers();
        }
    }
}
