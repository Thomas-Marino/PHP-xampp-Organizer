namespace PHPOrganizer
{
    partial class FormPhpOrganizer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhpOrganizer));
            Btn_AñadirArchivo = new Button();
            Btn_CrearArchivo = new Button();
            Btn_AbrirXampp = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Btn_EstablecerRuta = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Btn_RutaVSC = new Button();
            SuspendLayout();
            // 
            // Btn_AñadirArchivo
            // 
            Btn_AñadirArchivo.Cursor = Cursors.Hand;
            Btn_AñadirArchivo.Location = new Point(591, 12);
            Btn_AñadirArchivo.Name = "Btn_AñadirArchivo";
            Btn_AñadirArchivo.Size = new Size(197, 52);
            Btn_AñadirArchivo.TabIndex = 0;
            Btn_AñadirArchivo.Text = "Añadir archivo .php existente a htdocs.";
            Btn_AñadirArchivo.UseVisualStyleBackColor = true;
            Btn_AñadirArchivo.Click += Btn_AñadirArchivo_Click;
            // 
            // Btn_CrearArchivo
            // 
            Btn_CrearArchivo.Cursor = Cursors.Hand;
            Btn_CrearArchivo.Location = new Point(591, 70);
            Btn_CrearArchivo.Name = "Btn_CrearArchivo";
            Btn_CrearArchivo.Size = new Size(197, 52);
            Btn_CrearArchivo.TabIndex = 1;
            Btn_CrearArchivo.Text = "Crear archivo .php en htdocs.";
            Btn_CrearArchivo.UseVisualStyleBackColor = true;
            Btn_CrearArchivo.Click += Btn_CrearArchivo_Click;
            // 
            // Btn_AbrirXampp
            // 
            Btn_AbrirXampp.Cursor = Cursors.Hand;
            Btn_AbrirXampp.Location = new Point(591, 128);
            Btn_AbrirXampp.Name = "Btn_AbrirXampp";
            Btn_AbrirXampp.Size = new Size(197, 52);
            Btn_AbrirXampp.TabIndex = 2;
            Btn_AbrirXampp.Text = "Abrir xammp.";
            Btn_AbrirXampp.UseVisualStyleBackColor = true;
            Btn_AbrirXampp.Click += Btn_AbrirXampp_Click;
            // 
            // label1
            // 
            label1.Location = new Point(591, 183);
            label1.Name = "label1";
            label1.Size = new Size(197, 32);
            label1.TabIndex = 3;
            label1.Text = "Al abrir xampp se deben inicializar los siguientes 3 procesos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(591, 228);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 4;
            label2.Text = "* APACHE.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(591, 243);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "* MYSQL.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(591, 258);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 6;
            label4.Text = "* FILEZILLA.";
            // 
            // Btn_EstablecerRuta
            // 
            Btn_EstablecerRuta.Cursor = Cursors.Hand;
            Btn_EstablecerRuta.Location = new Point(591, 386);
            Btn_EstablecerRuta.Name = "Btn_EstablecerRuta";
            Btn_EstablecerRuta.Size = new Size(197, 52);
            Btn_EstablecerRuta.TabIndex = 7;
            Btn_EstablecerRuta.Text = "Establecer ruta de xampp";
            Btn_EstablecerRuta.UseVisualStyleBackColor = true;
            Btn_EstablecerRuta.Click += Btn_EstablecerRuta_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.ButtonHighlight;
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(562, 426);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // Btn_RutaVSC
            // 
            Btn_RutaVSC.Location = new Point(591, 328);
            Btn_RutaVSC.Name = "Btn_RutaVSC";
            Btn_RutaVSC.Size = new Size(197, 52);
            Btn_RutaVSC.TabIndex = 9;
            Btn_RutaVSC.Text = "Establecer ruta de visual studio code.";
            Btn_RutaVSC.UseVisualStyleBackColor = true;
            Btn_RutaVSC.Click += Btn_RutaVSC_Click;
            // 
            // FormPhpOrganizer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Btn_RutaVSC);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(Btn_EstablecerRuta);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Btn_AbrirXampp);
            Controls.Add(Btn_CrearArchivo);
            Controls.Add(Btn_AñadirArchivo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormPhpOrganizer";
            Text = "PHP Organizer";
            Load += FormPhpOrganizer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_AñadirArchivo;
        private Button Btn_CrearArchivo;
        private Button Btn_AbrirXampp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Btn_EstablecerRuta;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button Btn_RutaVSC;
    }
}