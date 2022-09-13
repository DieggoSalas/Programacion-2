namespace Formularios
{
    partial class frmPrincipal
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblAutomotores = new System.Windows.Forms.Label();
            this.lblAutC = new System.Windows.Forms.Label();
            this.lblInmuebles = new System.Windows.Forms.Label();
            this.lblInmC = new System.Windows.Forms.Label();
            this.lblServicios = new System.Windows.Forms.Label();
            this.lblSerC = new System.Windows.Forms.Label();
            this.lblOtros = new System.Windows.Forms.Label();
            this.lblOtrC = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(849, 102);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 34);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(12, 19);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(570, 29);
            this.lblBienvenido.TabIndex = 1;
            this.lblBienvenido.Text = "Bienvenido a mi primer aplicación de escritorio!";
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(12, 102);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 62;
            this.dgvProductos.RowTemplate.Height = 28;
            this.dgvProductos.Size = new System.Drawing.Size(831, 337);
            this.dgvProductos.TabIndex = 2;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(849, 142);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(102, 34);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(849, 182);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(102, 34);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(82, 61);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(215, 26);
            this.txtBuscar.TabIndex = 5;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(13, 64);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(63, 20);
            this.lblBuscar.TabIndex = 6;
            this.lblBuscar.Text = "Buscar:";
            // 
            // lblAutomotores
            // 
            this.lblAutomotores.AutoSize = true;
            this.lblAutomotores.Location = new System.Drawing.Point(13, 442);
            this.lblAutomotores.Name = "lblAutomotores";
            this.lblAutomotores.Size = new System.Drawing.Size(147, 20);
            this.lblAutomotores.TabIndex = 7;
            this.lblAutomotores.Text = "Cant. Automotores:";
            // 
            // lblAutC
            // 
            this.lblAutC.AutoSize = true;
            this.lblAutC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAutC.Location = new System.Drawing.Point(166, 442);
            this.lblAutC.Name = "lblAutC";
            this.lblAutC.Size = new System.Drawing.Size(0, 20);
            this.lblAutC.TabIndex = 8;
            // 
            // lblInmuebles
            // 
            this.lblInmuebles.AutoSize = true;
            this.lblInmuebles.Location = new System.Drawing.Point(238, 442);
            this.lblInmuebles.Name = "lblInmuebles";
            this.lblInmuebles.Size = new System.Drawing.Size(129, 20);
            this.lblInmuebles.TabIndex = 9;
            this.lblInmuebles.Text = "Cant. Inmuebles:";
            // 
            // lblInmC
            // 
            this.lblInmC.AutoSize = true;
            this.lblInmC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblInmC.Location = new System.Drawing.Point(373, 442);
            this.lblInmC.Name = "lblInmC";
            this.lblInmC.Size = new System.Drawing.Size(0, 20);
            this.lblInmC.TabIndex = 10;
            // 
            // lblServicios
            // 
            this.lblServicios.AutoSize = true;
            this.lblServicios.Location = new System.Drawing.Point(450, 442);
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.Size = new System.Drawing.Size(118, 20);
            this.lblServicios.TabIndex = 11;
            this.lblServicios.Text = "Cant. Servicios:";
            // 
            // lblSerC
            // 
            this.lblSerC.AutoSize = true;
            this.lblSerC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSerC.Location = new System.Drawing.Point(574, 442);
            this.lblSerC.Name = "lblSerC";
            this.lblSerC.Size = new System.Drawing.Size(0, 20);
            this.lblSerC.TabIndex = 12;
            // 
            // lblOtros
            // 
            this.lblOtros.AutoSize = true;
            this.lblOtros.Location = new System.Drawing.Point(661, 442);
            this.lblOtros.Name = "lblOtros";
            this.lblOtros.Size = new System.Drawing.Size(94, 20);
            this.lblOtros.TabIndex = 13;
            this.lblOtros.Text = "Cant. Otros:";
            // 
            // lblOtrC
            // 
            this.lblOtrC.AutoSize = true;
            this.lblOtrC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblOtrC.Location = new System.Drawing.Point(761, 442);
            this.lblOtrC.Name = "lblOtrC";
            this.lblOtrC.Size = new System.Drawing.Size(0, 20);
            this.lblOtrC.TabIndex = 14;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(14, 494);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(146, 20);
            this.lblProductos.TabIndex = 15;
            this.lblProductos.Text = "Total de Productos:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTotal.Location = new System.Drawing.Point(166, 494);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 20);
            this.lblTotal.TabIndex = 16;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 525);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.lblOtrC);
            this.Controls.Add(this.lblOtros);
            this.Controls.Add(this.lblSerC);
            this.Controls.Add(this.lblServicios);
            this.Controls.Add(this.lblInmC);
            this.Controls.Add(this.lblInmuebles);
            this.Controls.Add(this.lblAutC);
            this.Controls.Add(this.lblAutomotores);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblAutomotores;
        private System.Windows.Forms.Label lblAutC;
        private System.Windows.Forms.Label lblInmuebles;
        private System.Windows.Forms.Label lblInmC;
        private System.Windows.Forms.Label lblServicios;
        private System.Windows.Forms.Label lblSerC;
        private System.Windows.Forms.Label lblOtros;
        private System.Windows.Forms.Label lblOtrC;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvProductos;
    }
}

