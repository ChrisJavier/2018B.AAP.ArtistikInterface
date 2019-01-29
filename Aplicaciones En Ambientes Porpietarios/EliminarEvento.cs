using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicaciones_En_Ambientes_Porpietarios
{
    public partial class EliminarEvento : Form
    {
        public EliminarEvento()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pBoxSearch.Size = new Size(41, 42);
        }

        private void pBoxSearch_MouseLeave(object sender, EventArgs e)
        {
            pBoxSearch.Size = new Size(47, 48);
        }

        private void pBoxReturn_MouseHover(object sender, EventArgs e)
        {
            pBoxReturn.Size = new Size(49, 42);
        }

        private void pBoxReturn_MouseLeave(object sender, EventArgs e)
        {
            pBoxReturn.Size = new Size(55, 48);
        }

        private void pBoxDelete_MouseHover(object sender, EventArgs e)
        {
            pBoxDelete.Size = new Size(49, 42);
        }

        private void pBoxDelete_MouseLeave(object sender, EventArgs e)
        {
            pBoxDelete.Size = new Size(55, 48);
        }

        private void pBoxLimpiar_MouseHover(object sender, EventArgs e)
        {
            pBoxLimpiar.Size = new Size(49, 42);
        }

        private void pBoxLimpiar_MouseLeave(object sender, EventArgs e)
        {
            pBoxLimpiar.Size = new Size(55, 48);
        }

        private void txtValor_MouseEnter(object sender, EventArgs e)
        {
            lblSearch.Visible = false;
        }

        private void txtValor_MouseLeave(object sender, EventArgs e)
        {
            if (txtValor.Text.Equals(""))
            {
                lblSearch.Visible = true;
            }
        }

        private void cmbTipo_MouseEnter(object sender, EventArgs e)
        {
            if (cmbTipoB.SelectedIndex.Equals(-1))
            {
                lblTipo.Visible = true;
            }
        }

        private void cmbTipo_MouseLeave(object sender, EventArgs e)
        {
            lblTipo.Visible = false;
        }
    }
}
