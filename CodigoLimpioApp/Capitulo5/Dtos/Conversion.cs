using CodigoLimpioApp.Capitulo5.Enums;

namespace CodigoLimpioApp.Capitulo5.Dtos
{
    /// <summary>
    /// Clase DTO para almacenar el par divisa para la conversion
    /// </summary>
    public class Conversion
    {
        public Divisa DivisaPrincipal { get; }
        public Divisa DivisaConversion { get; }
        public float ValorConversion { get; }

        public Conversion(Divisa divisaPrincipal, Divisa divisaConversion, float valorConversion)
        {
            DivisaPrincipal = divisaPrincipal;
            DivisaConversion = divisaConversion;
            ValorConversion = valorConversion;
        }
    }
}