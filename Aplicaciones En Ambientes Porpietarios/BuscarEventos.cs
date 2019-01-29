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
    public partial class BuscarEventos : Form
    {
        public BuscarEventos()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //buscar();
        }
        private void buscar()
        {
            if (cmbTipoB.Text.Equals("Nombre"))
            {
                string consultar = "SELECT * FROM CURSO WHERE NOMBRE ='" + txtSearch.Text + "'";
                dataGridView1.DataSource = bd.SelectDataTable(consultar);
            }
            else if (cmbTipoB.Text.Equals("Nivel"))
            {
                string consultar = "SELECT * FROM CURSO WHERE NIVEL ='" + txtSearch.Text + "'";
                dataGridView1.DataSource = bd.SelectDataTable(consultar);
            }
            else if (cmbTipoB.Text.Equals("Tipo"))
            {
                string consultar = "SELECT * FROM CURSO WHERE TIPO ='" + txtSearch.Text + "'";
                dataGridView1.DataSource = bd.SelectDataTable(consultar);
            }
            else if (cmbTipoB.Text.Equals("Día"))
            {
                string consultar = "SELECT * FROM CURSO WHERE DIA ='" + txtSearch.Text + "'";
                dataGridView1.DataSource = bd.SelectDataTable(consultar);
            }
            else if (cmbTipoB.Text.Equals("Hora"))
            {
                string consultar = "SELECT * FROM CURSO WHERE HORA ='" + txtSearch.Text + "'";
                dataGridView1.DataSource = bd.SelectDataTable(consultar);
            }

        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pBoxReturn.Size = new Size(49, 42);
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pBoxReturn.Size = new Size(55, 48);
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(55, 37);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(49, 31);
        }

        private void txtSearch_MouseEnter(object sender, EventArgs e)
        {
            lblSearch.Visible = false;
        }

        private void txtSearch_MouseLeave(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(""))
            {
                lblSearch.Visible = true;
            }
        }

        private void cmbTipoB_MouseEnter(object sender, EventArgs e)
        {
            lblTipo.Visible = false;
        }

        private void cmbTipoB_MouseLeave(object sender, EventArgs e)
        {
            if (cmbTipoB.SelectedIndex.Equals(-1))
            {
                lblTipo.Visible = true;
            }
        }

        private void pBoxLimpiar_MouseHover(object sender, EventArgs e)
        {
            pBoxLimpiar.Size = new Size(55, 55);
        }

        private void pBoxLimpiar_MouseLeave(object sender, EventArgs e)
        {
            pBoxLimpiar.Size = new Size(49, 49);
        }

        private void pBoxLimpiar_Click(object sender, EventArgs e)
        {
            cmbTipoB.SelectedIndex = -1;
            txtSearch.Text = "";
        }
    }
}
