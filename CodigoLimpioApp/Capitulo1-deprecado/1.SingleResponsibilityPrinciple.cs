using System;

namespace CodigoLimpioApp
{
    public class SRP
    {
        public SRP()
        {
            var stringParser = new StringParser();

            var objeto = (object)"texto";

            var cadenaDeTextoParseada = stringParser.Parse(objeto);

            int cantidadDeCaracteresEnCadenaDeTexto = StringHelper.ObtenerCantidadDeCaracteres(cadenaDeTextoParseada);
        }
    }

    public class StringParser
    {
        public string Parse(object objeto)
        {
            var stringParseado = Convert.ToString(objeto);

            return stringParseado;
        }
    }

    public static class StringHelper
    {
        public static int ObtenerCantidadDeCaracteres(string cadenaDeTexto)
        {
            return cadenaDeTexto.Length;
        }
    }
}