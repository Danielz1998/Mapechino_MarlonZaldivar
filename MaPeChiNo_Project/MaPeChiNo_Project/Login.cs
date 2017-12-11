using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaPeChiNo_Project;
using MetroFramework;
using MetroFramework.Forms;
using CEUTEC;

namespace MaPeChiNo_Project
{
    public partial class Login : MetroForm
    {
        public int p_id_usuario = 0;

        public Login()
        {
            InitializeComponent();
        }

        private void ValidarUsuario()
        {
            DataRow dr = null;

            string query = @"SELECT * FROM usuarios
                            WHERE
                            nombre_usuario= '" + txtusuario.Text + "' and password='" + txtpassword.Text + "'";

            if (auxiliar.conn.SQLSelectDataRow(query, ref dr))
            {
                string usuario = dr["nombre_usuario"].ToString();
                string contra = dr["password"].ToString();

                if (usuario == txtusuario.Text && contra == txtpassword.Text)
                {
                    MessageBox.Show("Bienvenido al sistema");
                    frmMenu.validacion= true;
                    

                }
                else
                {
                    MessageBox.Show("Error al Conectarse");
                }

            }
            // this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            ValidarUsuario();
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            ValidarUsuario();
            this.Close();
        }
    }
}
