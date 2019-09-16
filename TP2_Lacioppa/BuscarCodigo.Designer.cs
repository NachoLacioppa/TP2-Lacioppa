namespace TP2_Lacioppa
{
    partial class frmBuscarArticulo
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
            this.btnBuscarCodigo = new System.Windows.Forms.Button();
            this.txtBuscarCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgBuscarCodigo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscarCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarCodigo
            // 
            this.btnBuscarCodigo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCodigo.Location = new System.Drawing.Point(659, 399);
            this.btnBuscarCodigo.Name = "btnBuscarCodigo";
            this.btnBuscarCodigo.Size = new System.Drawing.Size(129, 39);
            this.btnBuscarCodigo.TabIndex = 13;
            this.btnBuscarCodigo.Text = "BUSCAR";
            this.btnBuscarCodigo.UseVisualStyleBackColor = true;
            this.btnBuscarCodigo.Click += new System.EventHandler(this.BtnBuscarCodigo_Click);
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(89, 410);
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(179, 20);
            this.txtBuscarCodigo.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "CODIGO:";
            // 
            // dtgBuscarCodigo
            // 
            this.dtgBuscarCodigo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgBuscarCodigo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBuscarCodigo.Location = new System.Drawing.Point(13, 13);
            this.dtgBuscarCodigo.Name = "dtgBuscarCodigo";
            this.dtgBuscarCodigo.Size = new System.Drawing.Size(775, 380);
            this.dtgBuscarCodigo.TabIndex = 16;
            // 
            // frmBuscarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgBuscarCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBuscarCodigo);
            this.Controls.Add(this.btnBuscarCodigo);
            this.Name = "frmBuscarArticulo";
            this.Text = "Buscar Codigo";
            this.Load += new System.EventHandler(this.frmBuscarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscarCodigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarCodigo;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgBuscarCodigo;
    }
}