using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comun
{
    public static class ClasValidarDni
    {
        public static bool ValidarDni(string cif)
        {
            try
            {
                int posPares = 0;
                int posImpares = 0;
                int sumaParesImpares;
                string ultimoCaracter;
                int pNumero;
                string[] uLetra = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "0" };
                string[] fLetra = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
                int[] fLetraNum = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
                string tmpPos;

                if (cif.Length < 9)
                    return false;

                cif = cif.ToUpper();

                ultimoCaracter = cif.Substring(8, 1);

                int cont = 1;
                for (cont = 1; cont < 7; cont++)
                {
                    tmpPos = (2 * int.Parse(cif.Substring(cont++, 1))) + "0";
                    posImpares += int.Parse(tmpPos.ToString().Substring(0, 1)) + int.Parse(tmpPos.ToString().Substring(1, 1));
                    posPares += int.Parse(cif.Substring(cont, 1));
                }

                tmpPos = (2 * int.Parse(cif.Substring(cont, 1))) + "0";
                posImpares += int.Parse(tmpPos.Substring(0, 1)) + int.Parse(tmpPos.Substring(1, 1));

                sumaParesImpares = posPares + posImpares;
                pNumero = int.Parse(sumaParesImpares.ToString().Substring(sumaParesImpares.ToString().Length - 1, 1));
                pNumero = 10 - pNumero;
                if (pNumero == 10) pNumero = 0;

                if ((ultimoCaracter == pNumero.ToString()) || (ultimoCaracter == uLetra[pNumero - 1]))
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar CIF: " + ex.Message,
                    "Error al validar CIF", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}
