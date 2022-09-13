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
    public partial class frmEmpresas : Form
    {
        public frmEmpresas()
        {
            InitializeComponent();
        }

        private void frmEmpresas_Load(object sender, EventArgs e)
        {
            cargar();   
        }

        private void cargar()
        {
            MarcaDatos marca = new MarcaDatos();
            CategoriaDatos categoria = new CategoriaDatos();
            MarcaDatos eliminarMarca = new MarcaDatos();
            CategoriaDatos eliminarCategoria = new CategoriaDatos();
            try
            {
                cbxMarcas.DataSource = marca.listar();
                cbxCategoria.DataSource = categoria.listar();
                cbxQuitarM.DataSource = eliminarMarca.listar();
                cbxQuitarM.ValueMember = "Id";
                cbxQuitarM.DisplayMember = "Descripcion";
                cbxQuitarM.SelectedIndex = -1;
                cbxQuitarC.DataSource = eliminarCategoria.listar();
                cbxQuitarC.ValueMember = "Id";
                cbxQuitarC.DisplayMember = "Descripcion";
                cbxQuitarC.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarM_Click(object sender, EventArgs e)
        {
            MarcaDatos marca = new MarcaDatos();
            Marca nuevaMarca = new Marca();
            try
            {
                validarTxt(txtMarca, errorMarcaA);                
                if(txtMarca.Text != "")
                {
                    nuevaMarca.Descripcion = txtMarca.Text; 
                    marca.agregar(nuevaMarca);
                    MessageBox.Show("La marca "+ txtMarca.Text +" fue agregada correctamente.");
                    cargar();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnQuitarM_Click(object sender, EventArgs e)
        {
            MarcaDatos marca = new MarcaDatos();
            Marca chauMarca = new Marca();
            try
            {
                validarCbx(cbxQuitarM, errorMarcaQ);
                if (cbxQuitarM.SelectedIndex != -1)
                {
                    DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar esta marca?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        chauMarca.Id = (int)cbxQuitarM.SelectedValue;
                        marca.eliminar(chauMarca.Id);
                        cargar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarC_Click(object sender, EventArgs e)
        {
            CategoriaDatos categoria = new CategoriaDatos();
            Categoria nuevaCategoria = new Categoria();
            try
            {
                validarTxt(txtCategoria, errorCategoriaA);
                if (txtCategoria.Text != "")
                {
                    nuevaCategoria.Descripcion = txtCategoria.Text;
                    categoria.agregar(nuevaCategoria);
                    MessageBox.Show("La categoría "+ txtCategoria.Text +" fue agregada correctamente.");
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnQuitarC_Click(object sender, EventArgs e)
        {
            CategoriaDatos categoria = new CategoriaDatos();
            Categoria chauCategoria = new Categoria();
            try
            {
                validarCbx(cbxQuitarC, errorCategoriaQ);
                if (cbxQuitarC.SelectedIndex != -1)
                {
                    DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar esta categoría?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        chauCategoria.Id = (int)cbxQuitarC.SelectedValue;
                        categoria.eliminar(chauCategoria.Id);
                        cargar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void validarTxt(TextBox txt, ErrorProvider provider)
        {
            bool error = false;
            if (txt.Text == "")
            {
                error = true;                
            }
            if (error)
            {
                provider.SetError(txt, "Debe completar el campo.");                
            }
            else
            {
                provider.Clear();                
            }
        }

        private void validarCbx(ComboBox desplegable, ErrorProvider provider)
        {
            bool error = false;
            if (desplegable.SelectedIndex == -1)
            {
                error = true;
            }
            if (error)
            {
                provider.SetError(desplegable, "Debe elegir una opción.");
            }
            else
            {
                provider.Clear();
            }
        }
    }
}
