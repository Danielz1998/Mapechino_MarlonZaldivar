namespace MaPeChiNo_Project
{
    partial class Login
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
            this.btncancelar = new MetroFramework.Controls.MetroButton();
            this.btnlogin = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtpassword = new MetroFramework.Controls.MetroTextBox();
            this.txtusuario = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Highlight = true;
            this.btncancelar.Location = new System.Drawing.Point(207, 201);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(73, 38);
            this.btncancelar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btncancelar.TabIndex = 14;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btncancelar.UseSelectable = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Highlight = true;
            this.btnlogin.Location = new System.Drawing.Point(103, 201);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(73, 38);
            this.btnlogin.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnlogin.TabIndex = 15;
            this.btnlogin.Text = "Login";
            this.btnlogin.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnlogin.UseSelectable = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(83, 149);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Password:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(83, 93);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Usuario:";
            // 
            // txtpassword
            // 
            this.txtpassword.Lines = new string[] {
        "123"};
            this.txtpassword.Location = new System.Drawing.Point(182, 145);
            this.txtpassword.MaxLength = 32767;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpassword.SelectedText = "";
            this.txtpassword.Size = new System.Drawing.Size(111, 23);
            this.txtpassword.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpassword.TabIndex = 10;
            this.txtpassword.Text = "123";
            this.txtpassword.UseSelectable = true;
            // 
            // txtusuario
            // 
            this.txtusuario.Lines = new string[] {
        "norman"};
            this.txtusuario.Location = new System.Drawing.Point(182, 89);
            this.txtusuario.MaxLength = 32767;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.PasswordChar = '\0';
            this.txtusuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtusuario.SelectedText = "";
            this.txtusuario.Size = new System.Drawing.Size(111, 23);
            this.txtusuario.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtusuario.TabIndex = 11;
            this.txtusuario.Text = "norman";
            this.txtusuario.UseSelectable = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 297);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusuario);
            this.Name = "Login";
            this.Text = "Iniciar Sesion";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btncancelar;
        private MetroFramework.Controls.MetroButton btnlogin;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtpassword;
        private MetroFramework.Controls.MetroTextBox txtusuario;
    }
}