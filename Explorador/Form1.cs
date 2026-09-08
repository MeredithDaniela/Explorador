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
                        "https://puppylinux-woof-ce.github.io/");
                    break;
                case "Slax":
                    MostrarDistro(
                        "Slax",
                        "Slax es una distribucion pequeña y" +
                        "portale que puede ejecutarse desde una" +
                        "memoria USB\r\n\r\n" +
                        "Requisitos aproximados:\r\n" +
                        "· Procesador X86_64 o compatible\r\n" +
                        "· 512 Mega de RAM recomendado\r\n" +
                        "· Espacio reducido en diso",
                        "puppy.png",
                        "https://puppylinux-woof-ce.github.io/"
                        );
            }
        }
    }
}
