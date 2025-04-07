namespace Simulacro_Parcial
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEstudiantes = new System.Windows.Forms.Button();
            this.btnTalleres = new System.Windows.Forms.Button();
            this.btnInscripciones = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.Location = new System.Drawing.Point(81, 104);
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Size = new System.Drawing.Size(146, 82);
            this.btnEstudiantes.TabIndex = 0;
            this.btnEstudiantes.Text = "Ir a Estudiantes";
            this.btnEstudiantes.UseVisualStyleBackColor = true;
            this.btnEstudiantes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTalleres
            // 
            this.btnTalleres.Location = new System.Drawing.Point(344, 104);
            this.btnTalleres.Name = "btnTalleres";
            this.btnTalleres.Size = new System.Drawing.Size(146, 82);
            this.btnTalleres.TabIndex = 1;
            this.btnTalleres.Text = "Ir a Talleres";
            this.btnTalleres.UseVisualStyleBackColor = true;
            this.btnTalleres.Click += new System.EventHandler(this.btnTalleres_Click);
            // 
            // btnInscripciones
            // 
            this.btnInscripciones.Location = new System.Drawing.Point(591, 104);
            this.btnInscripciones.Name = "btnInscripciones";
            this.btnInscripciones.Size = new System.Drawing.Size(146, 82);
            this.btnInscripciones.TabIndex = 2;
            this.btnInscripciones.Text = "Ir a Inscripciones";
            this.btnInscripciones.UseVisualStyleBackColor = true;
            this.btnInscripciones.Click += new System.EventHandler(this.btnInscripciones_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(344, 287);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(146, 82);
            this.btnReporte.TabIndex = 3;
            this.btnReporte.Text = "Ir a Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnInscripciones);
            this.Controls.Add(this.btnTalleres);
            this.Controls.Add(this.btnEstudiantes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEstudiantes;
        private System.Windows.Forms.Button btnTalleres;
        private System.Windows.Forms.Button btnInscripciones;
        private System.Windows.Forms.Button btnReporte;
    }
}

