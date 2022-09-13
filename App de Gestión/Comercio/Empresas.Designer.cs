namespace Comercio
{
    partial class frmEmpresas
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
            this.components = new System.ComponentModel.Container();
            this.lblMarcas = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbxMarcas = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.btnAgregarM = new System.Windows.Forms.Button();
            this.btnAgregarC = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.btnQuitarM = new System.Windows.Forms.Button();
            this.cbxQuitarM = new System.Windows.Forms.ComboBox();
            this.btnQuitarC = new System.Windows.Forms.Button();
            this.cbxQuitarC = new System.Windows.Forms.ComboBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.errorMarcaA = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMarcaQ = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCategoriaA = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCategoriaQ = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorMarcaA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMarcaQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCategoriaA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCategoriaQ)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Location = new System.Drawing.Point(10, 65);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(94, 20);
            this.lblMarcas.TabIndex = 0;
            this.lblMarcas.Text = "Ver Marcas:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(252, 65);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(119, 20);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "Ver Categorías:";
            // 
            // cbxMarcas
            // 
            this.cbxMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarcas.FormattingEnabled = true;
            this.cbxMarcas.Location = new System.Drawing.Point(111, 60);
            this.cbxMarcas.Name = "cbxMarcas";
            this.cbxMarcas.Size = new System.Drawing.Size(121, 28);
            this.cbxMarcas.TabIndex = 2;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(375, 62);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(121, 28);
            this.cbxCategoria.TabIndex = 3;
            // 
            // btnAgregarM
            // 
            this.btnAgregarM.Location = new System.Drawing.Point(14, 115);
            this.btnAgregarM.Name = "btnAgregarM";
            this.btnAgregarM.Size = new System.Drawing.Size(90, 33);
            this.btnAgregarM.TabIndex = 4;
            this.btnAgregarM.Text = "Agregar";
            this.btnAgregarM.UseVisualStyleBackColor = true;
            this.btnAgregarM.Click += new System.EventHandler(this.btnAgregarM_Click);
            // 
            // btnAgregarC
            // 
            this.btnAgregarC.Location = new System.Drawing.Point(281, 115);
            this.btnAgregarC.Name = "btnAgregarC";
            this.btnAgregarC.Size = new System.Drawing.Size(90, 33);
            this.btnAgregarC.TabIndex = 5;
            this.btnAgregarC.Text = "Agregar";
            this.btnAgregarC.UseVisualStyleBackColor = true;
            this.btnAgregarC.Click += new System.EventHandler(this.btnAgregarC_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(111, 118);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(121, 26);
            this.txtMarca.TabIndex = 6;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(375, 118);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(121, 26);
            this.txtCategoria.TabIndex = 7;
            // 
            // btnQuitarM
            // 
            this.btnQuitarM.Location = new System.Drawing.Point(14, 171);
            this.btnQuitarM.Name = "btnQuitarM";
            this.btnQuitarM.Size = new System.Drawing.Size(90, 31);
            this.btnQuitarM.TabIndex = 8;
            this.btnQuitarM.Text = "Quitar";
            this.btnQuitarM.UseVisualStyleBackColor = true;
            this.btnQuitarM.Click += new System.EventHandler(this.btnQuitarM_Click);
            // 
            // cbxQuitarM
            // 
            this.cbxQuitarM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQuitarM.FormattingEnabled = true;
            this.cbxQuitarM.Location = new System.Drawing.Point(111, 173);
            this.cbxQuitarM.Name = "cbxQuitarM";
            this.cbxQuitarM.Size = new System.Drawing.Size(121, 28);
            this.cbxQuitarM.TabIndex = 9;
            // 
            // btnQuitarC
            // 
            this.btnQuitarC.Location = new System.Drawing.Point(279, 170);
            this.btnQuitarC.Name = "btnQuitarC";
            this.btnQuitarC.Size = new System.Drawing.Size(90, 31);
            this.btnQuitarC.TabIndex = 10;
            this.btnQuitarC.Text = "Quitar";
            this.btnQuitarC.UseVisualStyleBackColor = true;
            this.btnQuitarC.Click += new System.EventHandler(this.btnQuitarC_Click);
            // 
            // cbxQuitarC
            // 
            this.cbxQuitarC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQuitarC.FormattingEnabled = true;
            this.cbxQuitarC.Location = new System.Drawing.Point(375, 172);
            this.cbxQuitarC.Name = "cbxQuitarC";
            this.cbxQuitarC.Size = new System.Drawing.Size(121, 28);
            this.cbxQuitarC.TabIndex = 11;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(225, 246);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(89, 34);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // errorMarcaA
            // 
            this.errorMarcaA.ContainerControl = this;
            // 
            // errorMarcaQ
            // 
            this.errorMarcaQ.ContainerControl = this;
            // 
            // errorCategoriaA
            // 
            this.errorCategoriaA.ContainerControl = this;
            // 
            // errorCategoriaQ
            // 
            this.errorCategoriaQ.ContainerControl = this;
            // 
            // frmEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 313);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.cbxQuitarC);
            this.Controls.Add(this.btnQuitarC);
            this.Controls.Add(this.cbxQuitarM);
            this.Controls.Add(this.btnQuitarM);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.btnAgregarC);
            this.Controls.Add(this.btnAgregarM);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxMarcas);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarcas);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(560, 369);
            this.MinimumSize = new System.Drawing.Size(560, 369);
            this.Name = "frmEmpresas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresas";
            this.Load += new System.EventHandler(this.frmEmpresas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorMarcaA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMarcaQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCategoriaA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCategoriaQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarcas;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbxMarcas;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Button btnAgregarM;
        private System.Windows.Forms.Button btnAgregarC;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Button btnQuitarM;
        private System.Windows.Forms.ComboBox cbxQuitarM;
        private System.Windows.Forms.Button btnQuitarC;
        private System.Windows.Forms.ComboBox cbxQuitarC;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ErrorProvider errorMarcaA;
        private System.Windows.Forms.ErrorProvider errorMarcaQ;
        private System.Windows.Forms.ErrorProvider errorCategoriaA;
        private System.Windows.Forms.ErrorProvider errorCategoriaQ;
    }
}