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
        conexion cn = new conexion();
        String[] comboTipo = { "Boda","Bautizo","Confirmación","Graduación","Primera Comunión","Otros"};
        public BuscarEventos()
        {
            InitializeComponent();
            cn.conectar();
        }
        
        BaseDeDatos bd = new BaseDeDatos();

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de salir de la ventana?\n Se perderá todo el avance", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (cmbTipoB.SelectedItem.Equals("Código"))
            {
                if (Comprobartxt() != 1)
                {
                    if (verificarCod(txtSearch.Text))
                    {
                        
                        if (Convert.ToInt32(comprobarExistencia(" CODIGOEVENTO="+txtSearch.Text+""))!=0)
                        {
                            panel1.Visible = true;
                            llenarLabel(cn.Consultar("select * from EVENTO where CODIGOEVENTO='" + txtSearch.Text + "'", 9));
                            MessageBox.Show("La consulta ha sido exitosa");
                        }
                        else
                        {
                            MessageBox.Show("No existen eventos con el código :"+ txtSearch.Text);
                        }
                    }
                    else
                    {
                        lblSearch.Text = "Error, El evento no existe";
                        lblSearch.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Error, Compruebe los campos marcados");
                }
            }
            else if (cmbTipoB.SelectedItem.Equals("Tipo"))
            {
                if (cmbTipoa.SelectedIndex != -1)
                {
                    dGVConsulta.Rows.Clear();
                    if (Convert.ToInt32(comprobarExistencia(" TIPOE= '" + cmbTipoa.SelectedItem + "'")) != 0)
                    {
                        dGVConsulta.Visible = true;
                        ingresarDatosDGV(cn.ConsultarMatriz("select * from EVENTO where TIPOE='" + cmbTipoa.SelectedItem + "'", Convert.ToInt32(cn.Consultar1("select count(*) as total from EVENTO where TIPOE='" + cmbTipoa.SelectedItem + "'", 1)), 9));
                    }
                    else
                    {
                        MessageBox.Show("No existen eventos de tipo :" + cmbTipoa.SelectedItem);
                    }
                }
                else
                {
                    lblSearch.Text = "Error, Escoja una opción";
                    lblSearch.Visible = true;
                    MessageBox.Show("Error, Compruebe los campos marcados");
                }
            }
            else if (cmbTipoB.SelectedItem.Equals("Cliente"))
            {
                if (cmbCliente.SelectedIndex != -1)
                {
                    dGVConsulta.Rows.Clear();
                    if (Convert.ToInt32(comprobarExistencia(" IDCLIENTE=" + cmbCliente.SelectedValue + "")) != 0)
                    {
                        dGVConsulta.Visible = true;
                        ingresarDatosDGV(cn.ConsultarMatriz("select * from EVENTO where idcliente='" + cmbCliente.SelectedValue + "'", Convert.ToInt32(cn.Consultar1("select count(*) as total from EVENTO where idcliente='" + cmbCliente.SelectedValue + "'", 1)), 9));
                    }
                    else
                    {
                        MessageBox.Show("No existen eventos a nombre del cliente :" + cmbCliente.SelectedItem);
                    }
                }
                else
                {
                    lblSearch.Text = "Error, Escoja una opción";
                    lblSearch.Visible = true;
                    MessageBox.Show("Error, Compruebe los campos marcados");
                }
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
            Comprobartxt();
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
            if (MessageBox.Show("¿Está seguro de limpiar la ventana?", "Limpiar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Limpiar();
                MessageBox.Show("La ventana se ha limpiado exitosamente");
            }
        }


        private void pBoxReturn1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cmbTipoB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoB.SelectedItem.Equals("Código"))
            {
                txtSearch.Visible = true;
                cmbTipoa.Visible = false;
                cmbCliente.Visible = false;
            }else if (cmbTipoB.SelectedItem.Equals("Tipo"))
            {
                txtSearch.Visible = false;
                cmbTipoa.Visible = true;
                cmbCliente.Visible = false;

            }
            else if (cmbTipoB.SelectedItem.Equals("Cliente"))
            {
                txtSearch.Visible = false;
                cmbTipoa.Visible = false;
                cmbCliente.Visible = true;

            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void BuscarEventos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aAP_2018DataSet.NombresCliente' Puede moverla o quitarla según sea necesario.
            this.nombresClienteTableAdapter.Fill(this.aAP_2018DataSet.NombresCliente);
            cmbCliente.SelectedIndex = -1;
            cmbTipoa.SelectedIndex = -1;
        }

        private void cmbTipoa_MouseEnter(object sender, EventArgs e)
        {
            lblSearch.Visible = false;
        }

        private void cmbTipoa_MouseLeave(object sender, EventArgs e)
        {
                      
                if (cmbTipoa.SelectedIndex == -1)
                {
                    lblSearch.Text = "Error, Escoja una opción";
                    lblSearch.Visible = true;
                }
            
        }

        private void cmbCliente_MouseEnter(object sender, EventArgs e)
        {
            lblSearch.Visible = false;
        }

        private void cmbCliente_MouseLeave(object sender, EventArgs e)
        {
        if (cmbCliente.SelectedIndex == -1)
                {
                    lblSearch.Text = "Error, Escoja una opción";
                    lblSearch.Visible = true;
                }
        }
        private int Comprobartxt()
        {
            if (cmbTipoB.SelectedItem.Equals("Código"))
            {
                if (txtSearch.Text.Equals(""))
                {
                    lblSearch.Text = "Error, Ingrese el código del evento";
                    lblSearch.Visible = true;
                    return 1;

                }
                else if (txtSearch.Text.Length > 8)
                {
                    lblSearch.Text = "Error, Solo son admitidos 8 dígitos";
                    lblSearch.Visible = true;
                    return 1;

                }
                else if (Convert.ToInt32(txtSearch.Text) == 0)
                {
                    lblSearch.Text = "Error, Solo son admitidos dígitos mayores a 0";
                    lblSearch.Visible = true;
                    return 1;
                }
            }
            return - 1;
        }
        private Boolean verificarCod(String valor)
        {
            String[] a = new String[Convert.ToInt32(cn.Consultar1("select count(*) as total from EVENTO", 1))];
            a = cn.Consultar2("select CODIGOEVENTO from EVENTO", a.Length);
            for (int i = 0; i < a.Length; i++)
                if (a[i].Replace(" ", "").Equals(valor))
                {
                    return true;
                }
            return false;
        }
        private void llenarLabel(String [] a)
        {
            DateTime e = Convert.ToDateTime(a[5]);
            lblIdcliente.Text = a[1];
            lblIdGrupo.Text = a[2];
            lblCode1.Text = a[3];
            lblTipo1.Text = a[4];
            lblDate1.Text = e.ToString("dd/MM/yyyy");
            lblAddress1.Text = a[6];
            e= Convert.ToDateTime(a[7]);
            lblHDI.Text= e.ToString("HH:mm");
            e = Convert.ToDateTime(a[8]);
            lblHDF.Text = e.ToString("HH:mm");
            lblEA.Text = cn.Consultar1("select Nombreg from GRUPO where idgrupo="+lblIdGrupo.Text+"", 1);
            lblCliente1.Text = cn.Consultar1("select Nombres from nombrescliente where idcliente="+lblIdcliente.Text+"", 1);
        }

        private void pBoxReturn1_MouseHover(object sender, EventArgs e)
        {
            pBoxReturn1.Size = new Size(55, 48);
        }

        private void pBoxReturn1_MouseLeave(object sender, EventArgs e)
        {
            pBoxReturn1.Size = new Size(49, 42);
        }

        private void pBoxReturn1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        private void ingresarDatosDGV(String[,] a)
        {
            String[] b = new String[a.GetLength(1)];
            DateTime c = new DateTime();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (j % 5 == 0 && j!=0)
                    {
                        c =Convert.ToDateTime(a[i, j]);
                        b[j] = c.ToString("dd/MM/yyyy");
                    }else if(j % 7 == 0 && j != 0)
                    {
                        c = Convert.ToDateTime(a[i, j]);
                        b[j] = c.ToString("HH:mm");
                    }
                    else if (j % 8 == 0 && j != 0)
                    {
                        c = Convert.ToDateTime(a[i, j]);
                        b[j] = c.ToString("HH:mm");
                    }
                    else
                    {
                        b[j] = a[i, j];
                    }



                }
                dGVConsulta.Rows.Add(b);
            }
        }
        private void Limpiar()
        {
            cmbTipoB.SelectedIndex = 0;
            cmbTipoa.SelectedIndex = -1;
            cmbCliente.SelectedIndex = -1;
            txtSearch.Text = "";
            cmbCliente.Visible = false;
            cmbTipoa.Visible = false;
            txtSearch.Visible = false;
            panel1.Visible = false;
            dGVConsulta.Visible = false;
            lblSearch.Visible = false;
        }
        private String comprobarExistencia(String cadena)
        {
            return cn.Consultar1("select count(*) as total from EVENTO where"+cadena,1);
        }


    }
}
