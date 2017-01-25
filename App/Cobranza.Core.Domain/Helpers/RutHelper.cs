using System.Globalization;

namespace Cobranza.Core.Domain.Helpers
{
    public static class RutHelper
    {
        public static string CalculateDigitoVerificador(int mantisaRut)
        {
            int contador = 2;

            int acumulador = 0;

            string digitoRut;

            int mantisaRutOperando = mantisaRut;

            while (mantisaRutOperando != 0)
            {
                int multiplo = (mantisaRutOperando % 10) * contador;

                acumulador += multiplo;

                mantisaRutOperando = mantisaRutOperando / 10;

                contador++;

                if (contador == 8)
                {
                    contador = 2;
                }
            }

            int digito = 11 - (acumulador % 11);

            digitoRut = (digito == 10) ?
                            "K" :
                            digito.ToString(CultureInfo.InvariantCulture);

            if (digito == 11)
            {
                digitoRut = "0";
            }

            return digitoRut;
        }
    }
}
