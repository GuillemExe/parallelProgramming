using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonValidarDni_Click(object sender, RoutedEventArgs e)
        {
            var usuarioAux = usuario;

            if (usuarioAux.comprova_dni() && usuarioAux.comprova_nom() && usuarioAux.comprova_mail())
            {
                char value = usuarioAux.calcula_lletra("ejemplo");


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
            usuario.nombre = _nombre;
        }

        private void TextBoxMail_TextChanged(object sender, TextChangedEventArgs e)
        {
            _mail = TextBoxMail.Text;
            usuario.mail = _mail;
        }
    }
}
