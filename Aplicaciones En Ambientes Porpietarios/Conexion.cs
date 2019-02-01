using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicaciones_En_Ambientes_Porpietarios
{
    class conexion
    {
        //mi conexion:
        SqlConnection con = new SqlConnection("Data Source=USER-PC\\CHRISERVER;Initial Catalog=AAP_2018;Integrated Security=True");

        //procedimiento que abre la conexion sqlsever
        public void conectar()
        {
            try
            {
                con.Open();
                MessageBox.Show("CONEXIÓN EXITOSA");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Insert(String cadena)
        {
         
            SqlCommand cmd = new SqlCommand(cadena, con);

            try
            {
                cmd.ExecuteNonQuery();
               
            }
            catch
            {
                MessageBox.Show("Error to save on database");
               
            }
        }
        public void Update(String cadena)
        {

            SqlCommand cmd = new SqlCommand(cadena, con);

            try
            {
                cmd.ExecuteNonQuery();

            }
            catch
            {
                MessageBox.Show("Error to save on database");

            }
        }
        public String[] Consultar2(String cadena, int valor)
        {

            try
            {
                SqlCommand cmd = new SqlCommand(cadena, con);
                SqlDataReader dr = cmd.ExecuteReader();
                String[] a = new String[valor];
                int i = 0;
                while (dr.Read())
                {
                    a[i] = dr.GetValue(0).ToString();
                    i++;

                }
                dr.Close();

                return a;
            }
            catch
            {
                MessageBox.Show("Error to save on database");

            }
            return null;
        }
        public String[] Consultar(String cadena, int valor)
        {

            try
            {
                SqlCommand cmd = new SqlCommand(cadena, con);
                SqlDataReader dr = cmd.ExecuteReader();
                String[] a = new String[valor];
               
                while (dr.Read())
                {
                    for(int i=0; i<valor;i++)
                        a[i] = dr.GetValue(i).ToString();
                    
                }
                dr.Close();
               
                return a;
            }
            catch
            {
                MessageBox.Show("Error to save on database");

            }
            return null;
        }
        public String[,] ConsultarMatriz(String cadena, int x, int y)
        {

            try
            {
                SqlCommand cmd = new SqlCommand(cadena, con);
                SqlDataReader dr = cmd.ExecuteReader();
                String[,] a = new String[x,y];
                int i = 0;
                while (dr.Read())
                {
                    for (int j = 0; j < y; j++)
                        a[i,j] = dr.GetValue(j).ToString();
                    i++;
                }
                dr.Close();

                return a;
            }
            catch
            {
                MessageBox.Show("Error to save on database");

            }
            return null;
        }
        public String Consultar1(String cadena, int valor)
        {

            try
            {
                SqlCommand cmd = new SqlCommand(cadena, con);
                SqlDataReader dr = cmd.ExecuteReader();
                String a = "";
                while (dr.Read())
                {
                    a = dr.GetValue(0).ToString();
                }
                dr.Close();
                return a;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);

            }
            return null;
        }
        //procedimiento que cierra la conexion sqlserver
        public void desconectar()
        {
            con.Close();
        }



    }

}