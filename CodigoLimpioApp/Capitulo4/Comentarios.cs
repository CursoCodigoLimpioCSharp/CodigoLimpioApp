 using System;
using System.Drawing;

namespace CodigoLimpioApp.Capitulo4
{
    /// <summary>
    /// Vamos a ver cómo podemos comentar de manera concisa y clara.
    /// Los comentarios son importantes pero más importante es tener código descriptivo.
    /// La idea sería usar los comentarios como un apoyo para determinados casos
    /// donde por si solo el código no pueda explicarse a sí mismo.
    /// En general nuestro objetivo es que el código se explique a si mismo
    /// y en los casos donde no sea posible, usar los comentarios de manera
    /// directa, clara y sin comentar demasiado.
    /// 
    /// A la final este capítulo es subjetivo y solo pretende
    /// ser una guía y no un libro de reglas sobre lo que es
    /// correcto o no. Si se desea crear un proyecto personal,
    /// no veo problema alguno en poner todos los comentarios que se quieran.
    /// Si el proyecto es empresarial, creo que deberían existir pautas 
    /// mínimas sobre los comentarios.
    /// </summary>
    public class Comentarios { }

    /// <summary>
    /// Las constantes no deberían tener comentarios.
    /// El nombre debería ser lo suficientemente descriptivo como
    /// para no necesitar los comentarios.
    /// </summary>
    public class Constantes
    {
        // Cantidad de dias en un año
        private const int DIAS = 365;
        
        private const int CANTIDAD_DIAS_POR_AÑO = 365;

        // Cantidad de horas en un año
        private const int HORAS = 24;

        private const int CANTIDAD_HORAS_POR_DIA = 24;

        // Cabecera para el reporte anual
        private const string CABECERA = "";

        private const string CABECERA_REPORTE_ANUAL = "";

        private const string CABECERA_REPORTE_ANUAL_ = "";
    }

    /// <summary>
    /// Los campos no deberían tener comentarios.
    /// El nombre debería ser lo suficientemente descriptivo como
    /// para no necesitar los comentarios.
    /// </summary>
    public class Campos
    {
        // Este es el identificador primario
        private char iden = 'A';

        private char identificadorPrimario = 'A';
         
        // Fecha actual
        private DateTime fecha = DateTime.Now;

        private DateTime fechaHoraActual = DateTime.Now;

        // El tipo de proceso para la clase
        public object Tipo = null;

        public object TipoProcesamiento = null;
    }

    /// <summary>
    /// Las propiedades no deberían tener comentarios.
    /// El nombre debería ser lo suficientemente descriptivo como
    /// para no necesitar los comentarios.
    /// </summary>
    public class Propiedades
    {
        // Imagen de perfil
        public Bitmap Img { get; set; }

        public Bitmap ImagenPerfil { get; set; }

        // Nombre completo del cliente
        public string NomComCli { get; set; }

        public string NombreCompletoCliente { get; set; }

        // Fecha de nacimiento
        public DateTime NacFec { get; set; }

        public DateTime FechaNacimiento { get; set; }
    }

    /// <summary>
    /// Las clases deberían tener un Summary con el detalle sobre la misma.
    /// <see href="https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/xmldoc/recommended-tags"/>
    /// </summary>
    public class Clases
    {
        public Clases()
        {
            //Formateador<>
        }

        /// <summary>
        /// Contiene los ejes X, Y así como enteros para el ancho y alto.
        /// <see href="https://www.aulafacil.com/cursos/matematicas/funciones-matematicas/representacion-de-los-valores-de-x-e-y-en-el-eje-de-coordenadas-cartesianas-l11175">Enlace informativo.</see>
        /// </summary>
        public class Coordenadas { }

        /// <summary>
        /// Formateador generico.
        /// </summary>
        /// <typeparam name="T">string, int, bool</typeparam>
        public class Formateador<T> { }

        /// <summary>
        /// Analizador de string para comprobar si el formato es correcto para el sistema.
        /// </summary>
        public class AnalizadorString { }

        /// <summary>
        /// Analizador generico de valores para el formato de entrada.
        /// </summary>
        /// <typeparam name="T">string, int, bool</typeparam>
        public class Analizador<T> { }

        /// <summary>
        /// Verifica y comprueba las imagenes antes de ser tratadas para su posterior uso.
        /// </summary>
        public class ProcesadorImagen { }

