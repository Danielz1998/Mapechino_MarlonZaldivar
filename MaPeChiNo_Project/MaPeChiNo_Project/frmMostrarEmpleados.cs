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
    public partial class frmMostrarEmpleados : MetroForm
    {
        public frmMostrarEmpleados()
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
                      idempleado,nombre,apellido,correo
                       ,direccion,departamento
                      FROM
                      Empleados, Departamentos
                      WHERE
                      Empleados.coddepto=Departamentos.coddepto
                     ";

                if (auxiliar.conn.SQLSelectDataTable(query, ref dt))
                {
                    dgEmpleados.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Mostrar: " +
                                 ex.ToString());
            }
        }

        private void frmMostrarEmpleados_Load(object sender, EventArgs e)
        {
            mostrar();
        }
    }
}
