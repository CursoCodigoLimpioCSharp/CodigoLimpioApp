using System;
using System.Collections.Generic;
using System.Drawing;

namespace CodigoLimpioApp.Capitulo1
{
    public class Tipeo
    {
        /// <summary>
        /// Diferentes tipos de tipeo o escritura, estos son estilos de escritura
        /// que se aplican a frases o varias palabras juntas.
        /// </summary>
        public Tipeo()
        {
            // camelCase
            // Uso: para definir variables locales, nombrar parametros
            int acumulador = 0;
            var cadenaDeTexto = string.Empty;
            var cantidadDeHorasAlDia = 24;
            Bitmap imagenPerfilRecortada = null;

            // PascalCase
            // Uso: propiedades de una clase, nombres de clase
            var Acumulador = 0;
            var ListaNombresClientes = new List<string>();
            var PromedioHorasTrabajadasPorSemana = 40;
            var FechaHoraActual = DateTime.Now;

            // snake_case
            // Uso: en mi experiencia no he tenido la necesidad de usarlo
            // y tampoco lo he visto.
            var acumulador_de_objetos = 0;
            var cadena_conexion_bd = "";
            var caracteres_permitidos = "";
            int[] arreglo_dias_por_mes = null;

            // UPPER_CASE_SNAKE_CASE
            // Uso: campos de solo lectura de una clase, constantes
            var ACUMULADOR = 0;
            var CADENA_CONEXION_DEFAULT = "";
            var CANTIDAD_SEGUNDOS_POR_DIA = 86400;

            // Hungarian notation
            // Uso: para definir cierto tipo, puede ser usado en cualquier lado.
            // Se trata de una abreviación para identificar rapidamente el tipo.
            // En mi experiencia lo he usado en Winforms y Xamarin para definir el nombre
            // de los elementos del UI.
            // por ejemplo: BtnAceptar, BtnCancelar, (ListBox)LstProfesores, (Grid)GrdAlumnos
            string strRutaArchivo = "";
            int intCantidadConsultas = 0;
            object btnEjecutarProceso = null;
        }
    }
}