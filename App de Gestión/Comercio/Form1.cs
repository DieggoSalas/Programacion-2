using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Clases;

namespace Comercio
{
    public partial class FrmArticulo : Form
    {
        private List<Articulo> ArtDatos;
        public FrmArticulo()
        {
            InitializeComponent();
        }
        public void cargar()
        {
            ArticuloDatos datos = new ArticuloDatos();
            try
            {
                ArtDatos = datos.listar();
                dgvArticulos.DataSource = ArtDatos;
                ocultarColumnas();
                ImagenDatos.cargarImagen(pbxArticulo, ArtDatos[0].ImagenUrl);
                txtFiltro.Text = "";
                txtFiltroAvz.Text = "";
                lblActualizar.Text = "";
                lblCampoR.Text = "";
                lblCriterioR.Text = "";
                lblFiltroR.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                ImagenDatos.cargarImagen(pbxArticulo, seleccionado.ImagenUrl);               
                btnDetalles.Enabled = true;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {                
                btnDetalles.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            cargar();
            cbxCampo.Items.Add("Nombre");
            cbxCampo.Items.Add("Precio");
            cbxCampo.Items.Add("Codigo");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            Articulo elegido;
            try
            {
                if (dgvArticulos.CurrentRow != null)
                {
                    elegido = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    frmDetallesArt detalles = new frmDetallesArt(elegido);
                    detalles.ShowDialog();
                }
                else
                {
                    lblActualizar.Text = "Seleccione un artículo para ver sus detalles.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());                
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaArticulo alta = new AltaArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {            
            Articulo elegido;
            try
            {
                if (dgvArticulos.CurrentRow != null)
                {
                    elegido = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    AltaArticulo modificar = new AltaArticulo(elegido);
                    modificar.ShowDialog();
                    cargar();
                }
                else
                {
                    lblActualizar.Text = "Seleccione un artículo para modificar.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloDatos datos = new ArticuloDatos();
            Articulo elegido = new Articulo();
            try
            {
                if (dgvArticulos.CurrentRow != null)
                {                    
                    DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar este artículo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        elegido = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                        datos.eliminar(elegido.Id);
                        cargar();
                    }
                }
                else
                {
                    lblActualizar.Text = "Seleccione un artículo para eliminar.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEmpresas_Click(object sender, EventArgs e)
        {
            frmEmpresas empresa = new frmEmpresas();
            empresa.ShowDialog();
            cargar();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listafiltrada;
            string filtro = txtFiltro.Text;
            if (filtro != "")
            {
                listafiltrada = ArtDatos.FindAll(aux => aux.Nombre.ToUpper().Contains(filtro.ToUpper()) || aux.Codigo.ToUpper().Contains(filtro.ToUpper()) || aux.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || aux.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listafiltrada = ArtDatos;                
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listafiltrada;
            ocultarColumnas();
        }

        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbxCampo.SelectedItem.ToString();
            if (opcion == "Nombre")
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Empieza con...");
                cbxCriterio.Items.Add("Termina con...");
                cbxCriterio.Items.Add("Contiene...");
            }
            else if(opcion == "Precio")
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Mayor a...");
                cbxCriterio.Items.Add("Menor a...");
                cbxCriterio.Items.Add("Igual a...");
            }
            else
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Empieza con...");
                cbxCriterio.Items.Add("Termina con...");
                cbxCriterio.Items.Add("Contiene...");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloDatos datos = new ArticuloDatos();
            try
            {
                if (validarFiltro())
                    return;
                string campo = cbxCampo.SelectedItem.ToString();
                string criterio = cbxCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvz.Text;
                dgvArticulos.DataSource = datos.filtar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool validarFiltro()
        {
            if (cbxCampo.SelectedIndex < 0)
            {
                lblCampoR.Text = "Elija una opción del campo.";
                return true;
            }
            if (cbxCriterio.SelectedIndex < 0)
            {
                lblCriterioR.Text = "Elija una opción del criterio.";
                return true;
            }
            if (cbxCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltroAvz.Text))
                {
                    lblFiltroR.Text = "Debe cargar el filtro.";
                    return true;
                }
                if (validarNumeros())
                {
                    errorFiltro.SetError(txtFiltroAvz, "Ingresar solo números.");
                    return true;
                }
                else
                {
                    errorFiltro.Clear();
                }
            }
            else if(cbxCampo.SelectedItem.ToString() == "Nombre" || cbxCampo.SelectedItem.ToString() == "Codigo")
            {
                if (string.IsNullOrEmpty(txtFiltroAvz.Text))
                {
                    lblFiltroR.Text = "Debe cargar el filtro.";
                    return true;
                }
            }
            return false;
        }

        private bool validarNumeros()
        {            
            foreach (char caracter in txtFiltroAvz.Text)
            {
                if (!(char.IsNumber(caracter)))
                {                    
                    return true;
                }
            }            
            return false;
        }       
    }
}
