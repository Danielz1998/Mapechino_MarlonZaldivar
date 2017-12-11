namespace MaPeChiNo_Project
{
    partial class frmMostrarEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgEmpleados = new System.Windows.Forms.DataGridView();
            this.idempleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEmpleados
            // 
            this.dgEmpleados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idempleado,
            this.nombre,
            this.apellido,
            this.correo,
            this.direccion,
            this.departamento});
            this.dgEmpleados.Location = new System.Drawing.Point(21, 100);
            this.dgEmpleados.Name = "dgEmpleados";
            this.dgEmpleados.Size = new System.Drawing.Size(655, 227);
            this.dgEmpleados.TabIndex = 0;
            // 
            // idempleado
            // 
            this.idempleado.DataPropertyName = "idempleado";
            this.idempleado.HeaderText = "ID Empleado";
            this.idempleado.Name = "idempleado";
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            // 
            // correo
            // 
            this.correo.DataPropertyName = "correo";
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            // 
            // departamento
            // 
            this.departamento.DataPropertyName = "departamento";
            this.departamento.HeaderText = "Departamento";
            this.departamento.Name = "departamento";
            // 
            // frmMostrarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 389);
            this.Controls.Add(this.dgEmpleados);
            this.Name = "frmMostrarEmpleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.frmMostrarEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamento;
    }
}