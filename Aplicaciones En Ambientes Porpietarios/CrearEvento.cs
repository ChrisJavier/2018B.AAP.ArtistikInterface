using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Aplicaciones_En_Ambientes_Porpietarios
{
    public partial class CrearEvento : Form
    {
        BaseDeDatos bd = new BaseDeDatos();
        ValidarSoloLetrasSoloNumeros validar = new ValidarSoloLetrasSoloNumeros();
        public CrearEvento()
        {
            InitializeComponent();
            
            //cargarComboBox();
            dTPDate.Value = System.DateTime.Today;
            dTPDate.MinDate = System.DateTime.Today;
            
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de salir de la ventana?\n Se perderá todo el avance", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
            }
            
        }
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pBoxSave.Size = new Size(79, 55);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pBoxSave.Size = new Size(73, 49);
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pBoxLimpiar.Size = new Size(79, 55);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pBoxLimpiar.Size = new Size(73, 49);
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pBoxReturn.Size = new Size(79, 55);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pBoxReturn.Size = new Size(73, 49);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //AgregarEvento profesor = new AgregarEvento();
            //profesor.Show();
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Está seguro de guardar ? ", "Guardar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //guardar();
                MessageBox.Show("El evento se ha guardado exitosamente");
            }
            
                
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de limpiar la ventana ? ", "Limpiar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Limpiar();
                MessageBox.Show("La ventana se ha limpiado exitosamente");
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtAddress.Text = openFileDialog1.FileName;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(txtAddress.Text);
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pBoxEDT.Size = new Size(40, 41);
        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pBoxEDT.Size = new Size(46, 47);
        }
        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pBoxClient.Size = new Size(40, 41);
        }
        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pBoxClient.Size = new Size(46, 47);
        }
        private void guardar()
        {
            consultar();
        }
        private void consultar()
        {
           // string nombreCurso = bd.selectstring("EXEC DBO.cursoNombreNivel @nombre='" + textBox1.Text + "'");
            //string nivelCurso = bd.selectstring("EXEC DBO.cursoNivel @nivel='" + /*comboBox4.Text*/ + "'");
            
            //string[] profesor = nombres.Split(' ');
            //string nombreP = profesor[0];
            //string apellidoP = profesor[1];
            //string consultarProfesor = bd.selectstring("select INSTRUCTOR.CONINS from PERSONA inner join INSTRUCTOR on PERSONA.CODPERSONA = INSTRUCTOR.CODPERSONA WHERE APELLIDO='"+apellidoP+"'AND NOMBRE='"+nombreP+"'");
            //int codProfesor = Int32.Parse(consultarProfesor);
            //int cupo = Convert.ToInt32(numericUpDown1.Value);
            /*string registrarCurso = "EXEC dbo.IngresarCurso "+
                "@CONINS = "+codProfesor+
                ",@NOMBRE = '"+textBox1.Text+
                "',@NIVEL = '"+comboBox4.Text+
                "',@TIPO = '"+comboBox5.Text+
                "',@CUPO = "+cupo+
                ",@FECHAINICIO = '"+dateTimePicker1.Text+
                "',@FECHAFIN = '"+dateTimePicker2.Text+
                "',@SILABO = '"+textBox2.Text+
                "',@DIA = '"+comboBox1.Text+
                "',@HORA = '"+comboBox2.Text+
                "',@COSTO ="+textBox3.Text+"";
            if (textBox1.Text.Equals("")||textBox2.Text.Equals("")|| textBox3.Text.Equals("") || comboBox1.Text.Equals("") ||comboBox2.Text.Equals("")|| comboBox3.Text.Equals("")|| comboBox4.Text.Equals("")||comboBox5.Text.Equals("")||dateTimePicker1.Text.Equals("")||dateTimePicker2.Text.Equals(""))
            {
                MessageBox.Show("Error uno o mas campos vacios");
            }
            else
            {
                if (nombreCurso == textBox1.Text && nivelCurso==comboBox4.Text)
                {
                    MessageBox.Show("Datos ya registrados");
                }
                else
                {
                    MessageBox.Show(registrarCurso);
                    if (bd.executecommand(registrarCurso))
                    {
                        MessageBox.Show("Registrado");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        comboBox1.SelectedIndex=-1;
                        comboBox2.SelectedIndex = -1;
                        comboBox3.SelectedIndex = -1;
                        comboBox4.SelectedIndex = -1;
                        comboBox5.SelectedIndex = -1;
                        dateTimePicker1.Value = System.DateTime.Today;
                        dateTimePicker2.Value = System.DateTime.Today;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar");
                    }
                }
            }*/
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime();
            dateTime = dTPDate.Value;
           // dTPHDF2.MinDate = dateTime;
        }

        private void txtCodeEvent_MouseEnter(object sender, EventArgs e)
        {
            lblcode.Visible = false;
        }

        private void txtCodeEvent_MouseLeave(object sender, EventArgs e)
        {
            ComprobarTextBox(1);
        }

        private void comboBox5_MouseEnter(object sender, EventArgs e)
        {
            lblTipo.Visible = false;
        }

        private void comboBox5_MouseLeave(object sender, EventArgs e)
        {
            if (ComprobarCombos(1)==1)
            {
                lblTipo.Visible = true;
            }
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            lblAddresss.Visible = false;
        }

        private void txtAddress_MouseLeave(object sender, EventArgs e)
        {
            ComprobarTextBox(2);
        }

        private void dateTPHI_MouseEnter(object sender, EventArgs e)
        {
                lblHI.Visible = false;   
        }

        private void dateTPHI_MouseLeave(object sender, EventArgs e)
        {
            
            if (Convert.ToInt32(dateTPHI.Value.ToString("HH"))<6 || int.Parse(dateTPHI.Value.ToString("HH")) > 20)
            {
                lblHI.Visible = true;
            }
        }

        private void dTPHF_MouseEnter(object sender, EventArgs e)
        {

            lblHF.Visible = false;
        }

        private void dTPHF_MouseLeave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dTPHDF2.Value.ToString("HH")) < 7 || int.Parse(dTPHDF2.Value.ToString("HH")) > 0)
            {
                lblHF.Visible = true;
            }
            if (Convert.ToInt32(dateTPHI.Value.ToString("HH")) < 6 || int.Parse(dateTPHI.Value.ToString("HH")) > 20)
            {
                lblHI.Visible = true;
            }
        }


        private void cmbEDT_MouseEnter(object sender, EventArgs e)
        {
            lblEDTrabajo.Visible = false;
        }

        private void cmbEDT_MouseLeave(object sender, EventArgs e)
        {
            if (ComprobarCombos(3)==1)
            {
                lblEDTrabajo.Visible = true;
            }
        }

        private void cmbCli_MouseEnter(object sender, EventArgs e)
        {
            lblClient.Visible = false;
        }

        private void cmbCli_MouseLeave(object sender, EventArgs e)
        {
            if (ComprobarCombos(4) == 1)
            {
                lblClient.Visible = true;
            }
        }

        private void txtCodeEvent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar>=32 && e.KeyChar<=47) || (e.KeyChar >= 58 && e.KeyChar <= 255) )
            {
                e.Handled = true;
                return;
            }
        }

        private void pBoxEDT_MouseHover(object sender, EventArgs e)
        {
            pBoxEDT.Size = new Size(46, 37);
        }

        private void pBoxEDT_MouseLeave(object sender, EventArgs e)
        {
            pBoxEDT.Size = new Size(40, 31);
        }

        private void pictureBox6_MouseHover_1(object sender, EventArgs e)
        {
            pBoxClient.Size = new Size(46, 38);
        }

        private void pBoxClient_MouseLeave(object sender, EventArgs e)
        {
            pBoxClient.Size = new Size(40, 32);
        }

        public void Limpiar()
        {
            txtCodeEvent.Text = "";
            cmbTipo.SelectedIndex = -1;
            dTPDate.Value = DateTime.Now;
            txtAddress.Text = "";
            dateTPHI.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 6, 0, 0);
            dTPHDF2.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 7, 0, 0);
            cmbCli.SelectedIndex = -1;
            cmbEDT.SelectedIndex = -1;
        }

        public int ComprobarTextBox(int valor)
        {
            switch (valor) {
                case 1:
                    if (txtCodeEvent.Text.Equals(""))
                    {
                        lblcode.Text = "Error, Ingrese el código del evento";
                        lblcode.Visible = true;

                    }
                    else if (txtCodeEvent.Text.Length > 8)
                    {
                        lblcode.Text = "Error, Solo son admitidos 8 dígitos";
                        lblcode.Visible = true;
                        return 1;
                    }
                    break;
                case 2:
                    if (txtAddress.Text.Equals(""))
                    {
                        lblAddresss.Text = "Error, Ingrese una dirección valida";
                        lblAddresss.Visible = true;

                    }
                    else if (txtAddress.Text.Length > 10)
                    {
                        lblAddresss.Text = "Error, La dirección debe tener al menos 10 caracteres";
                        lblAddresss.Visible = true;
                        return 1;
                    }
                    break;
            }
           

            return 0;
        }
        public int ComprobarCombos(int valor)
        {
            switch (valor){
                case 1:
                    if (cmbTipo.SelectedIndex.Equals(-1))
                        return 1;
                    break;
                case 3:
                    if (cmbEDT.SelectedIndex.Equals(-1))
                        return 1;
                    break;
                case 4:
                    if (cmbCli.SelectedIndex.Equals(-1))
                        return 1;
                    break;
            }
          
            return 0;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void CrearEvento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aAP_2018DataSet1.GRUPO' Puede moverla o quitarla según sea necesario.
            AAP_2018DataSet1TableAdapters.GRUPOTableAdapter gRUPOTableAdapter1 = this.gRUPOTableAdapter;
            gRUPOTableAdapter1.Fill(aAP_2018DataSet1.GRUPO);
           

        }
    }
}
