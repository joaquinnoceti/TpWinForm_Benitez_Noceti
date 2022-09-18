using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;


namespace TpWinForm_Benitez_Noceti
{
    public partial class frmPrincipal : Form
    {
        private List<Articulo> listaArticulos;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Agregar agregar = new Agregar();
            agregar.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            listaArticulos = negocio.listar();
            dgvArticulos.DataSource = listaArticulos;

        }




        private void dgvArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VistaPrevia vista = new VistaPrevia();
            Articulo articulo = new Articulo();

            articulo.codArt = dgvArticulos.Rows[e.RowIndex].Cells[0].Value.ToString();
            articulo.Nombre = dgvArticulos.Rows[e.RowIndex].Cells[1].Value.ToString();
            articulo.descripcion = dgvArticulos.Rows[e.RowIndex].Cells[2].Value.ToString();
            articulo.marca = (Marca)dgvArticulos.Rows[e.RowIndex].Cells[3].Value;
            articulo.categoria = (Categoria)dgvArticulos.Rows[e.RowIndex].Cells[4].Value;
            articulo.precio = (double)dgvArticulos.Rows[e.RowIndex].Cells[5].Value;
            articulo.imagen = dgvArticulos.Rows[e.RowIndex].Cells[6].Value.ToString();




            vista.cargarArticulo(articulo);
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ArticuloNegocio art = new ArticuloNegocio();

            if (e.ColumnIndex == 8)
            {
                string codart = dgvArticulos.Rows[e.RowIndex].Cells[0].Value.ToString();
                art.eliminar(codart);
            }
            listaArticulos = art.listar();
            dgvArticulos.DataSource = listaArticulos;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Articulo> filtro;
            ArticuloNegocio negocio = new ArticuloNegocio();

            if (txtSearch.Text == "")
            {
                filtro = negocio.listar();
            }
            else
            {
                filtro = listaArticulos.FindAll(x => x.Nombre.ToLower().Contains(txtSearch.Text.ToLower()) || x.categoria.descr.ToLower().Contains(txtSearch.Text.ToLower()));

            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = filtro;
        }
    }
}
