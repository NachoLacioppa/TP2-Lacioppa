namespace TP2_Lacioppa
{
    partial class frmEliminarArticulo
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
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.dtgEliminarArticulo = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEliminarArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArticulo.Location = new System.Drawing.Point(649, 424);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(139, 39);
            this.btnEliminarArticulo.TabIndex = 14;
            this.btnEliminarArticulo.Text = "ELIMINAR";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.BtnEliminarArticulo_Click);
            // 
            // dtgEliminarArticulo
            // 
            this.dtgEliminarArticulo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgEliminarArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEliminarArticulo.Location = new System.Drawing.Point(13, 13);
            this.dtgEliminarArticulo.Name = "dtgEliminarArticulo";
            this.dtgEliminarArticulo.Size = new System.Drawing.Size(775, 405);
            this.dtgEliminarArticulo.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 39);
            this.button1.TabIndex = 15;
            this.button1.Text = "<<ATRAS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmEliminarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.dtgEliminarArticulo);
            this.Name = "frmEliminarArticulo";
            this.Text = "Eliminar Articulo";
            this.Load += new System.EventHandler(this.FrmEliminarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEliminarArticulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.DataGridView dtgEliminarArticulo;
        private System.Windows.Forms.Button button1;
    }
}