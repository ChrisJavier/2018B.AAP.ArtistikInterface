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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
           
        }

        private void pBCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Turismo2 turismo = new Turismo2();
            turismo.Show();
            this.Hide();
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Evento cursos = new Evento();
            cursos.Show();
            this.Hide();
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Proveedores facturaccion = new Proveedores();
            facturaccion.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ModuloAdministracion cultura = new ModuloAdministracion();
            cultura.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ModuloClientes cliente = new ModuloClientes();
            cliente.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void crearClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearCliente Form = new CrearCliente();
            Form.TopLevel = false;
            Form.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Size = new Size(763, 420);
            panel1.Location = new Point(50, 100);
            panel1.Controls.Add(Form);
            Form.Dock = DockStyle.Left;
            Form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Form.Show();
        }

        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarCliente Form = new ModificarCliente();
            Form.TopLevel = false;
            Form.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Size = new Size(763, 420);
            panel1.Location = new Point(50, 100);
            panel1.Controls.Add(Form);
            Form.Dock = DockStyle.Left;
            Form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Form.Show();
        }

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarCliente FormB = new BuscarCliente();
            FormB.TopLevel = false;
            FormB.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Size = new Size(763, 420);
            panel1.Location = new Point(50, 100);
            panel1.Controls.Add(FormB);
            FormB.Dock = DockStyle.Left;
            FormB.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FormB.Show();
        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarCliente FormE = new EliminarCliente();
            FormE.TopLevel = false;
            FormE.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Size = new Size(763, 420);
            panel1.Location = new Point(50, 100);
            panel1.Controls.Add(FormE);
            FormE.Dock = DockStyle.Left;
            FormE.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FormE.Show();
        }

        private void crearEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearEvento FormCE = new CrearEvento();
            FormCE.TopLevel = false;
            FormCE.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Size = new Size(763, 420);
            panel1.Location = new Point(50, 100);
            panel1.Controls.Add(FormCE);
            FormCE.Dock = DockStyle.Left;
            FormCE.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FormCE.Show();
        }

        private void modificarEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarEventos FormCM = new ModificarEventos();
            FormCM.TopLevel = false;
            FormCM.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Size = new Size(763, 420);
            panel1.Location = new Point(50, 100);
            panel1.Controls.Add(FormCM);
            FormCM.Dock = DockStyle.Left;
            FormCM.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FormCM.Show();
        }

        private void consultarEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarEventos FormCE = new BuscarEventos();
            FormCE.TopLevel = false;
            FormCE.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Size = new Size(763, 420);
            panel1.Location = new Point(50, 100);
            panel1.Controls.Add(FormCE);
            FormCE.Dock = DockStyle.Left;
            FormCE.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FormCE.Show();
        }

        private void eliminarEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarEvento FormEE = new EliminarEvento();
            FormEE.TopLevel = false;
            FormEE.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Size = new Size(763, 420);
            panel1.Location = new Point(50, 100);
            panel1.Controls.Add(FormEE);
            FormEE.Dock = DockStyle.Left;
            FormEE.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FormEE.Show();
        }

        private void crearProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearProveedor FormCP = new CrearProveedor();
            FormCP.TopLevel = false;
            FormCP.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Size = new Size(763, 420);
            panel1.Location = new Point(50, 100);
            panel1.Controls.Add(FormCP);
            FormCP.Dock = DockStyle.Left;
            FormCP.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FormCP.Show();
        }

        private void modifiacarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarProveedor FormEE = new ModificarProveedor();
            FormEE.TopLevel = false;
            FormEE.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Size = new Size(763, 420);
            panel1.Location = new Point(50, 100);
            panel1.Controls.Add(FormEE);
            FormEE.Dock = DockStyle.Left;
            FormEE.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FormEE.Show();
        }

        private void consultarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarProveedor FormCP = new BuscarProveedor();
            FormCP.TopLevel = false;
            FormCP.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Size = new Size(763, 420);
            panel1.Location = new Point(50, 100);
            panel1.Controls.Add(FormCP);
            FormCP.Dock = DockStyle.Left;
            FormCP.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FormCP.Show();
        }

        private void eliminarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarProveedor FormEP = new BuscarProveedor();
            FormEP.TopLevel = false;
            FormEP.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Size = new Size(763, 420);
            panel1.Location = new Point(50, 100);
            panel1.Controls.Add(FormEP);
            FormEP.Dock = DockStyle.Left;
            FormEP.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FormEP.Show();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoUsuario FormEE = new NuevoUsuario();
            FormEE.TopLevel = false;
            FormEE.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Size = new Size(763, 420);
            panel1.Location = new Point(50, 100);
            panel1.Controls.Add(FormEE);
            FormEE.Dock = DockStyle.Left;
            FormEE.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FormEE.Show();
        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarUsuario FormEE = new ModificarUsuario();
            FormEE.TopLevel = false;
            FormEE.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Size = new Size(763, 420);
            panel1.Location = new Point(50, 100);
            panel1.Controls.Add(FormEE);
            FormEE.Dock = DockStyle.Left;
            FormEE.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FormEE.Show();
        }

        private void consultarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarUsuario FormEE = new BuscarUsuario();
            FormEE.TopLevel = false;
            FormEE.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Size = new Size(763, 420);
            panel1.Location = new Point(50, 100);
            panel1.Controls.Add(FormEE);
            FormEE.Dock = DockStyle.Left;
            FormEE.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FormEE.Show();
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarUsuario FormEE = new EliminarUsuario();
            FormEE.TopLevel = false;
            FormEE.AutoScroll = true;
            panel1.Controls.Clear();
            //panel1.Size = new Size(763, 420);
            //panel1.Location = new Point(50, 100);
            panel1.Controls.Add(FormEE);
            FormEE.Dock = DockStyle.Left;
            FormEE.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FormEE.Show();
        }

        private void crearFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearFactura FormEE = new CrearFactura();
            FormEE.TopLevel = false;
            FormEE.AutoScroll = true;
            panel1.Controls.Clear();
            //panel1.Size = new Size(800, 800);
            panel1.Location = new Point(0, 150);
            panel1.Controls.Add(FormEE);
            FormEE.Dock = DockStyle.Left;
            FormEE.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FormEE.Show();
        }

        private void modificarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarFactura FormEE = new ModificarFactura();
            FormEE.TopLevel = false;
            FormEE.AutoScroll = true;
            panel1.Controls.Clear();
            //panel1.Size = new Size(800, 800);
            panel1.Location = new Point(0, 100);
            panel1.Controls.Add(FormEE);
            FormEE.Dock = DockStyle.Left;
            FormEE.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FormEE.Show();
        }

        private void consultarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarFactura FormEE = new ConsultarFactura();
            FormEE.TopLevel = false;
            FormEE.AutoScroll = true;
            panel1.Controls.Clear();
            //panel1.Size = new Size(800, 800);
            //panel1.Location = new Point(50, 100);
            panel1.Controls.Add(FormEE);
            FormEE.Dock = DockStyle.Left;
            FormEE.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FormEE.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CrearEmpleado FormEE = new CrearEmpleado();
            FormEE.TopLevel = false;
            FormEE.AutoScroll = true;
            panel1.Controls.Clear();
            //panel1.Size = new Size(800, 800);
            //panel1.Location = new Point(50, 100);
            panel1.Controls.Add(FormEE);
            FormEE.Dock = DockStyle.Left;
            FormEE.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FormEE.Show();
        }

        private void eliminarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnularFactura FormEE = new AnularFactura();
            FormEE.TopLevel = false;
            FormEE.AutoScroll = true;
            panel1.Controls.Clear();
            //panel1.Size = new Size(800, 800);
            //panel1.Location = new Point(50, 100);
            panel1.Controls.Add(FormEE);
            FormEE.Dock = DockStyle.Left;
            FormEE.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FormEE.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ModificarEmpleado FormEE = new ModificarEmpleado();
            FormEE.TopLevel = false;
            FormEE.AutoScroll = true;
            panel1.Controls.Clear();
            //panel1.Size = new Size(800, 800);
            //panel1.Location = new Point(50, 100);
            panel1.Controls.Add(FormEE);
            FormEE.Dock = DockStyle.Left;
            FormEE.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FormEE.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            BuscarEmpleado FormEE = new BuscarEmpleado();
            FormEE.TopLevel = false;
            FormEE.AutoScroll = true;
            panel1.Controls.Clear();
            //panel1.Size = new Size(800, 800);
            //panel1.Location = new Point(50, 100);
            panel1.Controls.Add(FormEE);
            FormEE.Dock = DockStyle.Left;
            FormEE.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FormEE.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            EliminarEmpleado FormEE = new EliminarEmpleado();
            FormEE.TopLevel = false;
            FormEE.AutoScroll = true;
            panel1.Controls.Clear();
            //panel1.Size = new Size(800, 800);
            //panel1.Location = new Point(50, 100);
            panel1.Controls.Add(FormEE);
            FormEE.Dock = DockStyle.Left;
            FormEE.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FormEE.Show();
        }

        private void crearParámetroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearParametro FormEE = new CrearParametro();
            FormEE.TopLevel = false;
            FormEE.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Size = new Size(800, 800);
            panel1.Location = new Point(50, 100);
            panel1.Controls.Add(FormEE);
            FormEE.Dock = DockStyle.Left;
            FormEE.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FormEE.Show();
        }

        private void modificarParámetroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarParametro FormEE = new ModificarParametro();
            FormEE.TopLevel = false;
            FormEE.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Size = new Size(800, 800);
            panel1.Location = new Point(50, 100);
            panel1.Controls.Add(FormEE);
            FormEE.Dock = DockStyle.Left;
            FormEE.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FormEE.Show();
        }

        private void consultarParámetroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarParametro FormEE = new ConsultarParametro();
            FormEE.TopLevel = false;
            FormEE.AutoScroll = true;
            panel1.Controls.Clear();
            //panel1.Size = new Size(800, 800);
            //panel1.Location = new Point(50, 100);
            panel1.Controls.Add(FormEE);
            FormEE.Dock = DockStyle.Left;
            FormEE.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FormEE.Show();
        }

        private void eliminarParámetroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarParametro FormEE = new EliminarParametro();
            FormEE.TopLevel = false;
            FormEE.AutoScroll = true;
            panel1.Controls.Clear();
            //panel1.Size = new Size(800, 800);
            //panel1.Location = new Point(50, 100);
            panel1.Controls.Add(FormEE);
            FormEE.Dock = DockStyle.Left;
            FormEE.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FormEE.Show();
        }
    }
}
