using System;
using System.Collections.Generic;
using CodigoLimpioApp.Capitulo5.Dtos;
using CodigoLimpioApp.Capitulo5.Enums;

namespace CodigoLimpioApp.Capitulo5.Contexto
{
    /// <summary>
    /// Contexto para la base de datos del proyecto.
    /// </summary>
    public class BD : IDisposable
    {
        /// <summary>
        /// Obtener tabla de conversión de las distintas divisas almacenadas
        /// </summary>
        public List<Conversion> ObtenerConversiones()
        {
            return new List<Conversion>
            {
                new Conversion(Divisa.EUR, Divisa.USD, 1.13f),
                new Conversion(Divisa.USD, Divisa.NZD, 1.46f),
                new Conversion(Divisa.USD, Divisa.MXN, 20.59f)
            };
        }

        public void Dispose() { }
    }
}