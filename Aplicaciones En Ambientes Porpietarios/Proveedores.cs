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
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu mainMenu = new Menu();
            mainMenu.Show();
            this.Hide();
        }

        private void nuevaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearProveedor facturaNueva = new CrearProveedor();
            facturaNueva.TopLevel = false;
            facturaNueva.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(facturaNueva);
            facturaNueva.Dock = DockStyle.Left;
            facturaNueva.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            facturaNueva.Show();
        }

        private void consultarPorveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarProveedor facturaNueva = new BuscarProveedor();
            facturaNueva.TopLevel = false;
            facturaNueva.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(facturaNueva);
            facturaNueva.Dock = DockStyle.Left;
            facturaNueva.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            facturaNueva.Show();
        }

        private void modificarInformaciónProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarProveedor facturaNueva = new ModificarProveedor();
            facturaNueva.TopLevel = false;
            facturaNueva.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(facturaNueva);
            facturaNueva.Dock = DockStyle.Left;
            facturaNueva.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            facturaNueva.Show();
        }

        private void eliminarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarProveedor facturaNueva = new EliminarProveedor();
            facturaNueva.TopLevel = false;
            facturaNueva.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(facturaNueva);
            facturaNueva.Dock = DockStyle.Left;
            facturaNueva.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            facturaNueva.Show();
        }
    }
}
