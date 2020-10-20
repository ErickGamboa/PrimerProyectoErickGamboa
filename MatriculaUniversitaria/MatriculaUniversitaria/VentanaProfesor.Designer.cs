namespace MatriculaUniversitaria
{
    partial class VentanaProfesor
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
            this.btncerrarsesionadmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "VENTANA PROFESOR";
            // 
            // btncerrarsesionadmin
            // 
            this.btncerrarsesionadmin.Location = new System.Drawing.Point(707, 12);
            this.btncerrarsesionadmin.Name = "btncerrarsesionadmin";
            this.btncerrarsesionadmin.Size = new System.Drawing.Size(81, 23);
            this.btncerrarsesionadmin.TabIndex = 3;
            this.btncerrarsesionadmin.Text = "Cerrar sesión";
            this.btncerrarsesionadmin.UseVisualStyleBackColor = true;
            this.btncerrarsesionadmin.Click += new System.EventHandler(this.btncerrarsesionadmin_Click);
            // 
            // VentanaProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncerrarsesionadmin);
            this.Controls.Add(this.label1);
            this.Name = "VentanaProfesor";
            this.Text = "VentanaProfesor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncerrarsesionadmin;
    }
}