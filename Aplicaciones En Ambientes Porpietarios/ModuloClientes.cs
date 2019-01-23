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
    public partial class ModuloClientes : Form
    {
        public ModuloClientes()
        {
            InitializeComponent();
        }

        private void nuevoTallerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearCliente crearEstudiante = new CrearCliente();
            crearEstudiante.TopLevel = false;
            crearEstudiante.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Size = new Size(763, 420);
            panel1.Location = new Point(50, 100);
            panel1.Controls.Add(crearEstudiante);
            crearEstudiante.Dock = DockStyle.Left;
            crearEstudiante.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            crearEstudiante.Show();
        }

        private void nuevoTalleristaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearParticipante crearParticipante = new CrearParticipante();
            crearParticipante.TopLevel = false;
            crearParticipante.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(crearParticipante);
            crearParticipante.Dock = DockStyle.Left;
            crearParticipante.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            crearParticipante.Show();
        }

        private void nuevoTuristaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearProveedor crearTurista = new CrearProveedor();
            crearTurista.TopLevel = false;
            crearTurista.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(crearTurista);
            crearTurista.Dock = DockStyle.Left;
            crearTurista.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            crearTurista.Show();
        }

        private void modificarTallerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarCliente modificarEstudiante = new ModificarCliente();
            modificarEstudiante.TopLevel = false;
            modificarEstudiante.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(modificarEstudiante);
            modificarEstudiante.Dock = DockStyle.Left;
            modificarEstudiante.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            modificarEstudiante.Show();
        }

        private void modificarTalleristaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarUsuario modificarParticipante = new ModificarUsuario();
            modificarParticipante.TopLevel = false;
            modificarParticipante.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(modificarParticipante);
            modificarParticipante.Dock = DockStyle.Left;
            modificarParticipante.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            modificarParticipante.Show();
        }

        private void modificarTuristaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarProveedor modificarTurista = new ModificarProveedor();
            modificarTurista.TopLevel = false;
            modificarTurista.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(modificarTurista);
            modificarTurista.Dock = DockStyle.Left;
            modificarTurista.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            modificarTurista.Show();
        }

        private void pBCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu mainMenu = new Menu();
            mainMenu.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Menu mainMenu = new Menu();
            mainMenu.Show();
            this.Hide();
        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarCliente facturaNueva = new EliminarCliente();
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
