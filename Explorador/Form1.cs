using System.Diagnostics;

namespace Explorador
{
    public partial class Form1 : Form
    {
        //Ruta donde se encuentra las imagenes
        private readonly string rutaRecursos =
        Path.Combine(Application.StartupPath, "Imagenes");

        public Form1()
        {
            InitializeComponent();
            //Cargar las distribuciones al iniciar
            CargarDistribuciones();

            //Configurae wl picture box
            picbox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //===========================================
        //Cargar distribuciones
        //===========================================
        private void CargarDistribuciones()
        {
            Combo.Items.Clear();

            Combo.Items.Add("Puppy Linux");
            Combo.Items.Add("Slax");
            Combo.Items.Add("antiX");
            Combo.Items.Add("Debian");
            Combo.Items.Add("Tiny Core Linux");

            //NO selccionar ningun item al inicio
            Combo.SelectedIndex = -1;
        }

        private void Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //revisar que el combo box tenga info
            if (Combo.SelectedIndex == -1)
            {
                return;
            }
            string distroSeleccionada =
                Combo.SelectedItem.ToString();
            switch (distroSeleccionada)
            {
                case "Puppy Linux":
                    MostrarDistro(
                        "Puppy Linux",
                        "Puppy Linux es una distribucion ligera" +
                        "diseñada para funcionar correctamente en" +
                        "equipos de pocos recursos.\r\n\r\n" +
                        "Requisitos aproximados:\r\n" +
                        "· Procesador X86 o compatible\r\n" +
                        "· 1 Giga de RAM recomendado\r\n" +
                        "· Espacio reducido en diso",
                        "puppy.png",
                        "https://puppylinux-woof-ce.github.io/"
                        );

                    break;

                case "Slax":
                    MostrarDistro(
                        "Slax",
                        "Slax es una distribución Linux pequeña y " +
                        "portable que puede ejecutarse desde una " +
                        "memoria USB.\r\n\r\n" +
                        "Requisitos aproximados:\r\n" +
                        "• Procesador compatible con x86_64\r\n" +
                        "• 512 MB de RAM o más\r\n" +
                        "• Espacio reducido en almacenamiento",
                        "slax.png",
                        "https://www.slax.org/"
                    );

                    break;


                case "antiX":

                    MostrarDistro(
                        "antiX",
                        "antiX es una distribución Linux ligera " +
                        "basada en Debian y orientada especialmente " +
                        "a equipos antiguos.\r\n\r\n" +
                        "Requisitos aproximados:\r\n" +
                        "• Procesador compatible con x86_64\r\n" +
                        "• 512 MB de RAM como mínimo recomendado\r\n" +
                        "• Poco espacio de almacenamiento",
                        "antix.png",
                        "https://antixlinux.com/"
                    );

                    break;


                case "Debian":

                    MostrarDistro(
                        "Debian",
                        "Debian es una de las distribuciones Linux " +
                        "más conocidas y utilizadas. Puede instalarse " +
                        "con diferentes entornos de escritorio y también " +
                        "puede configurarse para equipos con pocos recursos.\r\n\r\n" +
                        "Requisitos aproximados:\r\n" +
                        "• Procesador compatible\r\n" +
                        "• 512 MB de RAM para instalaciones ligeras\r\n" +
                        "• Espacio de almacenamiento variable",
                        "debian.png",
                        "https://www.debian.org/"
                    );

                    break;


                case "Tiny Core Linux":

                    MostrarDistro(
                        "Tiny Core Linux",
                        "Tiny Core Linux es una distribución " +
                        "extremadamente pequeña que está diseñada " +
                        "para utilizar muy pocos recursos del equipo.\r\n\r\n" +
                        "Requisitos aproximados:\r\n" +
                        "• Procesador compatible\r\n" +
                        "• 128 MB de RAM o más\r\n" +
                        "• Muy poco espacio de almacenamiento",
                        "tiny.jpg",
                        "http://www.tinycorelinux.net/"
                    );

                    break;
            }
        }

        private void MostrarDistro(
            string nombre,
            string descripcion,
            string Nombreimagen,
            string url
            )
        {
            //MOstrar descripccion
            lbDescripcion.Text =
                nombre + "\r\n\r\n" + descripcion;
            //Direccion de descarga
            link.Tag = url;
            //MOstramos el enlace
            link.Text = "Visitar sitio web de " + nombre;
            //=============================================
            // CArgar imagen
            //=============================================
            try
            {
                string rutaImagen =
                    Path.Combine(rutaRecursos, Nombreimagen);
                if (File.Exists(rutaImagen))
                {
                    //LIBERAR IMAGEN
                    if (picbox.Image != null)
                    {
                        picbox.Image.Dispose();
                        picbox.Image = null;
                    }
                    picbox.Image = Image.FromFile(rutaImagen);
                }
                else
                {
                    picbox.Image = null;
                    MessageBox.Show("No se encontro la imagen: " + rutaImagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen.\r\n\r" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (link.Tag != null)
                {
                    string url = link.Tag.ToString();
                    Process.Start(
                        new ProcessStartInfo
                        {
                            FileName = url,
                            UseShellExecute = true,
                        });
                }

            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show("Error al cargar la imagen.\r\n\r" +
                       ex.Message,
                       "Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
            }
        }
    }
}
