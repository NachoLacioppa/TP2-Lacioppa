namespace TP2_Lacioppa
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsdArticulos = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnCargarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.mODIFICARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eLIMINARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsdBusqueda = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnBuscarTodos = new System.Windows.Forms.ToolStripMenuItem();
            this.pORNOMBREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pORCODIGOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsdArticulos,
            this.tsdBusqueda,
            this.toolStripSeparator1,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsdArticulos
            // 
            this.tsdArticulos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsdArticulos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCargarArticulo,
            this.mODIFICARToolStripMenuItem,
            this.eLIMINARToolStripMenuItem});
            this.tsdArticulos.Image = ((System.Drawing.Image)(resources.GetObject("tsdArticulos.Image")));
            this.tsdArticulos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdArticulos.Name = "tsdArticulos";
            this.tsdArticulos.Size = new System.Drawing.Size(80, 22);
            this.tsdArticulos.Text = "ARTICULOS";
            // 
            // btnCargarArticulo
            // 
            this.btnCargarArticulo.Name = "btnCargarArticulo";
            this.btnCargarArticulo.Size = new System.Drawing.Size(162, 22);
            this.btnCargarArticulo.Text = "CARGAR NUEVO";
            this.btnCargarArticulo.Click += new System.EventHandler(this.BtnCargarArticulo_Click);
            // 
            // mODIFICARToolStripMenuItem
            // 
            this.mODIFICARToolStripMenuItem.Name = "mODIFICARToolStripMenuItem";
            this.mODIFICARToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.mODIFICARToolStripMenuItem.Text = "MODIFICAR";
            this.mODIFICARToolStripMenuItem.Click += new System.EventHandler(this.MODIFICARToolStripMenuItem_Click);
            // 
            // eLIMINARToolStripMenuItem
            // 
            this.eLIMINARToolStripMenuItem.Name = "eLIMINARToolStripMenuItem";
            this.eLIMINARToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.eLIMINARToolStripMenuItem.Text = "ELIMINAR";
            this.eLIMINARToolStripMenuItem.Click += new System.EventHandler(this.ELIMINARToolStripMenuItem_Click);
            // 
            // tsdBusqueda
            // 
            this.tsdBusqueda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsdBusqueda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBuscarTodos,
            this.pORNOMBREToolStripMenuItem,
            this.pORCODIGOToolStripMenuItem});
            this.tsdBusqueda.Image = ((System.Drawing.Image)(resources.GetObject("tsdBusqueda.Image")));
            this.tsdBusqueda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdBusqueda.Name = "tsdBusqueda";
            this.tsdBusqueda.Size = new System.Drawing.Size(64, 22);
            this.tsdBusqueda.Text = "BUSCAR";
            // 
            // btnBuscarTodos
            // 
            this.btnBuscarTodos.Name = "btnBuscarTodos";
            this.btnBuscarTodos.Size = new System.Drawing.Size(149, 22);
            this.btnBuscarTodos.Text = "TODOS";
            this.btnBuscarTodos.Click += new System.EventHandler(this.BtnBuscarTodos_Click);
            // 
            // pORNOMBREToolStripMenuItem
            // 
            this.pORNOMBREToolStripMenuItem.Name = "pORNOMBREToolStripMenuItem";
            this.pORNOMBREToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.pORNOMBREToolStripMenuItem.Text = "POR NOMBRE";
            this.pORNOMBREToolStripMenuItem.Click += new System.EventHandler(this.PORNOMBREToolStripMenuItem_Click);
            // 
            // pORCODIGOToolStripMenuItem
            // 
            this.pORCODIGOToolStripMenuItem.Name = "pORCODIGOToolStripMenuItem";
            this.pORCODIGOToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.pORCODIGOToolStripMenuItem.Text = "POR CODIGO";
            this.pORCODIGOToolStripMenuItem.Click += new System.EventHandler(this.PORCODIGOToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 22);
            this.btnSalir.Text = "SALIDA";
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsdArticulos;
        private System.Windows.Forms.ToolStripMenuItem btnCargarArticulo;
        private System.Windows.Forms.ToolStripMenuItem mODIFICARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eLIMINARToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tsdBusqueda;
        private System.Windows.Forms.ToolStripMenuItem btnBuscarTodos;
        private System.Windows.Forms.ToolStripMenuItem pORNOMBREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pORCODIGOToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalir;
    }
}

