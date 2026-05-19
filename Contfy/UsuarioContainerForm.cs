using Contfy.BLL;
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

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void FiltrarGrid()
        {
            dgvContainers.DataSource = ContainerAdminBLL.FiltrarContainers(txtPesquisar.Text, cbFiltroStatus.Text);
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            FiltrarGrid();
        }

        private void cbFiltroStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarGrid();
        }

        private void UsuarioContainerForm_Load_1(object sender, EventArgs e)
        {
            cbFiltroStatus.Items.Add("Todos");
            cbFiltroStatus.Items.Add("No porto");
            cbFiltroStatus.Items.Add("Em trânsito");
            cbFiltroStatus.Items.Add("Entregue");

            cbFiltroStatus.SelectedIndex = 0;
        }
    }
}
