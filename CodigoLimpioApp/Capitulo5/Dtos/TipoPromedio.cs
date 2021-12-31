using CodigoLimpioApp.Capitulo5.Enums;

namespace CodigoLimpioApp.Capitulo5.Dto
{
    /// <summary>
    /// Clase DTO para almacenar resultados por tipo/promedio.
    /// </summary>
    public class TipoPromedio
    {
        public Tipo Tipo { get; }
        public double Promedio { get; }

        public TipoPromedio(Tipo tipo, double promedio)
        {
            Tipo = tipo;
            Promedio = promedio;
        }
    }
}