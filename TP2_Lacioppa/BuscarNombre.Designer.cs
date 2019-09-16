namespace TP2_Lacioppa
{
    partial class frmBuscarnombre
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
            this.dtgBuscarnombre = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.btnBuscarNombre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscarnombre)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgBuscarnombre
            // 
            this.dtgBuscarnombre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgBuscarnombre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBuscarnombre.Location = new System.Drawing.Point(13, 12);
            this.dtgBuscarnombre.Name = "dtgBuscarnombre";
            this.dtgBuscarnombre.Size = new System.Drawing.Size(775, 380);
            this.dtgBuscarnombre.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "NOMBRE:";
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Location = new System.Drawing.Point(96, 420);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(135, 20);
            this.txtBuscarNombre.TabIndex = 19;
            // 
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarNombre.Location = new System.Drawing.Point(659, 402);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(129, 39);
            this.btnBuscarNombre.TabIndex = 20;
            this.btnBuscarNombre.Text = "BUSCAR";
            this.btnBuscarNombre.UseVisualStyleBackColor = true;
            this.btnBuscarNombre.Click += new System.EventHandler(this.BtnBuscarNombre_Click);
            // 
            // frmBuscarnombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscarNombre);
            this.Controls.Add(this.txtBuscarNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgBuscarnombre);
            this.Name = "frmBuscarnombre";
            this.Text = "Buscar Nombre";
            this.Load += new System.EventHandler(this.frmBuscarnombre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscarnombre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgBuscarnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.Button btnBuscarNombre;
    }
}