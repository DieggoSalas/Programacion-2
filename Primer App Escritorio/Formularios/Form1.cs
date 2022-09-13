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
    public partial class frmPrincipal : Form
    {    
        private List<Producto> lista;
        public List<int> estadisticas;
        public frmPrincipal()
        {
            InitializeComponent();
        }
        public List<Producto> Lista
        {
            get { return lista; }
            set { lista = value; }
        }
        
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Lista = new List<Producto>();
            estadisticas = new List<int>();
            estadisticas.Add(0);
            estadisticas.Add(0);
            estadisticas.Add(0);
            estadisticas.Add(0);
            estadisticas.Add(0);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmNuevo nuevo = new frmNuevo(this);
            nuevo.ShowDialog();
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = lista;
            Estadistica();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                Producto clik = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                frmNuevo nuevo = new frmNuevo(this, clik);
                nuevo.ShowDialog();
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = lista;
                Estadistica();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                DialogResult eliminar = MessageBox.Show("¿Desea eliminar este registro?","Advertencia",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (eliminar == DialogResult.Yes)
                {
                    Producto clik = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                    lista.Remove(clik);
                    estadisticas[4] -= int.Parse(clik.Cantidad.ToString());
                    if (clik.Categoria.ToString() == "Automotores")
                        estadisticas[0] -= int.Parse(clik.Cantidad.ToString());
                    else if (clik.Categoria.ToString() == "Inmuebles")
                        estadisticas[1] -= int.Parse(clik.Cantidad.ToString());
                    else if (clik.Categoria.ToString() == "Servicios")
                        estadisticas[2] -= int.Parse(clik.Cantidad.ToString());
                    else if (clik.Categoria.ToString() == "Otros")
                        estadisticas[3] -= int.Parse(clik.Cantidad.ToString());
                    dgvProductos.DataSource = null;
                    dgvProductos.DataSource = lista;
                    Estadistica();
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Producto> listafiltrada;
            string filtro = txtBuscar.Text;
            if (filtro != "")
            {
                listafiltrada = lista.FindAll(x => x.Codigo.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listafiltrada = lista;
            }
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = listafiltrada;
        }

        private void Estadistica()
        {
            lblAutC.Text = estadisticas[0].ToString();
            lblInmC.Text = estadisticas[1].ToString();
            lblSerC.Text = estadisticas[2].ToString();
            lblOtrC.Text = estadisticas[3].ToString();
            lblTotal.Text = estadisticas[4].ToString();
        }
    }
}
