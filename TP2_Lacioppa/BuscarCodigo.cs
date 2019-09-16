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
    public partial class frmBuscarArticulo : Form
    {
        SqlConnection conexionDb = new SqlConnection("server=localhost\\sqlexpress ; database=CATALOGO_DB ; integrated security = true");
        public frmBuscarArticulo()
        {
            InitializeComponent();
        }

        private void BtnBuscarCodigo_Click(object sender, EventArgs e)
        {
            conexionDb.Open();
            string query = "select a.codigo,a.nombre,a.descripcion,m.descripcion as 'Marca',c.descripcion as 'Categoria',a.precio,a.imagen as 'Ruta de Imagen' from ARTICULOS a inner join CATEGORIAS as c on c.id = a.IdCategoria inner join MARCAS as m on m.id = a.IdMarca where codigo = '" + txtBuscarCodigo.Text + "'";
            SqlCommand comando = new SqlCommand(query, conexionDb);
            SqlDataAdapter adt = new SqlDataAdapter();
            adt.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adt.Fill(tabla);
            dtgBuscarCodigo.DataSource = tabla;
            if (tabla.Rows.Count < 1)
            {
                MessageBox.Show("NO HAY NADA!");
            }
            conexionDb.Close();
        }

        private void frmBuscarArticulo_Load(object sender, EventArgs e)
        {

        }
    }
}
