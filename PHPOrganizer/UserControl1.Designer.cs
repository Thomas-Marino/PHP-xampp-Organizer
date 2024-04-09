namespace PHPOrganizer
{
    partial class UserControl1
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Lbl_NombreArchivos = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // Lbl_NombreArchivos
            // 
            Lbl_NombreArchivos.AutoSize = true;
            Lbl_NombreArchivos.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_NombreArchivos.ForeColor = SystemColors.Control;
            Lbl_NombreArchivos.Location = new Point(19, 36);
            Lbl_NombreArchivos.Name = "Lbl_NombreArchivos";
            Lbl_NombreArchivos.Size = new Size(153, 24);
            Lbl_NombreArchivos.TabIndex = 0;
            Lbl_NombreArchivos.Text = "Nombre Archivo";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.DarkSlateBlue;
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(439, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(116, 102);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(Lbl_NombreArchivos);
            Cursor = Cursors.Hand;
            Name = "UserControl1";
            Size = new Size(555, 102);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_NombreArchivos;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
