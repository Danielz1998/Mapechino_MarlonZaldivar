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

namespace MaPeChiNo_Project
{
    public partial class MantenimientoMemo : Form
    {
        public MantenimientoMemo()
        {
            InitializeComponent();

            cmbcodmemo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarCodMemo()
        {
            string query = @"SELECT
                             codmemo
                             FROM
                             Memorando
                             ORDER BY codmemo";

            DataTable dt = null;

            if (auxiliar.conn.SQLSelectDataTable(query, ref dt))
            {
                cmbcodmemo.DisplayMember = "codmemo";
                cmbcodmemo.ValueMember = "codmemo";
                cmbcodmemo.DataSource = dt;
            }
        }

        private void CargarEmpleados()
        {
            string query = @"SELECT
                             nombre, idempleado
                             FROM
                             Empleados
                             ORDER BY nombre";

            DataTable dt = null;

            if (auxiliar.conn.SQLSelectDataTable(query, ref dt))
            {
                cmbempleados.DisplayMember = "nombre";
                cmbempleados.ValueMember = "idempleado";
                cmbempleados.DataSource = dt;
            }
        }

        private void CargarClientes()
        {
            string query = @"SELECT
                             nombre, idcliente
                             FROM
                             Clientes
                             ORDER BY nombre";

            DataTable dt = null;

            if (auxiliar.conn.SQLSelectDataTable(query, ref dt))
            {
                cmbclientes.DisplayMember = "nombre";
                cmbclientes.ValueMember = "idcliente";
                cmbclientes.DataSource = dt;
            }
        }

        private void CargarDepartamentos()
        {
            string query = @"SELECT
                             departamento, coddepto
                             FROM
                             Departamentos
                             ORDER BY departamento";

            DataTable dt = null;

            if (auxiliar.conn.SQLSelectDataTable(query, ref dt))
            {
                cmbdepartamentos.DisplayMember = "departamento";
                cmbdepartamentos.ValueMember = "coddepto";
                cmbdepartamentos.DataSource = dt;
            }
        }


        private void MantenimientoMemo_Load(object sender, EventArgs e)
        {
            CargarCodMemo();
            CargarClientes();
            CargarDepartamentos();
            CargarEmpleados();
        }

        private void BuscarporCodMemo()
        {
            DataRow dr = null;


            /*string query = @"SELECT 
                            mensaje, fecha, iddepto, idcliente, idempleado
                            FROM
                            Memorando
                            WHERE codmemo= '" + cmbcodmemo.Text + "'";*/
            string query = @"select memorando.codmemo, memorando.mensaje, memorando.fecha, Departamentos.departamento, Clientes.nombre as cliente, Empleados.nombre as empleado
from Memorando, Clientes, Empleados, Departamentos
where memorando.idcliente=Clientes.idcliente and Memorando.idempleado=Empleados.idempleado and Memorando.iddepto=Departamentos.coddepto
and Memorando.codmemo='" + cmbcodmemo.Text + "'";


            if (auxiliar.conn.SQLSelectDataRow(query, ref dr))
            {
                txtmensaje.Text = dr["mensaje"].ToString();
                dtpfecha.Text = dr["fecha"].ToString();
                cmbdepartamentos.Text = dr["departamento"].ToString();
                cmbclientes.Text = dr["cliente"].ToString();
                cmbempleados.Text = dr["empleado"].ToString();
            }

        }
        
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            BuscarporCodMemo();
        }

        private void Actualizar()
        {
                string query = "";


                query = @"INSERT INTO Memorando
                             (codmemo, mensaje, fecha, iddepto, idcliente, idempleado)
                            VALUES
                             ('{0}','{1}','{2}','{3}',{4},'{5}')";



                query = string.Format(query,
                                        cmbcodmemo.Text,
                                        txtmensaje.Text,
                                        dtpfecha.Text,

                                       
                                        
                                    );






                if (auxiliar.conn.SqlExec(query))
                {
                    MessageBox.Show("Actualizado..!");

                }
                else
                {
                    MessageBox.Show("Error al actualizar...!: " +
                                    auxiliar.conn.SQLError());
                }
            }
         
       


        private void btnactualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
