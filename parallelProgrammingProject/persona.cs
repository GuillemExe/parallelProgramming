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
        public string name { get; set; }
        public string email { get; set; }
        public string surname { get; set; }

        public bool comprova_dni()
        {
            // THE DNI MUST HAVE THE 9 DIGITS
            if (dni.Length != 9) return false;
            // PARSE VALUE SUBSTRING NUMERIC
            var stringNumericDni = dni.Substring(0, 8);

            // PARSE VALUE SUBSTRING LETTER
            var stringLetterDni = dni.Substring(8, 1);

            // CALCULATE LETTER THROUGH THE NUMBER VALUE
            var stringLetterDniReturn = CheckLetterDni(stringNumericDni);

            // COMPARISON OF THE CALCULATED LETTER WITH THE LETTER INTRODUCED
            return stringLetterDni.Equals(stringLetterDniReturn);
        }

        public string CheckLetterDni(string valorNumericDni)
        {
            // MAP LETTER DNI
            string[] letterMap =
            {
                "T", "R", "W", "A", "G", "M",
                "Y", "F", "P", "D", "X", "B",
                "N", "J", "Z", "S", "Q", "V",
                "H", "L", "C", "K", "E"
            };

            // PARSE VALUE NUMERIC EXAMPLE STRING "12345678" ON INTEGER
            var numericDni = int.Parse(valorNumericDni);

            // WE MAKE THE CALCULATION AND WILL GIVE US THE POSITION OF THE LETTER
            var aux = numericDni % 23;

            // AND RETURN LETTER
            return letterMap[aux];
        }

        public bool comprova_mail()
        {
            try
            {
                var mailto = new System.Net.Mail.MailAddress(email);
                return mailto.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public bool comprova_nom()
        {
            // (DEBUG TWO STRING => NEED UPDATE)
            var nameAux = name + " " + surname;

            // SPLIT STRING NAME AND SURNAMES
            var splitName = nameAux.Split(null);

            // THERE MUST BE MORE THAN ONE NAME AND MORE THAN TWO LETTERS
            return splitName.Length > 1 && splitName.All(t => t.Length >= 3);
        }
    }
}
