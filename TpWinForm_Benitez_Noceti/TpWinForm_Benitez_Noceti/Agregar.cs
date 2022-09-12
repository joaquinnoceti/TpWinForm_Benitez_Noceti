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
    public partial class Agregar : Form
    {
        private List<Articulo> listaArt;
        public Agregar()
        {
            InitializeComponent();
        }

        private void dgvArticulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            ArticuloNegocio AN = new ArticuloNegocio();
            listaArt = AN.listar();
            dgvArticulo.DataSource = listaArt;
            dgvArticulo.Columns["imagen"].Visible = false;
            cargarImagen(listaArt[0].imagen);
        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            Articulo art = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
            cargarImagen(art.imagen);
        }

        private void cargarImagen(string url)
        {
            try
            {
                pbArticulo.Load(url);
            }
            catch (Exception)
            {

                pbArticulo.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
            
        }
    }
}
