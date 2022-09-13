using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Clases;
using Datos;

namespace Comercio
{
    public partial class AltaArticulo : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog imagen = null;
        private bool error = false;
        public AltaArticulo()
        {
            InitializeComponent();
        }
        public AltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar un Artículo";
        }

        private void AltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriaDatos categoria = new CategoriaDatos();
            MarcaDatos marca = new MarcaDatos();
            try
            {
                cbxCategoria.DataSource = categoria.listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";
                cbxCategoria.SelectedIndex = -1;
                cbxMarca.DataSource = marca.listar();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";
                cbxMarca.SelectedIndex = -1;

                if (articulo != null)
                {
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtImagen.Text = articulo.ImagenUrl;
                    ImagenDatos.cargarImagen(pbxAltaImagen, articulo.ImagenUrl);
                    txtPrecio.Text = articulo.Precio.ToString();
                    txtCodigo.Text = articulo.Codigo;
                    cbxCategoria.SelectedValue = articulo.Categoria.Id;
                    cbxMarca.SelectedValue = articulo.Marca.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }       

        private void btnAcepar_Click(object sender, EventArgs e)
        {
            ArticuloDatos datos = new ArticuloDatos();
            try
            {                
                if (articulo == null)
                    articulo = new Articulo();
                if (!(validarCampos()))
                {
                    articulo.Nombre = txtNombre.Text;
                    articulo.Descripcion = txtDescripcion.Text;
                    articulo.ImagenUrl = txtImagen.Text;
                    articulo.Precio = decimal.Parse(txtPrecio.Text);
                    articulo.Codigo = txtCodigo.Text;
                    articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;
                    articulo.Marca = (Marca)cbxMarca.SelectedItem;
                    if (imagen != null && !(txtImagen.Text.ToUpper().Contains("HTTP")))
                    {
                        File.Copy(imagen.FileName, ConfigurationManager.AppSettings["carpeta_imagen"] + imagen.SafeFileName);
                    }
                    if (articulo.Id != 0)
                    {
                        datos.modificar(articulo);
                        MessageBox.Show("Modificado correctamente.");
                    }
                    else
                    {
                        datos.agregar(articulo);
                        MessageBox.Show("Agregado correctamente.");
                    }
                    Close();
                }
                else if(error)
                {
                    if(txtNombre.Text == "")
                        errorNombre.SetError(txtNombre, "Debe completar el campo.");
                    else
                        errorNombre.Clear();
                    if(txtDescripcion.Text == "")
                        errorDescripcion.SetError(txtDescripcion, "Debe completar el campo.");
                    else
                        errorDescripcion.Clear();
                    if(txtImagen.Text == "")
                        errorImagen.SetError(txtImagen, "Debe completar el campo.");
                    else
                        errorImagen.Clear();
                    if(txtPrecio.Text == "")
                        errorPrecio.SetError(txtPrecio, "Debe completar el campo solo con números.");
                    else
                        errorPrecio.Clear();
                    if(txtCodigo.Text == "")
                        errorCodigo.SetError(txtCodigo, "Debe completar el campo con no mas de 3 caracteres.");
                    else
                        errorCodigo.Clear();
                    if(cbxCategoria.SelectedIndex == -1)
                        errorCategoria.SetError(cbxCategoria, "Debe seleccionar una opción.");
                    else
                        errorCategoria.Clear();
                    if(cbxMarca.SelectedIndex == -1)
                        errorMarca.SetError(cbxMarca, "Debe seleccionar una opción.");
                    else
                        errorMarca.Clear();
                    error = false;
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       private bool validarCampos()
       {            
            if (txtNombre.Text == "" || txtDescripcion.Text == "" || txtImagen.Text == "" || txtPrecio.Text == "" || txtCodigo.Text == "" || cbxCategoria.SelectedIndex == -1 || cbxMarca.SelectedIndex == -1)
            {
                error = true;                
                foreach (char caracter in txtPrecio.Text)
                {
                    if (!(char.IsNumber(caracter) && char.IsDigit(caracter)))
                    {
                        return true;
                    }
                }
                return true;
            }
            return false;
       }     

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            Articulo img = new Articulo();
            img.ImagenUrl = txtImagen.Text;
            ImagenDatos.cargarImagen(pbxAltaImagen, img.ImagenUrl);
        }        

        private void btnAgregarImg_Click(object sender, EventArgs e)
        {
            imagen = new OpenFileDialog();
            imagen.Filter = "jpg|*.jpg;|png|*.png;|ico|*.ico";
            if (imagen.ShowDialog() == DialogResult.OK)
            {
                txtImagen.Text = imagen.FileName;
                ImagenDatos.cargarImagen(pbxAltaImagen, imagen.FileName);
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            bool errorcito = false;
            foreach (char caracter in txtPrecio.Text)
            {
                if (!(char.IsNumber(caracter) && char.IsDigit(caracter)))
                {
                    errorcito = true;                    
                }
            }
            if (errorcito)
            {
                errorPrecio.SetError(txtPrecio, "Ingresar solo números.");
            }
            else
            {
                errorPrecio.Clear();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
