using System;
using System.Drawing;

namespace CodigoLimpioApp.Capitulo2
{
    /// <summary>
    /// La clave para nombrar es siempre la descriptibilidad.
    /// Esto quiere decir escribir o definir algo de manera que con leerlo quede claro
    /// la intención de ese elemento. El objetivo es que cualquier desarrollador pueda
    /// leer el código y tener lo mas claro posible la intención de los objetos.
    /// </summary>
    public class ComoNombrar { }

    /// <summary>
    /// Debe representar claramente el valor.
    /// </summary>
    public class Constantes
    {
        // No queda claro si son dias de un mes o de un año, etc.
        private const int DIAS = 365;
        private const int CANTIDAD_DIAS_POR_AÑO = 365;

        // No queda claro si son horas de un dia o año, etc.
        private const int HORAS = 24;
        private const int CANTIDAD_HORAS_POR_DIA = 24;

        // No queda claro si es de un reporte, de una grafica, etc.
        private const string CABECERA = "";
        private const string CABECERA_REPORTE_ANUAL = "";
    }

    /// <summary>
    /// Debe representar claramente el valor.
    /// </summary>
    public class Campos
    {
        // No queda claro.
        private char iden = 'A';
        private char identificadorPrimario = 'A';

        // No queda claro.
        private DateTime fecha = DateTime.Now;
        private DateTime fechaHoraActual = DateTime.Now;

        // No queda claro.
        public object Tipo = null;
        public object TipoProcesamiento = null;
    }

    /// <summary>
    /// Debe representar claramente el valor.
    /// </summary>
    public class Propiedades
    {
        // No queda claro a donde pertenece la imagen
        public Bitmap Img { get; set; }
        public Bitmap ImagenPerfil { get; set; }

        // No queda claro
        public string NomComCli { get; set; }
        public string NombreCompletoCliente { get; set; }

        // No queda claro
        public DateTime NacFec { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }

    /// <summary>
    /// Debe representar claramente el objeto.
    /// </summary>
    public class Clases
    {
        // No queda claro
        public class cordn { }
        public class Coordenadas { }

        // Debe quedar clara la intención de la clase, a quien o que representa.
        public class Formateador<T> { }
        public class AnalizadorString { }
        public class Analizador<T> { }
        public class ProcesadorImagen { }
        public class Procesador<T> { }
        public class FechaHelper { }
        public class ContextoFactory { }
    }

    /// <summary>
    /// Debe representar claramente el objeto.
    /// El sufijo es opcional, depende de la convención o del gusto.
    /// </summary>
    public class ClasesAbstractas
    {
        // No queda muy claro
        public abstract class DsfAbst { }
        public abstract class DesafioAbstract { }

        // No queda muy claro
        public abstract class PrcsImgAbstract { }
        public abstract class ProcesoImagenAbstract { }
    }

    /// <summary>
    /// Debe representar claramente el objeto.
    /// </summary>
    public class Interfaces
    {
        // Lleva el prefijo I seguido de su intención
        // Procesos
        public interface IAnalizador { }
        public interface IFormateador { }
        public interface IBuscador { }
        public interface ISuma { }
        public interface IResta { }
        public interface IMultiplicacion { }
        public interface IDivision { }

        // Objetos
        public interface IPersona { }
        public interface IReporteAnual { }
        public interface IMaquina { }
    }

    /// <summary>
    /// Debe representar claramente el valor.
    /// </summary>
    public class Variables
    {
        public Variables()
        {
            // No queda claro
            var bd = string.Empty;
            var cadenaConexionBD = string.Empty;

            // No queda claro
            var rectImg = new Rectangle();
            var coordenadasParaRecorteImagen = new Rectangle();

            var fechaHoraActual = DateTime.Now;
            int diaActual = DateTime.Now.Day;
            var analizadorString = new Clases.AnalizadorString();
        }
    }

    /// <summary>
    /// Debe representar claramente la intención o funcionalidad.
    /// </summary>
    public class Metodos
    {
        // La composición del nombre es: la acción + complemento
        public void EnviarMensaje(string mensaje) { }
        public object RecibirSolicitud() { return null; }
        public Rectangle ObtenerCoordenadasImagen(Bitmap imagen) { return new Rectangle(); }
        private int CalcularSuma(int numero1, int numero2) { return 0; }
        private string UnirCadenasTexto(string texto1, string texto2) { return $"{texto1} - {texto2}"; }
    }
}