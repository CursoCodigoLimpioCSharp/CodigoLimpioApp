using CodigoLimpioApp.Capitulo5;
using CodigoLimpioApp.Capitulo5.Enums;

namespace CodigoLimpioApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo 1 arreglado
            var convertidorDivisas = new ConvertidorDivisas();
            // valor = 1.13
            var valor1 = convertidorDivisas.Convertir(1f, Divisa.EUR, Divisa.USD);
            // valor = 23.26
            var valor2 = convertidorDivisas.Convertir(1f, Divisa.EUR, Divisa.MXN);
            // valor = 1.65
            var valor3 = convertidorDivisas.Convertir(1, Divisa.EUR, Divisa.NZD);

            // Ejemplo 2 arreglado
            var convertidorDivisasArreglado = new ConvertidorDivisasArreglado();
            // valor = 1.13
            var valor11 = convertidorDivisasArreglado.Convertir(1f, Divisa.EUR, Divisa.USD);
            // valor = 23.26
            var valor22 = convertidorDivisasArreglado.Convertir(1f, Divisa.EUR, Divisa.MXN);
            // valor = 1.65
            var valor33 = convertidorDivisasArreglado.Convertir(1, Divisa.EUR, Divisa.NZD);
        }
    }
}