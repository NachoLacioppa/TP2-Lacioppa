using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TP2_Lacioppa
{
    public partial class frmModificarArticulo : Form
    {
        SqlConnection conexionDb = new SqlConnection("server=localhost\\sqlexpress ; database=CATALOGO_DB ; integrated security = true");
        public frmModificarArticulo()
        {
            InitializeComponent();
        }

        private void TxtAgregarArticuloCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImagen = new OpenFileDialog();
            getImagen.InitialDirectory = "C:\\";
            getImagen.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if (getImagen.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.ImageLocation = getImagen.FileName;
                txtRutaImg.Text = getImagen.FileName;
            }
            else
            {
                MessageBox.Show("SELECCIONE IMAGEN POR FAVOR!");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            conexionDb.Open();
            string query = "select * from articulos where codigo = '" + txtCodigo.Text + "'";
            SqlCommand comando = new SqlCommand(query, conexionDb);
            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                txtCodigoNuevo.Text = dr["Codigo"].ToString();
                txtNombre.Text = dr["Nombre"].ToString();
                txtDesc.Text = dr["Descripcion"].ToString();
                txtPrecio.Text = dr["Precio"].ToString();
                txtRutaImg.Text = dr["Imagen"].ToString();
                cboCategoria.SelectedItem = dr["IdCategoria"].ToString();
                cboMarca.SelectedItem = dr["IdMarca"].ToString();

                pictureBox2.ImageLocation = txtRutaImg.Text;
            }
            conexionDb.Close();
        }

        private void FrmModificarArticulo_Load(object sender, EventArgs e)
        {
            //ABRIR CONEXION
            try
            {
                conexionDb.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //COMBO BOX CATEGORIAS
            SqlCommand comandoCat = new SqlCommand("select Descripcion from categorias", conexionDb);
            SqlDataReader registroCat = comandoCat.ExecuteReader();
            while (registroCat.Read())
            {
                cboCategoria.Items.Add(registroCat["Descripcion"].ToString());
            }
            conexionDb.Close();

            try
            {
                conexionDb.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //COMBO BOX MARCAS
            SqlCommand comandoMar = new SqlCommand("select Descripcion from marcas", conexionDb);
            SqlDataReader registroMar = comandoMar.ExecuteReader();
            while (registroMar.Read())
            {
                cboMarca.Items.Add(registroMar["Descripcion"].ToString());
            }
            conexionDb.Close();

        }

        private void btnAgregarArticuloAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "update articulos set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, Imagen = @Imagen, Precio = @Precio where Codigo = " + "'" + txtCodigo.Text + "'";
            conexionDb.Open();
            SqlCommand comando = new SqlCommand(query, conexionDb);
            comando.Parameters.Add("@Codigo", txtCodigoNuevo.Text);
            comando.Parameters.Add("@Nombre", txtNombre.Text);
            comando.Parameters.Add("@Descripcion", txtDesc.Text);
            comando.Parameters.Add("@IdMarca", cboMarca.SelectedIndex + 1);
            comando.Parameters.Add("@IdCategoria",cboCategoria.SelectedIndex + 1);
            comando.Parameters.Add("@Imagen", txtRutaImg.Text);
            comando.Parameters.Add("@Precio",txtPrecio.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("MODIFICA2!");


        }
    }
}
