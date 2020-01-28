using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parallelProgrammingProject
{
    class persona
    {
        public string dni { get; set; }
        public string nombre { get; set; }
        public string mail { get; set; }

        public bool comprova_dni()
        {
            string stringNumeroDni;
            string stringLetraDni;

            char[] charLetraDni;

            if (dni.Length == 9)
            {
                stringNumeroDni = dni.Substring(0, 8);
                stringLetraDni = dni.Substring(8, 1);

                charLetraDni = stringLetraDni.ToCharArray();
                char letter = charLetraDni[0];
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool comprova_mail()
        {
            return false;
        }

        public bool comprova_nom()
        {
            return false;
        }

        public char calcula_lletra(string pasador)
        {
            return 'x';
        }


    }
}
