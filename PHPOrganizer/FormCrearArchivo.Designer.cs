namespace PHPOrganizer
{
    partial class FormCrearArchivo
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
            Btn_Crear = new Button();
            Txb_nombreArchivo = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Btn_Crear
            // 
            Btn_Crear.Location = new Point(435, 41);
            Btn_Crear.Name = "Btn_Crear";
            Btn_Crear.Size = new Size(127, 29);
            Btn_Crear.TabIndex = 0;
            Btn_Crear.Text = "Crear archivo.";
            Btn_Crear.UseVisualStyleBackColor = true;
            Btn_Crear.Click += Btn_Crear_Click;
            // 
            // Txb_nombreArchivo
            // 
            Txb_nombreArchivo.Location = new Point(133, 12);
            Txb_nombreArchivo.Name = "Txb_nombreArchivo";
            Txb_nombreArchivo.Size = new Size(429, 23);
            Txb_nombreArchivo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre del archivo:";
            // 
            // FormCrearArchivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 78);
            Controls.Add(label1);
            Controls.Add(Txb_nombreArchivo);
            Controls.Add(Btn_Crear);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCrearArchivo";
            Text = "Creacion del archivo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Crear;
        private TextBox Txb_nombreArchivo;
        private Label label1;
    }
}