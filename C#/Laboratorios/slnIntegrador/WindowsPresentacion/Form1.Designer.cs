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
            this.btnCrearObjetos = new System.Windows.Forms.Button();
            this.gridMedicos = new System.Windows.Forms.DataGridView();
            this.lblMedicos = new System.Windows.Forms.Label();
            this.lstClinicos = new System.Windows.Forms.ListBox();
            this.lblClinicos = new System.Windows.Forms.Label();
            this.lstHabitaciones = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridPacientes = new System.Windows.Forms.DataGridView();
            this.lblPacientes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearObjetos
            // 
            this.btnCrearObjetos.Location = new System.Drawing.Point(424, 37);
            this.btnCrearObjetos.Name = "btnCrearObjetos";
            this.btnCrearObjetos.Size = new System.Drawing.Size(149, 51);
            this.btnCrearObjetos.TabIndex = 0;
            this.btnCrearObjetos.Text = "Crear objetos";
            this.btnCrearObjetos.UseVisualStyleBackColor = true;
            this.btnCrearObjetos.Click += new System.EventHandler(this.btnCrearObjetos_Click);
            // 
            // gridMedicos
            // 
            this.gridMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMedicos.Location = new System.Drawing.Point(38, 131);
            this.gridMedicos.Name = "gridMedicos";
            this.gridMedicos.Size = new System.Drawing.Size(853, 150);
            this.gridMedicos.TabIndex = 1;
            // 
            // lblMedicos
            // 
            this.lblMedicos.AutoSize = true;
            this.lblMedicos.Location = new System.Drawing.Point(35, 105);
            this.lblMedicos.Name = "lblMedicos";
            this.lblMedicos.Size = new System.Drawing.Size(86, 13);
            this.lblMedicos.TabIndex = 2;
            this.lblMedicos.Text = "Lista de medicos";
            // 
            // lstClinicos
            // 
            this.lstClinicos.FormattingEnabled = true;
            this.lstClinicos.Location = new System.Drawing.Point(38, 521);
            this.lstClinicos.Name = "lstClinicos";
            this.lstClinicos.Size = new System.Drawing.Size(342, 95);
            this.lstClinicos.TabIndex = 3;
            // 
            // lblClinicos
            // 
            this.lblClinicos.AutoSize = true;
            this.lblClinicos.Location = new System.Drawing.Point(38, 495);
            this.lblClinicos.Name = "lblClinicos";
            this.lblClinicos.Size = new System.Drawing.Size(124, 13);
            this.lblClinicos.TabIndex = 4;
            this.lblClinicos.Text = "Lista de medicos clinicos";
            // 
            // lstHabitaciones
            // 
            this.lstHabitaciones.FormattingEnabled = true;
            this.lstHabitaciones.Location = new System.Drawing.Point(552, 521);
            this.lstHabitaciones.Name = "lstHabitaciones";
            this.lstHabitaciones.Size = new System.Drawing.Size(339, 95);
            this.lstHabitaciones.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lista de numero y estado de las habitaciones";
            // 
            // gridPacientes
            // 
            this.gridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPacientes.Location = new System.Drawing.Point(41, 331);
            this.gridPacientes.Name = "gridPacientes";
            this.gridPacientes.Size = new System.Drawing.Size(850, 142);
            this.gridPacientes.TabIndex = 7;
            // 
            // lblPacientes
            // 
            this.lblPacientes.AutoSize = true;
            this.lblPacientes.Location = new System.Drawing.Point(38, 304);
            this.lblPacientes.Name = "lblPacientes";
            this.lblPacientes.Size = new System.Drawing.Size(93, 13);
            this.lblPacientes.TabIndex = 8;
            this.lblPacientes.Text = "Lista de pacientes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 800);
            this.Controls.Add(this.lblPacientes);
            this.Controls.Add(this.gridPacientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstHabitaciones);
            this.Controls.Add(this.lblClinicos);
            this.Controls.Add(this.lstClinicos);
            this.Controls.Add(this.lblMedicos);
            this.Controls.Add(this.gridMedicos);
            this.Controls.Add(this.btnCrearObjetos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearObjetos;
        private System.Windows.Forms.DataGridView gridMedicos;
        private System.Windows.Forms.Label lblMedicos;
        private System.Windows.Forms.ListBox lstClinicos;
        private System.Windows.Forms.Label lblClinicos;
        private System.Windows.Forms.ListBox lstHabitaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridPacientes;
        private System.Windows.Forms.Label lblPacientes;
    }
}

