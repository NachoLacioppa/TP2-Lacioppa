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
    public partial class frmEliminarArticulo : Form
    {
        SqlConnection conexionDb = new SqlConnection("server=localhost\\sqlexpress ; database=CATALOGO_DB ; integrated security = true");
        public frmEliminarArticulo()
        {
            InitializeComponent();
        }

        private void BtnBuscarArticulo_Click(object sender, EventArgs e)
        {
            conexionDb.Open();
            SqlCommand comando = new SqlCommand("select * from ARTICULOS where codigo = @Codigo", conexionDb);
            

        }

        private void FrmEliminarArticulo_Load(object sender, EventArgs e)
        {
            mostrar_todo();
        }

        private void mostrar_todo()
        {
            try
            {
                conexionDb.Open();
                SqlCommand comando = new SqlCommand("select a.codigo,a.nombre,a.descripcion,m.descripcion as 'Marca',c.descripcion as 'Categoria',a.precio,a.imagen as 'Ruta de Imagen' from ARTICULOS a inner join CATEGORIAS as c on c.id = a.IdCategoria inner join MARCAS as m on m.id = a.IdMarca", conexionDb);
                SqlDataAdapter adt = new SqlDataAdapter();
                adt.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adt.Fill(tabla);
                dtgEliminarArticulo.DataSource = tabla;
                conexionDb.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnEliminarArticulo_Click(object sender, EventArgs e)
        {

            conexionDb.Open();
            string query = "delete from articulos where codigo = '" + dtgEliminarArticulo.CurrentRow.Cells[0].Value + "'";
            SqlCommand comando = new SqlCommand(query, conexionDb);
            if (comando.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("ELIMINADO!");
                conexionDb.Close();

            }
            else
            {
                MessageBox.Show(query);
            }
            mostrar_todo();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
