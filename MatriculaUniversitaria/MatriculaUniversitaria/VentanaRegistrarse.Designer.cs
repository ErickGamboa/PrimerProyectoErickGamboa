namespace MatriculaUniversitaria
{
    partial class VentanaRegistrarse
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
            this.lblContra = new System.Windows.Forms.Label();
            this.lblReContra = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCed = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtReContra = new System.Windows.Forms.TextBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Location = new System.Drawing.Point(65, 107);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(117, 13);
            this.lblContra.TabIndex = 1;
            this.lblContra.Text = "Ingrese su constraseña";
            // 
            // lblReContra
            // 
            this.lblReContra.AutoSize = true;
            this.lblReContra.Location = new System.Drawing.Point(62, 175);
            this.lblReContra.Name = "lblReContra";
            this.lblReContra.Size = new System.Drawing.Size(179, 13);
            this.lblReContra.TabIndex = 2;
            this.lblReContra.Text = "Ingrese su constraseña nuevamente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingrese su cédula";
            // 
            // txtCed
            // 
            this.txtCed.Location = new System.Drawing.Point(247, 39);
            this.txtCed.Name = "txtCed";
            this.txtCed.Size = new System.Drawing.Size(137, 20);
            this.txtCed.TabIndex = 4;
            this.txtCed.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(247, 100);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(137, 20);
            this.txtContra.TabIndex = 6;
            // 
            // txtReContra
            // 
            this.txtReContra.Location = new System.Drawing.Point(247, 168);
            this.txtReContra.Name = "txtReContra";
            this.txtReContra.PasswordChar = '*';
            this.txtReContra.Size = new System.Drawing.Size(137, 20);
            this.txtReContra.TabIndex = 7;
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(179, 237);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(75, 23);
            this.btnRegistro.TabIndex = 9;
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnsiguienteregistro_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(391, 39);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(47, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(55, 207);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 11;
            // 
            // VentanaRegistrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 283);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.txtReContra);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtCed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblReContra);
            this.Controls.Add(this.lblContra);
            this.Name = "VentanaRegistrarse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.VentanaRegistrarse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.Label lblReContra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCed;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtReContra;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblMensaje;
    }
}