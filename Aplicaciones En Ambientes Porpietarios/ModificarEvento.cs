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
        conexion cn = new conexion();
        ValidarSoloLetrasSoloNumeros validar = new ValidarSoloLetrasSoloNumeros();
        public ModificarEventos()
        {
            InitializeComponent();
            cn.conectar();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de salir de la ventana?\n Se perderá todo el avance", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
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


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime();
            dateTime = dTPDate.Value;
            dateTPHI.MinDate = dateTime;
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
            ComprobarTextBox(1);
            
        }

        private void cmbTipo_MouseLeave(object sender, EventArgs e)
        {
            if (ComprobarCombos(1)==1)
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
            ComprobarTextBox(2);
        }

        private void dTPHDI_MouseEnter(object sender, EventArgs e)
        {
            lblHI.Visible = false;
        }

        private void dTPHDI_MouseLeave(object sender, EventArgs e)
        {
            ComprobarHora(2);
        }

        private void dTPHDF_MouseEnter(object sender, EventArgs e)
        {
            lblHF.Visible = false;
        }

        private void dTPHDF_MouseLeave(object sender, EventArgs e)
        {
            ComprobarHora(1);
        }

        private void cmbEDT_MouseEnter(object sender, EventArgs e)
        {
            lblEDT.Visible = false;
        }

        private void cmbEDT_MouseLeave(object sender, EventArgs e)
        {

            if (ComprobarCombos(3)==3)
            {
                lblEDT.Visible = true;
            }
        }

        private void cmbCliente_MouseEnter(object sender, EventArgs e)
        {
            lblClient.Visible = false;
        }

        private void cmbCliente_MouseLeave(object sender, EventArgs e)
        {
            if (ComprobarCombos(5)==5)
            {
                lblClient.Visible = true;
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

        private void pBoxSearch_Click(object sender, EventArgs e)
        {
            if(ComprobarTextBox(1)!=1)
            {
                txtCode.Enabled = false;
                String cadena = "select IDEVENTO,IDCLIENTE,IDGRUPO,CODIGOEVENTO,TIPOE,FECHAE,DIRECCIONE,HORAINICIOE,HORAFINALE from EVENTO WHERE CODIGOEVENTO='" + txtCode.Text+"'";
                llenarCampos(cadena);
                LimpiarLbl();
            }
            MessageBox.Show("Error, revise el error en el campo");
        }
        public int ComprobarTextBox(int valor)
        {
            switch (valor)
            {
                case 1:
                    if (txtCode.Text.Equals(""))
                    {
                        lblcode.Text = "Error, Ingrese el código del evento";
                        lblcode.Visible = true;
                        return 1;

                    }
                    else if (txtCode.Text.Length > 8)
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

            switch (valor)
            {
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
            return sumaBox + sumaText + ComprobarHora(1) + ComprobarHora(2);
        }

        private void ModificarEventos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aAP_2018DataSet.NombresCliente' Puede moverla o quitarla según sea necesario.
            this.nombresClienteTableAdapter.Fill(this.aAP_2018DataSet.NombresCliente);
            // TODO: esta línea de código carga datos en la tabla 'aAP_2018DataSet.GRUPO' Puede moverla o quitarla según sea necesario.
            this.gRUPOTableAdapter.Fill(this.aAP_2018DataSet.GRUPO);
            cmbCli.SelectedIndex = -1;
            cmbEDT.SelectedIndex = -1;

        }
        private void llenarCampos(String valor)
        {
            String[] a = cn.Consultar(valor, 9);
            txtEvento.Text = a[0];
            txtIDCliente.Text = a[1];
            txtIDGrupo.Text = a[2];
            NumCombo(cmbTipo.Items.Count, a[4], 1);
            dTPDate.Value = Convert.ToDateTime(a[5]);
            txtAddress.Text = a[6];
            dateTPHI.Value = Convert.ToDateTime(a[7]);
            dTPHDF2.Value = Convert.ToDateTime(a[8]);
            NumCombo(cmbEDT.Items.Count, cn.Consultar1("select NOMBREG from GRUPO where IDGRUPO="+txtIDGrupo.Text+"",1),2);
            NumCombo(cmbCli.Items.Count, cn.Consultar1("select NOMBRES from NombresCliente where IDCliente=" + txtIDGrupo.Text + "", 1), 3);
        }
        private void NumCombo(int total, String valor, int pos)
        {
            for (int i = 0; i < total; i++)
            {
                switch (pos)
                {
                    case 1:
                           cmbTipo.SelectedIndex = i;
                        if (cmbTipo.SelectedItem.Equals(valor))
                            return;
                        continue;
                    case 2:
                            cmbEDT.SelectedIndex = i;
                        if (cmbEDT.SelectedItem.Equals(valor))
                            return;
                        continue;
                    case 3:
                        cmbCli.SelectedIndex = i;
                        if (cmbCli.SelectedItem.Equals(valor))
                            return;
                        continue;
                }
                
            }
               
        }
        private void LimpiarLbl()
        {
            lblAddresss.Visible = false;
            lblTipo.Visible = false;
            lblClient.Visible = false;
            lblcode.Visible = false;
            lblEDT.Visible = false;
            lblHF.Visible = false;
            lblHI.Visible = false;
        }

        private void pBoxUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de actualizar el evento? ", "Actualizar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (ComprobarCampos() == 0)
                {
                    cn.Update("update evento set IDCLIENTE="+cmbCli.SelectedValue+",IDGRUPO="+cmbEDT.SelectedValue+", " +
                        "CODIGOEVENTO='"+txtCode.Text+"',TIPOE='"+cmbTipo.SelectedItem+"',FECHAE='"+dTPDate.Value.ToString()+"', DIRECCIONE='"+txtAddress.Text+"'," +
                        " HORAINICIOE='"+dateTPHI.Value.ToString()+"', HORAFINALE='"+dTPHDF2.Value.ToString()+"' where IDEVENTO=1");
                    MessageBox.Show("El evento se ha actualizado exitosamente");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Error, no se ha actualizado\nRevise los campos señalados");
                }

            }
        }

        private void Limpiar()
        {
            txtCode.Text = "";
            cmbTipo.SelectedIndex = -1;
            dTPDate.Value = DateTime.Now;
            txtAddress.Text = "";
            dateTPHI.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 6, 0, 0);
            dTPHDF2.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 7, 0, 0);
            cmbCli.SelectedIndex = -1;
            cmbEDT.SelectedIndex = -1;
            txtCode.Enabled = true;
        }

        private void pBoxLimpiar_MouseHover(object sender, EventArgs e)
        {
            pBoxLimpiar.Size = new Size(79, 55);
        }

        private void pBoxLimpiar_MouseLeave(object sender, EventArgs e)
        {
            pBoxLimpiar.Size = new Size(73, 49);
        }

        private void pBoxLimpiar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de limpiar la ventana?\nSe perderá todo el avance", "Limpiar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Limpiar();
                MessageBox.Show("La ventana se ha limpiado exitosamente");
            }
        }
    }   
    

}
