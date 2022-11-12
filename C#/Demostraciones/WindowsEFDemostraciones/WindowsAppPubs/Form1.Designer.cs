namespace WindowsAppPubs
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.gridJobs = new System.Windows.Forms.DataGridView();
            this.btnTraerTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(125, 26);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 29);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(88, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Busqueda por Id:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(364, 19);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(254, 57);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(254, 19);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 4;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // gridJobs
            // 
            this.gridJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridJobs.Location = new System.Drawing.Point(12, 117);
            this.gridJobs.Name = "gridJobs";
            this.gridJobs.Size = new System.Drawing.Size(456, 150);
            this.gridJobs.TabIndex = 5;
            // 
            // btnTraerTodos
            // 
            this.btnTraerTodos.Location = new System.Drawing.Point(364, 57);
            this.btnTraerTodos.Name = "btnTraerTodos";
            this.btnTraerTodos.Size = new System.Drawing.Size(75, 23);
            this.btnTraerTodos.TabIndex = 6;
            this.btnTraerTodos.Text = "Traer todos";
            this.btnTraerTodos.UseVisualStyleBackColor = true;
            this.btnTraerTodos.Click += new System.EventHandler(this.btnTraerTodos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 356);
            this.Controls.Add(this.btnTraerTodos);
            this.Controls.Add(this.gridJobs);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView gridJobs;
        private System.Windows.Forms.Button btnTraerTodos;
    }
}

