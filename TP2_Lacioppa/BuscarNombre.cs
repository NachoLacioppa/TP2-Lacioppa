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
    public partial class frmBuscarnombre : Form
    {
        public frmBuscarnombre()
        {
            InitializeComponent();
        }
        SqlConnection conexionDb = new SqlConnection("server=localhost\\sqlexpress ; database=CATALOGO_DB ; integrated security = true");
        private void BtnBuscarNombre_Click(object sender, EventArgs e)
        {
            conexionDb.Open();
            string query = "select a.codigo,a.nombre,a.descripcion,m.descripcion as 'Marca',c.descripcion as 'Categoria',a.precio,a.imagen as 'Ruta de Imagen' from ARTICULOS a inner join CATEGORIAS as c on c.id = a.IdCategoria inner join MARCAS as m on m.id = a.IdMarca where Nombre = '" + txtBuscarNombre.Text + "'";
            SqlCommand comando = new SqlCommand(query, conexionDb);
            SqlDataAdapter adt = new SqlDataAdapter();
            adt.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adt.Fill(tabla);
            dtgBuscarnombre.DataSource = tabla;
            if (tabla.Rows.Count < 1)
            {
                MessageBox.Show("NO HAY NADA!");
            }
            conexionDb.Close();
        }

        private void frmBuscarnombre_Load(object sender, EventArgs e)
        {

        }
    }
}
