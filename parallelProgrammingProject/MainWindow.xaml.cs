using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


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
            // En este proyecto probaremos tres formas de ejecutar código.
            // La primera sin usar el “paralel invoke”, la segunda una forma
            // un tanto inadecuada del uso de este, y el tercero, la forma
            // más optima que he podido encontrar.

            // Cuando realicemos las pruebas podremos observar que el proceso / código 3
            // es mucho más rápido que el proceso / código 2.Eso se debe a que el sistema
            // está haciendo los tres tipos de comprobaciones al mismo tiempo inclusive de
            // diferentes usuarios, mejorando el tiempo de ejecución. Mientras que el
            // proceso/código 2 realiza el “paralel invoke” va usuario por usuario realizando
            // los tres procesos simultáneamente, al realizar este workflow no podrá pasar
            // al siguiente usuario, hasta que haya terminado con el ultimo proceso.


            // CODE ---> 1

            #region ---> CODE 1
            var timingCode1 = System.Diagnostics.Stopwatch.StartNew();
            foreach (var user in _usuarios)
            {
                user.comprova_nom();
                user.comprova_dni();
                user.comprova_mail();
            }
            timingCode1.Stop();
            #endregion

            // CODE ---> 2

            #region ---> CODE 2
            var timingCode2 = System.Diagnostics.Stopwatch.StartNew();
            foreach (var user in _usuarios)
            {
                Parallel.Invoke(() =>
                    {
                        user.comprova_nom();
                    },

                    () =>
                    {
                        user.comprova_dni();
                    },

                    () =>
                    {
                        user.comprova_mail();
                    } 
                );
            }
            timingCode2.Stop();
            #endregion

            // CODE ---> 3

            #region ---> CODE 3
            var timingCode3 = System.Diagnostics.Stopwatch.StartNew();
            Parallel.Invoke(() =>
                {
                    foreach (var user in _usuarios)
                    {
                        user.comprova_nom();
                    }
                },
                () =>
                {
                    foreach (var user in _usuarios)
                    {
                        user.comprova_dni();
                    }
                },

                () =>
                {
                    foreach (var user in _usuarios)
                    {
                        user.comprova_mail();
                    }
                }
            );
            timingCode3.Stop();
            #endregion

            // Insert
            TimingCode1.Content = timingCode1.ElapsedMilliseconds;
            TimingCode2.Content = timingCode2.ElapsedMilliseconds;
            TimingCode3.Content = timingCode3.ElapsedMilliseconds;
        }

        public void LoadJson()
        {
            var localDirectory = System.IO.Directory.GetCurrentDirectory();

            using (var r = new StreamReader($@"{localDirectory}\\people.json"))
            {
                var json = r.ReadToEnd();
                var Users = JsonConvert.DeserializeObject<persona[]>(json);

                _usuarios = Users;
            }
        }

        private void ButtonValidarDni_Click(object sender, RoutedEventArgs e)
        {
            var UsersAux = usuario;

            if (UsersAux.comprova_dni() && UsersAux.comprova_nom() && UsersAux.comprova_mail())
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
