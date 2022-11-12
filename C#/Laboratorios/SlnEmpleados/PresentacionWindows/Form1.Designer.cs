namespace PresentacionWindows
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
            this.btnCargaEmpleados = new System.Windows.Forms.Button();
            this.gridEmpleados = new System.Windows.Forms.DataGridView();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtIdDepartamento = new System.Windows.Forms.TextBox();
            this.btnMuestraEmpleados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargaEmpleados
            // 
            this.btnCargaEmpleados.Location = new System.Drawing.Point(353, 124);
            this.btnCargaEmpleados.Name = "btnCargaEmpleados";
            this.btnCargaEmpleados.Size = new System.Drawing.Size(120, 23);
            this.btnCargaEmpleados.TabIndex = 0;
            this.btnCargaEmpleados.Text = "Carga empleados";
            this.btnCargaEmpleados.UseVisualStyleBackColor = true;
            this.btnCargaEmpleados.Click += new System.EventHandler(this.btnCargaEmpleados_Click);
            // 
            // gridEmpleados
            // 
            this.gridEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpleados.Location = new System.Drawing.Point(143, 229);
            this.gridEmpleados.Name = "gridEmpleados";
            this.gridEmpleados.Size = new System.Drawing.Size(535, 150);
            this.gridEmpleados.TabIndex = 1;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(289, 73);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(104, 13);
            this.lblDepartamento.TabIndex = 2;
            this.lblDepartamento.Text = "Id del departamento:";
            // 
            // txtIdDepartamento
            // 
            this.txtIdDepartamento.Location = new System.Drawing.Point(414, 70);
            this.txtIdDepartamento.Name = "txtIdDepartamento";
            this.txtIdDepartamento.Size = new System.Drawing.Size(100, 20);
            this.txtIdDepartamento.TabIndex = 3;
            // 
            // btnMuestraEmpleados
            // 
            this.btnMuestraEmpleados.Location = new System.Drawing.Point(353, 172);
            this.btnMuestraEmpleados.Name = "btnMuestraEmpleados";
            this.btnMuestraEmpleados.Size = new System.Drawing.Size(120, 23);
            this.btnMuestraEmpleados.TabIndex = 4;
            this.btnMuestraEmpleados.Text = "Muestra empleados";
            this.btnMuestraEmpleados.UseVisualStyleBackColor = true;
            this.btnMuestraEmpleados.Click += new System.EventHandler(this.btnMuestraEmpleados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMuestraEmpleados);
            this.Controls.Add(this.txtIdDepartamento);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.gridEmpleados);
            this.Controls.Add(this.btnCargaEmpleados);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargaEmpleados;
        private System.Windows.Forms.DataGridView gridEmpleados;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox txtIdDepartamento;
        private System.Windows.Forms.Button btnMuestraEmpleados;
    }
}

