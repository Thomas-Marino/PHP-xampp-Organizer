using Entidades.Archivos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHPOrganizer
{
    public partial class FormCrearArchivo : Form
    {
        public FormCrearArchivo()
        {
            InitializeComponent();
        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            bool crearArchivo = false;
            if (!string.IsNullOrEmpty(Txb_nombreArchivo.Text))
            {
                crearArchivo = true;
                foreach (char letra in Txb_nombreArchivo.Text)
                {
                    if (letra == '\\' || letra == '/' || letra == ':' || letra == '*' || letra == '?' || letra == '"' || letra == '<' || letra == '>' || letra == '|' || letra == '.' || letra == ';' || letra == ' ')
                    {
                        crearArchivo = false;
                        MessageBox.Show("Error, vuelva a ingresar el nombre");
                    }
                }
            }
            else
            {
                MessageBox.Show("Error, vuelva a ingresar el nombre");
            }

            if (crearArchivo)
            {
                SerializadorArchivos<string> serializadorArchivos = new SerializadorArchivos<string>();
                string archivoContenedorRutaXampp = $"..\\..\\..\\..\\Paths\\PathXampp.json";
                string archivoContenedorRutaVsc = $"..\\..\\..\\..\\Paths\\PathVsc.json";
                string rutaXampp = serializadorArchivos.Deserializar(archivoContenedorRutaXampp);
                string rutaHtdocs = $"{rutaXampp}\\htdocs";

                string contenidoPHP = "<?php echo 'Hola, mundo!'; ?>";
                File.WriteAllText($"{rutaHtdocs}\\{Txb_nombreArchivo.Text}.php", contenidoPHP);
                MessageBox.Show("Archivo creado con éxito!");
                if (File.Exists(archivoContenedorRutaVsc))
                {
                    string rutaVsc = serializadorArchivos.Deserializar(archivoContenedorRutaVsc);
                    Process.Start(rutaVsc, $"{rutaHtdocs}\\{Txb_nombreArchivo.Text}.php");
                }
                this.Close();
            }
        }
    }
}
