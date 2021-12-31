using System.Collections.Generic;
using System.Linq;
using CodigoLimpioApp.Capitulo5.Contexto;
using CodigoLimpioApp.Capitulo5.Dtos;
using CodigoLimpioApp.Capitulo5.Enums;

namespace CodigoLimpioApp.Capitulo5
{
    /// <summary>
    /// CAPITULO1 - Los parámetros están usando PascalCase
    /// CAPITULO1 - Algunas variables están usando PascalCase
    /// CAPITULO1 - Algunas líneas tienen mal definido la sangría
    /// CAPITULO1 - Algunas líneas tienen mal definido el espaciado
    /// CAPITULO1 - Hay partes del código densas
    /// 
    /// CAPITULO2 - Nombre de los parámetros no son muy descriptivos
    /// CAPITULO2 - Exceso de comentarios en todo el método
    /// 
    /// CAPITULO3 - Exceso del tamaña tanto vertical como horizontal
    /// 
    /// CAPITULO4 - No hay summary en el método
    /// CAPITULO4 - Exceso de comentarios en el método
    /// </summary>
    public class ConvertidorDivisas
    {
        public float Convertir(float Monto, Divisa Divisa, Divisa Convertir)
        {
            // Inicializar tabla de conversiones
            List<Conversion> Conv = new List<Conversion>();

            // Obtener tabla de conversión de la bd
            using (var BD = new BD())
            {
                Conv = BD.ObtenerConversiones();
            }

            // Verificar si monto es mayor a cero
            if (Monto > 0)
            {
                // Verificar si existir conversión directa
                if (Conv.Where(w => w.DivisaPrincipal == Divisa && w.DivisaConversion == Convertir && w.ValorConversion > 0).FirstOrDefault() != null)
                {

                    return Monto * Conv.Where(w => w.DivisaPrincipal == Divisa &&
                                                w.DivisaConversion == Convertir && w.ValorConversion > 0)
                                        .FirstOrDefault().ValorConversion;
                }
                else // Verificar si existe una conversión a través de otras divisas
                {

                    // Obtener las divisas
                    var convDivisa = Conv.Where(w => w.DivisaConversion == Convertir);


                    if (convDivisa.Count() > 0)
                    {
                        // Divisa a convertir
                        var convConvertir = Conv.FirstOrDefault(f => f.DivisaPrincipal == Divisa);

                        if (convConvertir != null)
                        {

                            // Vamos a ver si la divisa a convertir es igual a la divisa principal de la divisa que queremos convertir
                            for (int I = 0; I < convDivisa.Count(); I++)
                            {
                                // Si la divisa principal es igual a la divisa de conversión
                                // Se puede hacer un puente entre divisas
                                if (convDivisa.ElementAt(I).DivisaPrincipal == convConvertir.DivisaConversion)
                                {
                                    return convConvertir.ValorConversion * convDivisa.ElementAt(I).ValorConversion * Monto;
                                }
                            }
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        return 0;
                    }
                }

                return 0;
            }
            else // Si no es mayor a cero entonces retornar cero
            {
                return 0;
            }
        }
    }

    public class ConvertidorDivisasArreglado
    {
        /// <summary>
        /// Transformar el monto de la divisa actual a la divisa deseada
        /// </summary>
        public float Convertir(float monto, Divisa divisaPrincipal, Divisa divisaConversion)
        {
            if (monto == 0)
                return 0;

            List<Conversion> conversiones = ObtenerConversiones();

            Conversion conversionDirecta = conversiones.FirstOrDefault(f =>
                f.DivisaPrincipal == divisaPrincipal && f.DivisaConversion == divisaConversion && f.ValorConversion > 0);

            bool existeConversionDirecta = conversionDirecta != null;
            if (existeConversionDirecta)
                return monto * conversionDirecta.ValorConversion;

            var conversionDivisasEspecificas = conversiones.Where(w => w.DivisaConversion == divisaConversion).ToList();
            if (conversionDivisasEspecificas.Count == 0)
                return 0;

            var conversionDivisaPrincipal = conversiones.FirstOrDefault(f => f.DivisaPrincipal == divisaPrincipal);
            if (conversionDivisaPrincipal == null)
                return 0;

            foreach (var conversionDivisaEspecifica in conversionDivisasEspecificas)
            {
                if (conversionDivisaEspecifica.DivisaPrincipal != conversionDivisaPrincipal.DivisaConversion)
                    continue;

                return monto * conversionDivisaPrincipal.ValorConversion * conversionDivisaEspecifica.ValorConversion;
            }

            return 0;
        }

        /// <summary>
        /// Obtener la lista de conversiones desde la base de datos
        /// </summary>
        private List<Conversion> ObtenerConversiones()
        {
            var conversiones = new List<Conversion>();

            using (var bd = new BD())
                conversiones = bd.ObtenerConversiones();

            return conversiones;
        }
    }
}