        /// <summary>
        /// Procesador generico.
        /// </summary>
        /// <typeparam name="T">Bitmap, Image</typeparam>
        public class Procesador<T> { }

        /// <summary>
        /// Utilitario para fechas (tipos DateTime y string).
        /// </summary>
        public class FechaHelper { }

        /// <summary>
        /// Proveedor de contextos.
        /// </summary>
        public class ContextoFactory { }
    }

    /// <summary>
    /// Las clases abstractas deberían tener un Summary con el detalle sobre la misma.
    /// </summary>
    public class ClasesAbstractas
    {
        /// <summary>
        /// Implementacion para los desafios generales del sistema.
        /// </summary>
        public abstract class DesafioAbstract { }

        /// <summary>
        /// Base para el proceso de imagenes, incluye propiedades y metodos basicos.
        /// </summary>
        public abstract class ProcesoImagenAbstract { }
    }

    /// <summary>
    /// Las interfaces deberían tener un Summary con el detalle sobre la misma.
    /// </summary>
    public class Interfaces
    {
        /// <summary>
        /// Implementación para el buscador de las vistas principales y/o generales.
        /// </summary>
        public interface IBuscador { }

        /// <summary>
        /// Implementacion para el proceso de suma.
        /// </summary>
        public interface ISuma { }

        /// <summary>
        /// Objeto persona con lo necesario para funcionar.
        /// </summary>
        public interface IPersona { }

        /// <summary>
        /// Firma a obedecer para añadir el reporte anual.
        /// </summary>
        public interface IReporteAnual { }
    }

    /// <summary>
    /// Las variables no deberían tener comentarios.
    /// El nombre debería ser lo suficientemente descriptivo como
    /// para no necesitar los comentarios.
    /// </summary>
    public class Variables
    {
        public Variables()
        {
            // Cadena de conexion a la base de datos.
            var bd = string.Empty;
            var cadenaConexionBD = string.Empty;

            // Coordenadas para recortar la imagen.
            var rectImg = new Rectangle();
            var coordenadasParaRecorteImagen = new Rectangle();

            var fechaHoraActual = DateTime.Now;
            int diaActual = DateTime.Now.Day;
            var analizadorString = new Clases.AnalizadorString();
        }
    }

    /// <summary>
    /// Los metodos deberían tener un Summary
    /// con el detalle sobre el mismo.
    /// </summary>
    public class Metodos
    {
        /// <summary>
        /// Pruebas de los metodos.
        /// </summary>
        public Metodos()
        {
            EnviarMensaje("");
            RecibirSolicitud();
            ObtenerCoordenadasImagen(null);
            CalcularSuma(0, 0);
            UnirCadenasTexto("1", "2");
            UnirCadenasTextoAuxiliar("1", "2");
        }

        /// <summary>
        /// Enviar el mensaje dentro del directorio local a todas las maquinas conectadas.
        /// </summary>
        /// <param name="mensaje">Mensaje a enviar</param>
        public void EnviarMensaje(string mensaje) { }

        /// <summary>
        /// Recibir objeto desde el servidor central.
        /// </summary>
        /// <returns>object con valor null</returns>
        public object RecibirSolicitud() { return null; }

        /// <summary>
        /// Obtener objeto Rectangle con las coordenadas del Bitmap de los parametros.
        /// </summary>
        /// <param name="imagen">Imagen de donde saldrán las coordenadas</param>
        /// <returns>Rectangle</returns>
        public Rectangle ObtenerCoordenadasImagen(Bitmap imagen) { return new Rectangle(); }

        /// <summary>
        /// Calcular y retornar suma de los parametros.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns>Suma de los parametros</returns>
        private int CalcularSuma(int numero1, int numero2) { return 0; }

        /// <summary>
        /// Unir parametros string en un solo string con un guion en el centro.
        /// </summary>
        /// <param name="texto1">Primer texto</param>
        /// <param name="texto2">Segundo texto</param>
        /// <returns>texto1 - texto2</returns>
        private string UnirCadenasTexto(string texto1, string texto2) { return $"{texto1} - {texto2}"; }

        /// <summary>
        /// Unir parametros string en un solo string con un guion en el centro.
        /// </summary>
        private string UnirCadenasTextoAuxiliar(string texto1, string texto2) { return $"{texto1} - {texto2}"; }
    }
}