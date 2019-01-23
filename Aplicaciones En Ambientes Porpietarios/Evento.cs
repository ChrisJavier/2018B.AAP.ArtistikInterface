using Microsoft.Reporting.WebForms;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
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
   
    public partial class Evento : Form
    {
        public Evento()
        {
            InitializeComponent();
            
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarEvento buscarCurso = new ModificarEvento();
            buscarCurso.TopLevel = false;
            buscarCurso.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(buscarCurso);
            buscarCurso.Dock = DockStyle.Left;
            buscarCurso.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            buscarCurso.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu mainMenu = new Menu();
            mainMenu.Show();
            this.Hide();

        }

        private void ingresarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearEvento cursoNuevo = new CrearEvento();
            cursoNuevo.TopLevel = false;
            cursoNuevo.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(cursoNuevo);
            cursoNuevo.Dock = DockStyle.Left;
            cursoNuevo.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            cursoNuevo.Show();
            
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoUsuario alumnoNuevo = new NuevoUsuario();
            alumnoNuevo.TopLevel = false;
            alumnoNuevo.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(alumnoNuevo);
            alumnoNuevo.Dock = DockStyle.Left;
            alumnoNuevo.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            alumnoNuevo.Show();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(54,54);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(48, 48);
        }

        private void actualizarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarEvento buscarCurso = new AgregarEvento();
            buscarCurso.TopLevel = false;
            buscarCurso.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(buscarCurso);
            buscarCurso.Dock = DockStyle.Left;
            buscarCurso.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            buscarCurso.Show();
        }

        private void buscarProfesoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarEventos buscarProfesor = new BuscarEventos();
            buscarProfesor.TopLevel = false;
            buscarProfesor.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(buscarProfesor);
            buscarProfesor.Dock = DockStyle.Left;
            buscarProfesor.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            buscarProfesor.Show();
        }

        private void buscarCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarEventos buscarCurso = new BuscarEventos();
            buscarCurso.TopLevel = false;
            buscarCurso.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(buscarCurso);
            buscarCurso.Dock = DockStyle.Left;
            buscarCurso.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            buscarCurso.Show();
        }

        private void asignarAlCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearEvento buscarCurso = new CrearEvento();
            buscarCurso.TopLevel = false;
            buscarCurso.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(buscarCurso);
            buscarCurso.Dock = DockStyle.Left;
            buscarCurso.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            buscarCurso.Show();
        }

        private void eliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EliminarUsuario eliminarProfesor = new EliminarUsuario();
            eliminarProfesor.TopLevel = false;
            eliminarProfesor.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(eliminarProfesor);
            eliminarProfesor.Dock = DockStyle.Left;
            eliminarProfesor.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            eliminarProfesor.Show();
        }

        private void alumnosPorCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*ReportesAlumnos reportesAlumnos = new ReportesAlumnos();
            reportesAlumnos.TopLevel = false;
            reportesAlumnos.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(reportesAlumnos);
            reportesAlumnos.Dock = DockStyle.Left;
            reportesAlumnos.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            reportesAlumnos.Show();*/
        }

        private void profesorPorCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*ReportesProfesores reportesProfesores = new ReportesProfesores();
            reportesProfesores.TopLevel = false;
            reportesProfesores.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(reportesProfesores);
            reportesProfesores.Dock = DockStyle.Left;
            reportesProfesores.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            reportesProfesores.Show();*/
        }

        private void horariosDeCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*ReportesHorarios reportesHorarios = new ReportesHorarios();
            reportesHorarios.TopLevel = false;
            reportesHorarios.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(reportesHorarios);
            reportesHorarios.Dock = DockStyle.Left;
            reportesHorarios.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            reportesHorarios.Show();*/
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarCliente eliminarNuevo = new EliminarCliente();
            eliminarNuevo.TopLevel = false;
            eliminarNuevo.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(eliminarNuevo);
            eliminarNuevo.Dock = DockStyle.Left;
            eliminarNuevo.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            eliminarNuevo.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarUsuario facturaNueva = new EliminarUsuario();
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
