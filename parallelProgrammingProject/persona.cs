using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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
            if (dni.Length == 9)
            {
                var stringNumericDni = dni.Substring(0, 8);
                var stringLetterDni = dni.Substring(8, 1);

                var stringLetterDniReturn = CheckLetterDni(stringNumericDni);

                return stringLetterDni.Equals(stringLetterDniReturn);
            }
            else
            {
                return false;
            }
        }

        public string CheckLetterDni(string valorNumericDni)
        {
            string[] letterMap =
            {
                "T", "R", "W", "A", "G", "M",
                "Y", "F", "P", "D", "X", "B",
                "N", "J", "Z", "S", "Q", "V",
                "H", "L", "C", "K", "E"
            };

            var numericDni = int.Parse(valorNumericDni);

            var aux = numericDni % 23;

            return letterMap[aux];
        }

        public bool comprova_mail()
        {
            return true;
        }

        public bool comprova_nom()
        {
            return true;
        }

        public char calcula_lletra(string pasador)
        {
            return 'x';
        }
    }
}
