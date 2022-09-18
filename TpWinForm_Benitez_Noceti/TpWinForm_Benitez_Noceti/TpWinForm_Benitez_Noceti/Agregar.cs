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
        public Agregar()
        {
            InitializeComponent();
        }
 

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo();

            ArticuloNegocio neg = new ArticuloNegocio();
            try
            {
                art.codArt = txtCod.Text;
                art.Nombre = txtNomb.Text;
                art.precio = Convert.ToDouble(txtPrecio.Text);
                art.descripcion = txtDescr.Text;
                art.categoria = (Categoria)cboxCat.SelectedItem;
                art.marca = (Marca)cboxMarca.SelectedItem;
                neg.agregar(art);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            cargarImagen(txtImagen.Text);

            CategoriaNegocio categoria = new CategoriaNegocio();
            MarcaNegocio marca = new MarcaNegocio();


            try
            {
                cboxMarca.DataSource = marca.listar();
                cboxCat.DataSource = categoria.listar();


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);

            }
            catch (Exception)
            {

                pbxArticulo.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/681px-Placeholder_view_vector.svg.png");

            }
        }

        private void txtImagen_TextChanged(object sender, EventArgs e)
        {
            cargarImagen(txtImagen.Text);
        }
    }
}
