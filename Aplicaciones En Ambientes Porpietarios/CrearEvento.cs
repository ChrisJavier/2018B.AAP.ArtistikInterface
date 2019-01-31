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
        conexion con = new conexion();
        ValidarSoloLetrasSoloNumeros validar = new ValidarSoloLetrasSoloNumeros();
        public CrearEvento()
        {
            InitializeComponent();

            con.conectar();
            //con.Insert("insert into EVENTO values(1, 1, '12345678', 'Boda', '30/01/2019', 'Calle h', '07:00', '10:00')");
            dTPDate.Value = System.DateTime.Today;
            dTPDate.MinDate = System.DateTime.Today;
            cmbEDT.SelectedIndex = -1;
           
            

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
            if (MessageBox.Show("¿Está seguro de guardar ? ", "Guardar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                    if (ComprobarCampos() == 0)
                    {
                        con.Insert("insert into EVENTO values (" + cmbCli.SelectedValue + "," + cmbEDT.SelectedValue + ",'" + txtCodeEvent.Text + "','" + cmbTipo.SelectedItem + "','" + dTPDate.Value.ToString("dd/MM/yyy") + "','" + txtAddress.Text + "','" + dateTPHI.Value.ToString("HH:mm") + "','" + dTPHDF2.Value.ToString("HH:mm") + "')");
                        MessageBox.Show("El evento se ha guardado exitosamente");
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error, no se ha guardado\nRevise los campos señalados");
                    }
                
            }
                
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de limpiar la ventana?\nSe perderá todo el avance", "Limpiar", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime();
            dateTime = dTPDate.Value;
           
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

            ComprobarHora(2);
        }

        private void dTPHF_MouseEnter(object sender, EventArgs e)
        {

            lblHF.Visible = false;
        }

        private void dTPHF_MouseLeave(object sender, EventArgs e)
        {
            ComprobarHora(1);
        }


        private void cmbEDT_MouseEnter(object sender, EventArgs e)
        {
            lblEDTrabajo.Visible = false;
        }

        private void cmbEDT_MouseLeave(object sender, EventArgs e)
        {
            if (ComprobarCombos(3)==3)
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
            if (ComprobarCombos(5) == 5)
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
                        return 1;

                    }
                    else if (txtCodeEvent.Text.Length > 8)
                    {
                        lblcode.Text = "Error, Solo son admitidos 8 dígitos";
                        lblcode.Visible = true;
                        return 1;
                    }
                    else if (verificarCod(txtCodeEvent.Text))
                    {
                        lblcode.Text = ("Error, El código ya existe");
                        lblcode.Visible = true;
                        return 1;
                    }
                        break;
                case 2:
                    if (txtAddress.Text.Equals(""))
                    {
                        lblAddresss.Text = "Error, Ingrese una dirección valida";
                        lblAddresss.Visible = true;
                        return 2;
                    }
                    else if (txtAddress.Text.Length > 10)
                    {
                        lblAddresss.Text = "Error, La dirección debe tener al menos 10 caracteres";
                        lblAddresss.Visible = true;
                        return 2;
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
                        return 3;
                    break;
                case 5:
                    if (cmbCli.SelectedIndex.Equals(-1))
                        return 5;
                    break;
            }
          
            return 0;
        }
        public int ComprobarHora(int valor)
        {
            String horaI = dateTPHI.Value.ToString("HH");
            String horaF = dTPHDF2.Value.ToString("HH");
            int suma = 0;
            switch (valor)
            {
                case 1:
                    if (Convert.ToInt32(horaF) < 7 || int.Parse(horaF) > 23)
                    {
                        lblHF.Visible = true;
                        suma += 1;
                    }
                    break;
                    case 2:
                    if (Convert.ToInt32(horaI) < 6 || int.Parse(horaI) > 20)
                    {
                        lblHI.Visible = true;
                        suma += 2;
                    }
                    break;

            }
            
            
            return suma;
        }


        private void CrearEvento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aAP_2018DataSet.GRUPO' Puede moverla o quitarla según sea necesario.
            this.gRUPOTableAdapter.Fill(this.aAP_2018DataSet.GRUPO);
            // TODO: esta línea de código carga datos en la tabla 'aAP_2018DataSet.NombresCliente' Puede moverla o quitarla según sea necesario.
            this.nombresClienteTableAdapter.Fill(this.aAP_2018DataSet.NombresCliente);
            // TODO: esta línea de código carga datos en la tabla 'aAP_2018DataSet.NombresCliente' Puede moverla o quitarla según sea necesario.
            this.nombresClienteTableAdapter.Fill(this.aAP_2018DataSet.NombresCliente);
            cmbEDT.SelectedIndex =-1;
            cmbCli.SelectedIndex = -1;

        }
        public int ComprobarCampos()
        {
            int totalError = 0;
            int sumaText = (ComprobarTextBox(1) + ComprobarTextBox(2));
            switch (sumaText)
            {
                case 1:
                    lblcode.Visible = true;
                    totalError += 1;
                    break;
                case 2:
                    lblAddresss.Visible = true;
                    totalError += 2;
                    break;
                case 3:
                    lblcode.Visible = true;
                    lblAddresss.Visible = true;
                    totalError += 2;
                    break;
            }

            int sumaBox = (ComprobarCombos(1) + ComprobarCombos(3) + ComprobarCombos(5));
            switch (sumaBox)
            {
                case 1:
                    lblTipo.Visible = true;
                    totalError += 1;
                    break;
                case 3:
                    lblEDTrabajo.Visible = true;
                    totalError += 3;
                    break;
                case 4:
                    lblTipo.Visible = true;
                    lblEDTrabajo.Visible = true;
                    totalError += 4;
                    break;
                case 5:
                    lblClient.Visible = true;
                    totalError += 5;
                    break;
                case 6:
                    lblTipo.Visible = true;
                    lblClient.Visible = true;
                    totalError += 6;
                    break;
                case 8:
                    lblEDTrabajo.Visible = true;
                    lblClient.Visible = true;
                    totalError += 8;
                    break;
                case 9:
                    lblTipo.Visible = true;
                    lblEDTrabajo.Visible = true;
                    lblClient.Visible = true;
                    totalError += 9;
                    break;


            }
            return sumaBox + sumaText+ ComprobarHora(1)+ ComprobarHora(2);
        }

        private void dTPHDF2_MouseEnter(object sender, EventArgs e)
        {
            lblHF.Visible = false;
        }

        private void dTPHDF2_MouseLeave(object sender, EventArgs e)
        {
            ComprobarHora(1);
        }
        private Boolean verificarCod(String valor)
        {
            String[] a = new String[Convert.ToInt32(con.Consultar1("select count(*) as total from EVENTO",1))];
            a = con.Consultar2("select CODIGOEVENTO from EVENTO",a.Length);
            for (int i = 0; i < a.Length; i++)
                if (a[i].Replace(" ","").Equals(valor))
                {
                    return true;
                }
            return false;
        }
    }
}
