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
    public partial class AgregarArticuloNuevo : Form
    {
        SqlConnection conexionDb = new SqlConnection("server=localhost\\sqlexpress ; database=CATALOGO_DB ; integrated security = true");
        public AgregarArticuloNuevo()
        {
            InitializeComponent();
        }

        private void BtnAgregarArticuloAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnAgregarArticuloCargar_Click(object sender, EventArgs e)
        {
            string query = "insert into Articulos (Codigo,nombre,Descripcion,idmarca,idcategoria,Imagen,precio) " +
                "values (@codigo,@nombre,@descripcion,@idmarca,@idcategoria,@Imagen,@precio)";
            conexionDb.Open();
            SqlCommand comando = new SqlCommand(query, conexionDb);
            comando.Parameters.AddWithValue("@nombre", txtAgregarArticuloNombre.Text);
            comando.Parameters.AddWithValue("@codigo", txtAgregarArticuloCodigo.Text);
            comando.Parameters.AddWithValue("@descripcion", txtAgregarArticuloDesc.Text);
            comando.Parameters.AddWithValue("@precio", txttxtAgregarArticuloPrecio.Text);
            comando.Parameters.AddWithValue("@imagen", txtAgregarArticuloRutaImg.Text);
            comando.Parameters.AddWithValue("@idmarca", cboAgregarArticuloMarca.SelectedIndex+1);
            comando.Parameters.AddWithValue("@idcategoria",cboAgregarArticuloCategoria.SelectedIndex+1);
            comando.ExecuteNonQuery();
            MessageBox.Show("ARTICULO AGREGADO!");
            this.Dispose();
            

        }

        private void AgregarArticuloNuevo_Load(object sender, EventArgs e)
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
               cboAgregarArticuloCategoria.Items.Add(registroCat["Descripcion"].ToString());
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
                cboAgregarArticuloMarca.Items.Add(registroMar["Descripcion"].ToString());
            }
            conexionDb.Close();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImagen = new OpenFileDialog();
            getImagen.InitialDirectory = "C:\\";
            getImagen.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if (getImagen.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = getImagen.FileName;
                txtAgregarArticuloRutaImg.Text = getImagen.FileName;
            }
            else
            {
                MessageBox.Show("SELECCIONE IMAGEN POR FAVOR!");
            }
            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

