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
    public partial class ModificarEventos : Form
    {
        BaseDeDatos bd = new BaseDeDatos();
        ValidarSoloLetrasSoloNumeros validar = new ValidarSoloLetrasSoloNumeros();
        public ModificarEventos()
        {
            InitializeComponent();
            //cargarComboBox();

            //dateTimePicker1.Value = System.DateTime.Today;
            //dateTimePicker2.Value = System.DateTime.Today;
            // dateTimePicker1.MinDate = System.DateTime.Today;
            //comboBox3.SelectedIndex = -1;
            // textBox4.Text = "";

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // panel1.Visible = true;
            //panel1.BringToFront();
            //panel1.Location = new Point(90,90);

            //dataGridView1.DataSource = bd.SelectDataTable("SELECT * FROM CURSO");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // panel1.Visible = false;
            cmbCoord.SelectedIndex = -1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            guardar();
        }
        private void guardar()
        {
            consultar();
        }
        private void consultar()
        {
            /* string consultarCurso = bd.selectstring("SELECT CODCURSO FROM CURSO WHERE NOMBRE='" + textBox1.Text + "'");
             int codCurso = Int32.Parse(consultarCurso);
             string nombres = comboBox3.Text;
             string[] profesor = nombres.Split(' ');
             string nombreP = profesor[0];
             string apellidoP = profesor[1];
             string pago = textBox5.Text;
             string[] sueldo = pago.Split(',');
             string salario = sueldo[0] + "." + sueldo[1];
             string consultarProfesor = bd.selectstring("select INSTRUCTOR.CONINS from PERSONA inner join INSTRUCTOR on PERSONA.CODPERSONA = INSTRUCTOR.CODPERSONA where APELLIDO = '" + apellidoP + "' AND NOMBRE ='" + nombreP + "'");
             int codProfesor = Int32.Parse(consultarProfesor);

             int cupo = Convert.ToInt32(numericUpDown1.Value);
             string actualizarCurso = "exec dbo.ActualizarCurso " +
                                     "@CONINS = "+codProfesor+"" +
                                    ",@NOMBRE = '"+textBox1.Text+"'" +
                                    ",@NIVEL = '"+comboBox4.Text+"'" +
                                    ",@TIPO = '"+comboBox5.Text+"'" +
                                    ",@CUPO = "+cupo+"" +
                                    ",@FECHAINICIO = '"+dateTimePicker1.Text+"'"+
                                    ",@FECHAFIN = '"+dateTimePicker2.Text+"'"+
                                    ",@SILABO = '"+textBox2.Text+"'"+
                                    ",@DIA = '"+comboBox1.Text+"'"+
                                    ",@HORA = '"+comboBox2.Text+"'"+
                                    ",@COSTO = "+salario+"";
             MessageBox.Show(actualizarCurso);
             if (bd.executecommand(actualizarCurso))
             {
                 MessageBox.Show("Datos actualizados exitosamente");
                 textBox1.Text = "";
                 textBox2.Text = "";
                 textBox3.Text = "";
                 textBox4.Text = "";
                 textBox5.Text = "";
                 comboBox1.SelectedIndex = -1;
                 comboBox2.SelectedIndex = -1;
                 comboBox3.SelectedIndex = -1;
                 comboBox4.SelectedIndex = -1;
                 comboBox5.SelectedIndex = -1;
                 dateTimePicker1.Value = System.DateTime.Today;
                 dateTimePicker2.Value = System.DateTime.Today;
                 numericUpDown1.Value = 1;
             }
             else
             {
                 MessageBox.Show("Error al actualizar");
             }*/
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            AgregarEvento profesor = new AgregarEvento();
            profesor.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtAddress.Text = openFileDialog1.FileName;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(txtAddress.Text);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pBoxSearch.Size = new Size(35, 29);
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pBoxSearch.Size = new Size(41, 35);
        }


        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pBoxCoor.Size = new Size(40, 41);
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pBoxCoor.Size = new Size(46, 47);
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pBoxCliente.Size = new Size(40, 41);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pBoxCliente.Size = new Size(46, 47);
        }
        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pBoxReturn.Size = new Size(73, 49);
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pBoxReturn.Size = new Size(79, 55);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pBoxUpdate.Size = new Size(73, 49);
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pBoxUpdate.Size = new Size(79, 55);
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            //buscar();

        }
        /* private void buscar()
         {
             if (comboBox6.Text.Equals("Nombre"))
             {
                 string consultar = "SELECT * FROM CURSO WHERE NOMBRE ='" + textBox3.Text + "'";
                 dataGridView1.DataSource = bd.SelectDataTable(consultar);
             }
             else if (comboBox6.Text.Equals("Nivel"))
             {
                 string consultar = "SELECT * FROM CURSO WHERE NIVEL ='" + textBox3.Text + "'";
                 dataGridView1.DataSource = bd.SelectDataTable(consultar);
             }
             else if (comboBox6.Text.Equals("Tipo"))
             {
                 string consultar = "SELECT * FROM CURSO WHERE TIPO ='" + textBox3.Text + "'";
                 dataGridView1.DataSource = bd.SelectDataTable(consultar);
             }
        */
        private void cargarComboBox()
        {
            cmbCoord.ValueMember = "NOMBRES";
            string nombreProfesores = "select (replace(NOMBRE,' ', '')+' '+REPLACE(APELLIDO,' ', '')) as NOMBRES from INSTRUCTOR INNER JOIN PERSONA ON INSTRUCTOR.CODPERSONA=PERSONA.CODPERSONA";
            cmbCoord.DataSource = bd.SelectDataTable(nombreProfesores);
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime();
            dateTime = dTPDate.Value;
            dTPHDI.MinDate = dateTime;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridViewRow dgv = dataGridView1.Rows[e.RowIndex];
            //string profesor = dgv.Cells[1].Value.ToString();
            /*textBox4.Text = nombres(profesor);
            textBox1.Text = dgv.Cells[2].Value.ToString();
            string nivel=dgv.Cells[3].Value.ToString();
            comboBox4.SelectedIndex = level(nivel);
            string tipo = dgv.Cells[4].Value.ToString();
            comboBox5.SelectedIndex = kind(tipo);
            numericUpDown1.Value = Int32.Parse(dgv.Cells[5].Value.ToString());
            dateTimePicker1.Text = dgv.Cells[6].Value.ToString();
            dateTimePicker2.Text = dgv.Cells[7].Value.ToString();
            textBox2.Text = dgv.Cells[8].Value.ToString();
            string dia = dgv.Cells[9].Value.ToString();
            comboBox1.SelectedIndex = day(dia);
            string hora = dgv.Cells[10].Value.ToString();
            textBox5.Text= dgv.Cells[11].Value.ToString();
            comboBox2.SelectedIndex = hours(hora);
            textBox1.Enabled = false;*/

        }
        private string nombres(string profe)
        {
            string name = bd.selectstring("select (replace(NOMBRE,' ', '')+' '+REPLACE(APELLIDO,' ', '')) as NOMBRES from INSTRUCTOR INNER JOIN PERSONA ON INSTRUCTOR.CODPERSONA=PERSONA.CODPERSONA WHERE CONINS =" + profe + "");
            return name;
        }
        private int level(string nivel)
        {
            int index = 0;
            if (nivel == "Basico                                            ")
            {
                index = 0;
            }
            else if (nivel == "Intermedio                                        ")
            {
                index = 1;
            }
            else if (nivel == "Avanzado                                          ")
            {
                index = 2;
            }
            else if (nivel == "Academico                                         ")
            {
                index = 3;
            }
            return index;
        }
        private int kind(string tipo)
        {
            int index = 0;
            if (tipo == "Nacional                                          ")
            {
                index = 0;
            }
            else if (tipo == "Extranjeros                                       ")
            {
                index = 1;
            }
            return index;
        }
        private int day(string dia)
        {
            string[] d = dia.Split(' ');
            int index = 0;
            if (d[0] == "Lunes")
            {
                index = 0;
            }
            else if (d[0] == "Martes")
            {
                index = 1;
            }
            else if (d[0] == "Miercoles")
            {
                index = 2;
            }
            else if (d[0] == "Jueves")
            {
                index = 3;
            }
            else if (d[0] == "Viernes")
            {
                index = 4;
            }
            else if (d[0] == "Sabados")
            {
                index = 5;
            }
            return index;
        }
        private int hours(string hora)
        {
            string[] d = hora.Split(' ');
            int index = 0;
            if (d[0] == "9-11")
            {
                index = 0;
            }
            else if (d[0] == "11-13")
            {
                index = 1;
            }
            else if (d[0] == "13-15")
            {
                index = 2;
            }
            else if (d[0] == "15-17")
            {
                index = 3;
            }
            else if (d[0] == "17-19")
            {
                index = 4;
            }
            return index;
        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCoord.SelectedIndex > -1)
            {
                //textBox4.Text= comboBox3.Text;
            }
        }


        private void cmbTipo_MouseEnter(object sender, EventArgs e)
        {
            lblTipo.Visible = false;
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            lblcode.Visible = false;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                lblcode.Visible = true;
            }
        }

        private void cmbTipo_MouseLeave(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex.Equals(-1))
            {
                lblTipo.Visible = true;
            }
        }

        private void txtAddress_MouseEnter(object sender, EventArgs e)
        {
            lblAddresss.Visible = false;
        }

        private void txtAddress_MouseLeave(object sender, EventArgs e)
        {
            if (txtAddress.Text.Equals(""))
            {
                lblAddresss.Visible = true;
            }
        }

        private void dTPHDI_MouseEnter(object sender, EventArgs e)
        {
            lblHI.Visible = false;
        }

        private void dTPHDI_MouseLeave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dTPHDI.Value.ToString("HH")) < 6 || int.Parse(dTPHDI.Value.ToString("HH")) > 20)
            {
                lblHI.Visible = true;
            }
        }

        private void dTPHDF_MouseEnter(object sender, EventArgs e)
        {
            lblHF.Visible = false;
        }

        private void dTPHDF_MouseLeave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dTPHDF.Value.ToString("HH")) < 7 || int.Parse(dTPHDF.Value.ToString("HH")) > 00)
            {
                lblHF.Visible = true;
            }
        }

        private void cmbCoord_MouseEnter(object sender, EventArgs e)
        {
            lblCoord1.Visible = false;
        }

        private void cmbCoord_MouseLeave(object sender, EventArgs e)
        {

            if (cmbCoord.SelectedIndex.Equals(-1))
            {
                lblCoord1.Visible = true;
            }
        }

        private void cmbEDT_MouseEnter(object sender, EventArgs e)
        {
            lblEDT.Visible = false;
        }

        private void cmbEDT_MouseLeave(object sender, EventArgs e)
        {

            if (cmbEDT.SelectedIndex.Equals(-1))
            {
                lblEDT.Visible = true;
            }
        }

        private void cmbCliente_MouseEnter(object sender, EventArgs e)
        {
            lblCliente.Visible = false;
        }

        private void cmbCliente_MouseLeave(object sender, EventArgs e)
        {
            if (txtAddress.Text.Equals(""))
            {
                lblCliente.Visible = true;
            }
        }

        private void pBoxCoor_MouseHover(object sender, EventArgs e)
        {
            pBoxCoor.Size= new Size(45, 37);
        }

        private void pBoxCoor_MouseLeave(object sender, EventArgs e)
        {
            pBoxCoor.Size = new Size(39, 31);
        }

        private void pBoxCliente_MouseHover(object sender, EventArgs e)
        {
            pBoxCliente.Size = new Size(44, 38);
        }

        private void pBoxCliente_MouseLeave(object sender, EventArgs e)
        {
            pBoxCliente.Size = new Size(38, 32);
        }

        private void pBoxSearch_MouseHover(object sender, EventArgs e)
        {
            pBoxSearch.Size = new Size(41, 35);

        }

        private void pBoxSearch_MouseLeave(object sender, EventArgs e)
        {
            pBoxSearch.Size = new Size(35, 29);
        }
    }
}