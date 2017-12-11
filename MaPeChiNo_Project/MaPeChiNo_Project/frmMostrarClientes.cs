using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEUTEC;
using MetroFramework;
using MetroFramework.Forms;

namespace MaPeChiNo_Project
{
    public partial class frmMostrarClientes :  MetroForm
    {
        public frmMostrarClientes()
        {
            InitializeComponent();
        }

        private void mostrar()
        {
            try
            {
                string query = "";
                DataTable dt = null;

                query = @"SELECT 
                      idcliente,nombre,apellido,correo
                       ,direccion
                      FROM
                      Clientes
                     ";

                if (auxiliar.conn.SQLSelectDataTable(query, ref dt))
                {
                    dgvClientes.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Mostrar: " +
                                 ex.ToString());
            }
        }

        private void frmMostrarClientes_Load(object sender, EventArgs e)
        {
            mostrar();
        }
    }
}
