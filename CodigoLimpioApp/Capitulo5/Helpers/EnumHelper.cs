using System;

namespace CodigoLimpioApp.Capitulo5.Helpers
{
    /// <summary>
    /// Utilitario para los enums.
    /// </summary>
    public static class EnumHelper
    {
        /// <summary>
        /// Convertir valor en string al tipo Enum especificado.
        /// </summary>
        public static T Convertir<T>(this string valor)
        {
            return (T)Enum.Parse(typeof(T), valor);
        }
    }
}