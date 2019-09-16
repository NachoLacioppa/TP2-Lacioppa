namespace TP2_Lacioppa
{
    partial class MostrarTodosArticulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMostrarTodosArticulosAtras = new System.Windows.Forms.Button();
            this.dtgMostrarTodosArticulos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMostrarTodosArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarTodosArticulosAtras
            // 
            this.btnMostrarTodosArticulosAtras.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodosArticulosAtras.Location = new System.Drawing.Point(13, 491);
            this.btnMostrarTodosArticulosAtras.Name = "btnMostrarTodosArticulosAtras";
            this.btnMostrarTodosArticulosAtras.Size = new System.Drawing.Size(142, 59);
            this.btnMostrarTodosArticulosAtras.TabIndex = 1;
            this.btnMostrarTodosArticulosAtras.Text = "<<ATRAS";
            this.btnMostrarTodosArticulosAtras.UseVisualStyleBackColor = true;
            this.btnMostrarTodosArticulosAtras.Click += new System.EventHandler(this.BtnMostrarTodosArticulosAtras_Click);
            // 
            // dtgMostrarTodosArticulos
            // 
            this.dtgMostrarTodosArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMostrarTodosArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMostrarTodosArticulos.Location = new System.Drawing.Point(13, 13);
            this.dtgMostrarTodosArticulos.Name = "dtgMostrarTodosArticulos";
            this.dtgMostrarTodosArticulos.Size = new System.Drawing.Size(858, 472);
            this.dtgMostrarTodosArticulos.TabIndex = 2;
            // 
            // MostrarTodosArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 557);
            this.Controls.Add(this.dtgMostrarTodosArticulos);
            this.Controls.Add(this.btnMostrarTodosArticulosAtras);
            this.Name = "MostrarTodosArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar todos los articulos";
            this.Load += new System.EventHandler(this.MostrarTodosArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMostrarTodosArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMostrarTodosArticulosAtras;
        private System.Windows.Forms.DataGridView dtgMostrarTodosArticulos;
    }
}