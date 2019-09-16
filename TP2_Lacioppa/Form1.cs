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
    
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void BtnCargarArticulo_Click(object sender, EventArgs e)
        {
            AgregarArticuloNuevo ventana = new AgregarArticuloNuevo();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        

        public void BtnBuscarTodos_Click(object sender, EventArgs e)
        {
            MostrarTodosArticulos ventana = new MostrarTodosArticulos();
            ventana.MdiParent = this;
            ventana.Show();
        }

        public void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void ELIMINARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminarArticulo ventana = new frmEliminarArticulo();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void PORCODIGOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarArticulo ventana = new frmBuscarArticulo();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void PORNOMBREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarnombre v = new frmBuscarnombre();
            v.MdiParent = this;
            v.Show();
        }

        private void MODIFICARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarArticulo v = new frmModificarArticulo();
            v.MdiParent = this;
            v.Show();
        }
    }
}
