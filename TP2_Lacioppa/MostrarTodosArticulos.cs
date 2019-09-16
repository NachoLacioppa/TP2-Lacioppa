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
    
    public partial class MostrarTodosArticulos : Form
    {

        SqlConnection conexionDb = new SqlConnection("server=localhost\\sqlexpress ; database=CATALOGO_DB ; integrated security = true");
        public MostrarTodosArticulos()
        {
            InitializeComponent();
        }

        private void BtnMostrarTodosArticulosAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DtgMostrarTodosArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void MostrarTodosArticulos_Load(object sender, EventArgs e)
        {
            try
            {
                conexionDb.Open();
                SqlCommand comando = new SqlCommand("select a.codigo,a.nombre,a.descripcion,m.descripcion as 'Marca',c.descripcion as 'Categoria',a.precio,a.imagen as 'Ruta de Imagen' from ARTICULOS a inner join CATEGORIAS as c on c.id = a.IdCategoria inner join MARCAS as m on m.id = a.IdMarca", conexionDb);
                SqlDataAdapter adt = new SqlDataAdapter();
                adt.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adt.Fill(tabla);
                dtgMostrarTodosArticulos.DataSource = tabla;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
       
    }
}
