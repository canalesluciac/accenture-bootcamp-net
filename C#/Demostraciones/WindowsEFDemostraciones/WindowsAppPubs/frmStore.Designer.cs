namespace WindowsAppPubs
{
    partial class frmStore
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
            this.btnTraerTodos = new System.Windows.Forms.Button();
            this.gridStores = new System.Windows.Forms.DataGridView();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnDacStore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridStores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraerTodos
            // 
            this.btnTraerTodos.Location = new System.Drawing.Point(364, 42);
            this.btnTraerTodos.Name = "btnTraerTodos";
            this.btnTraerTodos.Size = new System.Drawing.Size(75, 23);
            this.btnTraerTodos.TabIndex = 13;
            this.btnTraerTodos.Text = "Traer todos";
            this.btnTraerTodos.UseVisualStyleBackColor = true;
            this.btnTraerTodos.Click += new System.EventHandler(this.btnTraerTodos_Click);
            // 
            // gridStores
            // 
            this.gridStores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStores.Location = new System.Drawing.Point(10, 134);
            this.gridStores.Name = "gridStores";
            this.gridStores.Size = new System.Drawing.Size(456, 150);
            this.gridStores.TabIndex = 12;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(254, 4);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 11;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(254, 42);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(364, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 14);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(88, 13);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "Busqueda por Id:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(125, 11);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 7;
            // 
            // btnDacStore
            // 
            this.btnDacStore.Location = new System.Drawing.Point(254, 82);
            this.btnDacStore.Name = "btnDacStore";
            this.btnDacStore.Size = new System.Drawing.Size(185, 23);
            this.btnDacStore.TabIndex = 14;
            this.btnDacStore.Text = "Probar metodos DacStore";
            this.btnDacStore.UseVisualStyleBackColor = true;
            this.btnDacStore.Click += new System.EventHandler(this.btnDacStore_Click);
            // 
            // frmStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 296);
            this.Controls.Add(this.btnDacStore);
            this.Controls.Add(this.btnTraerTodos);
            this.Controls.Add(this.gridStores);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Name = "frmStore";
            this.Text = "frmStore";
            ((System.ComponentModel.ISupportInitialize)(this.gridStores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTraerTodos;
        private System.Windows.Forms.DataGridView gridStores;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnDacStore;
    }
}