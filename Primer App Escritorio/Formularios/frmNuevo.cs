using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmNuevo : Form
    {
        frmPrincipal principal;
        Producto producto = null;
        bool existe = false;
        int masomenos = 0;
        public frmNuevo(frmPrincipal principal, Producto producto = null)
        {
            InitializeComponent();
            this.principal = principal;
            if (producto != null)
            {
                this.producto = producto;
                existe = true;
                Text = "Modificar Registro";
            }
        }        

        private void frmNuevo_Load(object sender, EventArgs e)
        {
            cbxCategoria.Items.Add("Automotores");
            cbxCategoria.Items.Add("Inmuebles");
            cbxCategoria.Items.Add("Servicios");
            cbxCategoria.Items.Add("Otros");

            if (producto != null)
            {
                txtCodigo.Text = producto.Codigo;
                txtDescripcion.Text = producto.Descripcion;
                cbxCategoria.SelectedItem = producto.Categoria;
                txtPrecio.Text = producto.Precio.ToString();
                txtCantidad.Text = producto.Cantidad.ToString();
                masomenos = producto.Cantidad;
            }            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (producto == null)
            {
                producto = new Producto();
            }
            producto.Codigo = txtCodigo.Text;
            producto.Descripcion = txtDescripcion.Text;
            producto.Categoria = (string)cbxCategoria.SelectedItem;
            producto.Precio = decimal.Parse(txtPrecio.Text);
            producto.Cantidad = int.Parse(txtCantidad.Text);
            if (existe)
            {
                var ind = principal.Lista.IndexOf(producto);
                principal.Lista.RemoveAt(ind);
                principal.Lista.Insert(ind, producto);
                Calcular(producto);
                MessageBox.Show("Producto modificado correctamente.");
            }
            else
            {
                principal.Lista.Add(producto);                
                Calcular(producto);
                MessageBox.Show("Producto agregado correctamente.");
            }
            Close();
        }

        private void Calcular(Producto producto)
        {
            if (producto.Cantidad > masomenos)
            {
                principal.estadisticas[4] += int.Parse(txtCantidad.Text);
                if (producto.Categoria.ToString() == "Automotores")            
                    principal.estadisticas[0] += int.Parse(producto.Cantidad.ToString());            
                else if (producto.Categoria.ToString() == "Inmuebles")            
                    principal.estadisticas[1] += int.Parse(producto.Cantidad.ToString());
                else if (producto.Categoria.ToString() == "Servicios")
                    principal.estadisticas[2] += int.Parse(producto.Cantidad.ToString());
                else if (producto.Categoria.ToString() == "Otros")
                    principal.estadisticas[3] += int.Parse(producto.Cantidad.ToString());
            }
            else
            {
                principal.estadisticas[4] -= int.Parse(txtCantidad.Text);
                if (producto.Categoria.ToString() == "Automotores")
                    principal.estadisticas[0] -= int.Parse(producto.Cantidad.ToString());
                else if (producto.Categoria.ToString() == "Inmuebles")
                    principal.estadisticas[1] -= int.Parse(producto.Cantidad.ToString());
                else if (producto.Categoria.ToString() == "Servicios")
                    principal.estadisticas[2] -= int.Parse(producto.Cantidad.ToString());
                else if (producto.Categoria.ToString() == "Otros")
                    principal.estadisticas[3] -= int.Parse(producto.Cantidad.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
