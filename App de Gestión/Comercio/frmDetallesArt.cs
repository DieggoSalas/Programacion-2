using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using Datos;

namespace Comercio
{
    public partial class frmDetallesArt : Form
    {
        private Articulo articulo = null;
        public frmDetallesArt()
        {
            InitializeComponent();
        }
        public frmDetallesArt(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void frmDetallesArt_Load(object sender, EventArgs e)
        {
            try
            {
                lblNombreD.Text = articulo.Nombre;
                ImagenDatos.cargarImagen(pbxImagenD, articulo.ImagenUrl);
                lblDescripcionD.Text = articulo.Descripcion;
                lblPrecioD.Text = articulo.Precio.ToString();
                lblCodigoD.Text = articulo.Codigo;
                lblCategoriaD.Text = articulo.Categoria.Descripcion;
                lblMarcaD.Text = articulo.Marca.Descripcion;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
