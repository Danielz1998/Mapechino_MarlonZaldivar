using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using CEUTEC;

namespace MaPeChiNo_Project
{
    public partial class frmMenu : MetroForm
    {
        public static bool validacion = false;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (auxiliar.conn.Conectar("MARLONZALDIVAR", "MaPeChiNo", "sa", "zaldivar"))
            {
                MessageBox.Show("Conectado exitosamente a la base de datos");
            }
            else
            {
                MessageBox.Show("Error al conectarse.! " + auxiliar.conn.SQLError());
            }

            MantenimientoMemo frm = new MantenimientoMemo();
            frm.Show();
        }

        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.ShowDialog();

            if (validacion)
            {
                memorandosToolStripMenuItem.Enabled = true;
                consultasToolStripMenuItem.Enabled = true;
                
            }
            else
            {
                memorandosToolStripMenuItem.Enabled = false;
                consultasToolStripMenuItem.Enabled = false;
                
            }
            validacion = false;
        }

        private void recibirMemorandoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrarEmpleados frm = new frmMostrarEmpleados();
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrarClientes frm = new frmMostrarClientes();
            frm.Show();
        }
    }
}
