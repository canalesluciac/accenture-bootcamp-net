namespace WindowsPresentacion
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
            this.btnCrearInstrumentos = new System.Windows.Forms.Button();
            this.btnCrearPiezaAjedrez = new System.Windows.Forms.Button();
            this.btnCrearAnimales = new System.Windows.Forms.Button();
            this.btnCrearPersonaHospital = new System.Windows.Forms.Button();
            this.btnCrearTransporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearInstrumentos
            // 
            this.btnCrearInstrumentos.Location = new System.Drawing.Point(280, 34);
            this.btnCrearInstrumentos.Name = "btnCrearInstrumentos";
            this.btnCrearInstrumentos.Size = new System.Drawing.Size(147, 42);
            this.btnCrearInstrumentos.TabIndex = 0;
            this.btnCrearInstrumentos.Text = "Crear instrumentos";
            this.btnCrearInstrumentos.UseVisualStyleBackColor = true;
            this.btnCrearInstrumentos.Click += new System.EventHandler(this.btnCrearInstrumentos_Click);
            // 
            // btnCrearPiezaAjedrez
            // 
            this.btnCrearPiezaAjedrez.Location = new System.Drawing.Point(280, 121);
            this.btnCrearPiezaAjedrez.Name = "btnCrearPiezaAjedrez";
            this.btnCrearPiezaAjedrez.Size = new System.Drawing.Size(147, 40);
            this.btnCrearPiezaAjedrez.TabIndex = 1;
            this.btnCrearPiezaAjedrez.Text = "Crear pieza ajedrez";
            this.btnCrearPiezaAjedrez.UseVisualStyleBackColor = true;
            this.btnCrearPiezaAjedrez.Click += new System.EventHandler(this.btnCrearPiezaAjedrez_Click);
            // 
            // btnCrearAnimales
            // 
            this.btnCrearAnimales.Location = new System.Drawing.Point(280, 278);
            this.btnCrearAnimales.Name = "btnCrearAnimales";
            this.btnCrearAnimales.Size = new System.Drawing.Size(147, 40);
            this.btnCrearAnimales.TabIndex = 2;
            this.btnCrearAnimales.Text = "Crear animales";
            this.btnCrearAnimales.UseVisualStyleBackColor = true;
            this.btnCrearAnimales.Click += new System.EventHandler(this.btnCrearAnimales_Click);
            // 
            // btnCrearPersonaHospital
            // 
            this.btnCrearPersonaHospital.Location = new System.Drawing.Point(280, 203);
            this.btnCrearPersonaHospital.Name = "btnCrearPersonaHospital";
            this.btnCrearPersonaHospital.Size = new System.Drawing.Size(147, 40);
            this.btnCrearPersonaHospital.TabIndex = 3;
            this.btnCrearPersonaHospital.Text = "Crear persona en Hospital";
            this.btnCrearPersonaHospital.UseVisualStyleBackColor = true;
            this.btnCrearPersonaHospital.Click += new System.EventHandler(this.btnCrearPersonaHospital_Click);
            // 
            // btnCrearTransporte
            // 
            this.btnCrearTransporte.Location = new System.Drawing.Point(280, 347);
            this.btnCrearTransporte.Name = "btnCrearTransporte";
            this.btnCrearTransporte.Size = new System.Drawing.Size(147, 40);
            this.btnCrearTransporte.TabIndex = 4;
            this.btnCrearTransporte.Text = "Crear transporte";
            this.btnCrearTransporte.UseVisualStyleBackColor = true;
            this.btnCrearTransporte.Click += new System.EventHandler(this.btnCrearTransporte_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearTransporte);
            this.Controls.Add(this.btnCrearPersonaHospital);
            this.Controls.Add(this.btnCrearAnimales);
            this.Controls.Add(this.btnCrearPiezaAjedrez);
            this.Controls.Add(this.btnCrearInstrumentos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearInstrumentos;
        private System.Windows.Forms.Button btnCrearPiezaAjedrez;
        private System.Windows.Forms.Button btnCrearAnimales;
        private System.Windows.Forms.Button btnCrearPersonaHospital;
        private System.Windows.Forms.Button btnCrearTransporte;
    }
}

