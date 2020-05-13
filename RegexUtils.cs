using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MiBanco
{
    class RegexUtils
    {
        //Método público que nos comprueba si el formato del teléfono está bien establecido
        // Y el de cuenta también, dado que son 9 dígitos (sino debería ser long en vez de int)
        public static Boolean validarTlfCuenta(String telefono)
        {
            String regexTlf = "^[0-9]{9}$";
            Regex expresionRegular = new Regex(regexTlf);
            return expresionRegular.IsMatch(telefono);
        }

        //Método público que nos comprueba que el formato del DNI es correcto
        public static Boolean validarDni(String dni)
        {
            String regexDni = "^[0-9]{8}[a-zA-Z]$";
            Regex expresionReg = new Regex(regexDni);
            return expresionReg.IsMatch(dni);
        }

        //Método que nos comprueba si la edad y su formato es correcta
        public static Boolean validarEdad(String edad)
        {
            Boolean isValid = true;

            foreach (char c in edad)
            {
                if (!Char.IsDigit(c))
                {
                    isValid = false;
                }
            }

            if (isValid)
            {
                int edadAux = Convert.ToInt32(edad);

                if (edadAux > 18 && edadAux < 120)
                {
                    return true;

                }else { return false; }

            }else{return false;}
        }
    }
}
