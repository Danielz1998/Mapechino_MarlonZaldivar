namespace MaPeChiNo_Project
{
    partial class MantenimientoMemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbcodmemo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbdepartamentos = new System.Windows.Forms.ComboBox();
            this.cmbclientes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbempleados = new System.Windows.Forms.ComboBox();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.txtmensaje = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CodMemo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mensaje:";
            // 
            // cmbcodmemo
            // 
            this.cmbcodmemo.FormattingEnabled = true;
            this.cmbcodmemo.Location = new System.Drawing.Point(83, 33);
            this.cmbcodmemo.Name = "cmbcodmemo";
            this.cmbcodmemo.Size = new System.Drawing.Size(121, 21);
            this.cmbcodmemo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha:";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha.Location = new System.Drawing.Point(77, 328);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(83, 20);
            this.dtpfecha.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(311, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Departamento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(352, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cliente:";
            // 
            // cmbdepartamentos
            // 
            this.cmbdepartamentos.FormattingEnabled = true;
            this.cmbdepartamentos.Location = new System.Drawing.Point(406, 82);
            this.cmbdepartamentos.Name = "cmbdepartamentos";
            this.cmbdepartamentos.Size = new System.Drawing.Size(176, 21);
            this.cmbdepartamentos.TabIndex = 7;
            // 
            // cmbclientes
            // 
            this.cmbclientes.FormattingEnabled = true;
            this.cmbclientes.Location = new System.Drawing.Point(406, 155);
            this.cmbclientes.Name = "cmbclientes";
            this.cmbclientes.Size = new System.Drawing.Size(176, 21);
            this.cmbclientes.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(333, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Empleado:";
            // 
            // cmbempleados
            // 
            this.cmbempleados.FormattingEnabled = true;
            this.cmbempleados.Location = new System.Drawing.Point(406, 229);
            this.cmbempleados.Name = "cmbempleados";
            this.cmbempleados.Size = new System.Drawing.Size(176, 21);
            this.cmbempleados.TabIndex = 10;
            // 
            // btnactualizar
            // 
            this.btnactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.Location = new System.Drawing.Point(301, 329);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(75, 23);
            this.btnactualizar.TabIndex = 11;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimir.Location = new System.Drawing.Point(392, 329);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(75, 23);
            this.btnimprimir.TabIndex = 12;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(403, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Dirigido A:";
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(521, 357);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 14;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // txtmensaje
            // 
            this.txtmensaje.Location = new System.Drawing.Point(12, 100);
            this.txtmensaje.Multiline = true;
            this.txtmensaje.Name = "txtmensaje";
            this.txtmensaje.Size = new System.Drawing.Size(292, 208);
            this.txtmensaje.TabIndex = 15;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(210, 31);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 16;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // MantenimientoMemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 392);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtmensaje);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.cmbempleados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbclientes);
            this.Controls.Add(this.cmbdepartamentos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbcodmemo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MantenimientoMemo";
            this.Text = "MantenimientoMemo";
            this.Load += new System.EventHandler(this.MantenimientoMemo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbcodmemo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbdepartamentos;
        private System.Windows.Forms.ComboBox cmbclientes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbempleados;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.TextBox txtmensaje;
        private System.Windows.Forms.Button btnbuscar;
    }
}