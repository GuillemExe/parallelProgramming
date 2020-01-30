using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;


namespace parallelProgrammingProject
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private string _dni;
        private string _nombre;
        private string _mail;

        persona usuario = new persona();

        private persona[] _usuarios;

        public MainWindow()
        {
            // START PROJECT INTERFACE INITIALIZE
            InitializeComponent();

            // LOAD JSON
            LoadJson();

            // VALIDATE (NAME, DNI AND EMAIL)
            ValidateInfo();
        }

        public void ValidateInfo()
        {
            foreach (var user in _usuarios)
            {
                user.comprova_nom();
                user.comprova_dni();
                user.comprova_mail();
            }
        }

        public void LoadJson()
        {
            string localDirectory = System.IO.Directory.GetCurrentDirectory();

            using (StreamReader r = new StreamReader($@"{localDirectory}\\people.json"))
            {
                string json = r.ReadToEnd();
                persona[] usuario = JsonConvert.DeserializeObject<persona[]>(json);

                _usuarios = usuario;
            }
        }

        private void ButtonValidarDni_Click(object sender, RoutedEventArgs e)
        {
            var usuarioAux = usuario;

            if (usuarioAux.comprova_dni() && usuarioAux.comprova_nom() && usuarioAux.comprova_mail())
            {
                LabelValido.Visibility = Visibility.Visible;
                LabelNoValido.Visibility = Visibility.Hidden;
            }
            else
            {
                LabelValido.Visibility = Visibility.Hidden;
                LabelNoValido.Visibility = Visibility.Visible;
            }
        }

        private void TextBoxDni_TextChanged(object sender, TextChangedEventArgs e)
        {
            _dni = TextBoxDni.Text;
            usuario.dni = _dni;
        }

        private void TextBoxNombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            _nombre = TextBoxNombre.Text;
            usuario.name = _nombre;
        }

        private void TextBoxMail_TextChanged(object sender, TextChangedEventArgs e)
        {
            _mail = TextBoxMail.Text;
            usuario.email = _mail;
        }
    }
}
