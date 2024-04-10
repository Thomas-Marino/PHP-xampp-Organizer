using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Entidades.Archivos;

namespace PHPOrganizer
{
    public partial class FormPhpOrganizer : Form
    {
        public FormPhpOrganizer()
        {
            InitializeComponent();
        }

        private void Btn_AñadirArchivo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = "c:\\";
                ofd.Filter = "Archivos php (*.php)|*.php";
                ofd.FilterIndex = 1;
                ofd.RestoreDirectory = true;

                SerializadorArchivos<string> serializadorArchivos = new SerializadorArchivos<string>();
                string archivoContenedorRutaXampp = $"..\\..\\..\\..\\Paths\\PathXampp.json";
                string htdocsPath = $"{serializadorArchivos.Deserializar(archivoContenedorRutaXampp)}\\htdocs";

                // Muestra el diálogo
                DialogResult result = ofd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Obtiene la ruta del archivo seleccionado
                    string filePath = $"{ofd.FileName}";

                    string destinationFilePath = Path.Combine(htdocsPath, Path.GetFileName(filePath));


                    File.Copy(filePath, $"{htdocsPath}\\{Path.GetFileName(filePath)}");

                    MessageBox.Show("Archivo añadido con éxito");

                    AñadirArchivosAlForm();
                }
            }
        }

        private void Btn_CrearArchivo_Click(object sender, EventArgs e)
        {
            FormCrearArchivo f2 = new FormCrearArchivo();
            f2.ShowDialog();
            AñadirArchivosAlForm();
        }

        private void Btn_AbrirXampp_Click(object sender, EventArgs e)
        {
            if (File.Exists("..\\..\\..\\..\\Paths\\PathXampp.json"))
            {
                SerializadorArchivos<string> serializadorArchivos = new SerializadorArchivos<string>();
                string archivoContenedorRutaXampp = $"..\\..\\..\\..\\Paths\\PathXampp.json";
                string rutaXampp = serializadorArchivos.Deserializar(archivoContenedorRutaXampp);
                Process.Start($"{rutaXampp}\\xampp-control.exe");
            }
            else
            {
                MessageBox.Show("Aún no estableció la ruta de xampp", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_EstablecerRuta_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Selecciona la carpeta en donde instaló xampp.";
                fbd.RootFolder = Environment.SpecialFolder.MyComputer;
                fbd.ShowNewFolderButton = false;

                // Muestra el diálogo
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK)
                {

                    string selectedFolderPath = fbd.SelectedPath;
                    string archivoContenedorRutaXampp = $"..\\..\\..\\..\\Paths\\PathXampp.json";

                    // Expresión regular para buscar "xampp" en el path
                    string pattern = @"\\xampp$";

                    // Verifica si el path seleccionado contiene "xampp"
                    if (Regex.IsMatch(selectedFolderPath, pattern, RegexOptions.IgnoreCase))
                    {
                        MessageBox.Show("Carpeta seleccionada correctamente.", "Acción realizada con éxito", MessageBoxButtons.OK);
                        // Serializo la ruta donde se encuentra la carpeta xampp
                        SerializadorArchivos<string> serializadorArchivos = new SerializadorArchivos<string>();
                        serializadorArchivos.Serializar(selectedFolderPath, archivoContenedorRutaXampp);
                        this.Refresh();
                        ActualizarBotones();
                        AñadirArchivosAlForm();
                    }
                    else
                    {
                        MessageBox.Show("Error! Vuelva a seleccionar la carpeta donde se encuentra xampp.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void FormPhpOrganizer_Load(object sender, EventArgs e)
        {
            ActualizarBotones();
            AñadirArchivosAlForm();
        }

        private void AñadirArchivosAlForm()
        {
            if (File.Exists($"..\\..\\..\\..\\Paths\\PathXampp.json"))
            {
                flowLayoutPanel1.Controls.Clear();
                SerializadorArchivos<string> serializadorArchivos = new SerializadorArchivos<string>();
                string archivoContenedorRutaXampp = $"..\\..\\..\\..\\Paths\\PathXampp.json";
                string rutaHtdocs = $"{serializadorArchivos.Deserializar(archivoContenedorRutaXampp)}\\htdocs\\";
                List<string> archivosObtenidos = new List<string>();

                string[] archivos = Directory.GetFiles(rutaHtdocs);


                foreach (string archivo in archivos)
                {
                    if (Path.GetExtension(archivo).Equals(".php", StringComparison.OrdinalIgnoreCase))
                    {
                        // Crear un nuevo control de usuario personalizado para mostrar el nombre del archivo y un botón
                        UserControl1 fileControl = new UserControl1();
                        fileControl.FileName = Path.GetFileName(archivo);

                        // Asociar un manejador de eventos al botón
                        fileControl.Click += (sender, e) =>
                        {
                            // Obtener el nombre del archivo del control personalizado
                            string fileName = ((UserControl1)sender).FileName;

                            // Construir la URL local
                            string url = $"http://localhost/{fileName}";

                            // Abrir el navegador web predeterminado con la URL local
                            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                        };

                        // Agregar el control personalizado al FlowLayoutPanel
                        flowLayoutPanel1.Controls.Add(fileControl);
                    }
                }
            }
        }

        private void ActualizarBotones()
        {
            if (!File.Exists($"..\\..\\..\\..\\Paths\\PathXampp.json"))
            {
                Btn_AñadirArchivo.Enabled = false;
                Btn_CrearArchivo.Enabled = false;
                Btn_AbrirXampp.Enabled = false;
            }
            else
            {
                Btn_AñadirArchivo.Enabled = true;
                Btn_CrearArchivo.Enabled = true;
                Btn_AbrirXampp.Enabled = true;
            }
        }

        private void Btn_RutaVSC_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = "c:\\";
                ofd.Filter = "Archivos exe (*.exe)|*.exe";
                ofd.FilterIndex = 1;
                ofd.RestoreDirectory = true;

                string archivoContenedorRutaVsc = $"..\\..\\..\\..\\Paths\\PathVsc.json";

                // Muestra el diálogo
                DialogResult result = ofd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Obtiene la ruta del archivo seleccionado
                    string filePath = $"{ofd.FileName}";
                    string pattern = @"\\Code.exe";

                    // Verifica si el path seleccionado contiene "xampp"
                    if (Regex.IsMatch(filePath, pattern, RegexOptions.IgnoreCase))
                    {
                        SerializadorArchivos<string> serializadorArchivos = new SerializadorArchivos<string>();
                        serializadorArchivos.Serializar(filePath, archivoContenedorRutaVsc);
                        MessageBox.Show("VSC Seleccionado con éxito!");
                    }
                    else
                    {
                        MessageBox.Show("Error, se selecciono un archivo incorrecto. Vuelva a intentarlo.");

                    }

                }
            }
        }
    }
}