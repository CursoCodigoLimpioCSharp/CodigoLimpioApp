using System.Drawing;

namespace CodigoLimpioApp.Capitulo1
{
    /// <summary>
    /// Son y sirven como guia para el desarrollador, para escribir código con cierto estilo ya predefinido
    /// sea por la empresa, por los lideres de equipos de desarrollo o por los desarrolladores.
    /// Es un documento muy util a la hora de ingresar a un nuevo trabajo ya que nos ayuda a saber
    /// los lineamientos que se siguen para escribir código y también promueve la homogeneidad, con esto
    /// quiero decir que el código tendría el mismo estilo y esto nos ayuda a entenderlo de mejor manera.
    /// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions
    /// </summary>
    public class ConvencionesDeCodigo
    {
        public class Declaracion
        {
            /// <summary>
            /// Declaracion de variables
            /// </summary>
            public Declaracion()
            {
                // Descriptivo
                // Mal
                var ce = "email@example.com";
                var imagen = new Bitmap(0, 0);
                // Bien
                var correoElectronico = "email@example.com";
                var imagenPerfilCliente = new Bitmap(0, 0);

                // Declarar explicitamente
                // Mal
                var nuevoObjeto = ObtenerNuevoObjeto();
                // Bien
                object otroNuevoObjeto = ObtenerNuevoObjeto();

                // Declarar implicitamente
                // Mal
                Bitmap imagenFrontal = new Bitmap(0, 0);
                // Bien
                var imagenFrontalNueva = new Bitmap(0, 0);
            }
        }

        public class Nombre
        {
            /// <summary>
            /// Interfaces
            /// Comenzar con prefijo 'I' y continuar con PascalCase
            /// Ejemplos:
            /// ICargarData, ISubirFichero, IEnviarRecibo
            /// </summary>
            public interface IRecibirNombre { }

            /// <summary>
            /// Campos privados, propiedades privadas, variables, parametros de un método
            /// Siempre con camelCase
            /// </summary>
            public class VariablesParametrosCampos
            {
                /// <summary>
                /// Campo privado
                /// </summary>
                private object campoPrivado;

                /// <summary>
                /// Propiedad privada
                /// </summary>
                private object propiedadPrivada { get; set; }

                /// <summary>
                /// Parametro
                /// </summary>
                public VariablesParametrosCampos(object parametro)
                {
                    // Variable
                    object variable = null;
                }
            }

            /// <summary>
            /// Clases, campos publicos, propiedades publicas, constructores, métodos
            /// Siempre con PascalCase
            /// </summary>
            public class ClasesPropiedadesMetodos
            {
                /// <summary>
                /// Campo publico
                /// </summary>
                public object CampoPublico;

                /// <summary>
                /// Propiedad publica
                /// </summary>
                public object PropiedadPublica { get; set; }

                /// <summary>
                /// Constructor
                /// </summary>
                public ClasesPropiedadesMetodos() { }

                /// <summary>
                /// Método publico
                /// </summary>
                public void MetodoPublico() { }

                /// <summary>
                /// Método privado
                /// </summary>
                public void MetodoPrivado() { }
            }

            /// <summary>
            /// Lo anterior aplica también los estáticos
            /// </summary>
            public static class ClasesPropiedadesMetodosEstaticas
            {
                /// <summary>
                /// Campo publico estático
                /// </summary>
                public static object CampoPublicoEstatico;

                /// <summary>
                /// Propiedad publica estática
                /// </summary>
                public static object PropiedadPublicaEstatica { get; set; }

                /// <summary>
                /// Constructor estático
                /// </summary>
                static ClasesPropiedadesMetodosEstaticas() { }

                /// <summary>
                /// Método publico estático
                /// </summary>
                public static void MetodoPublicoEstatico() { }

                /// <summary>
                /// Método privado estático
                /// </summary>
                public static void MetodoPrivadoEstatico() { }
            }
        }

        /// <summary>
        /// Define el orden de los elementos dentro de una clase
        /// 1.- Campos constantes y/o de solo lectura
        /// 2.- Campos privados y publicos
        /// 3.- Propiedades privadas y publicas.
        /// 4.- Constructores
        /// 5.- Métodos publicos
        /// 6.- Métodos privados
        /// </summary>
        public class Orden
        {
            private const int CAMPO_CONSTANTE = 1;
            private static readonly int CAMPO_SOLO_LECTURA_ESTATICO = 1;
            private readonly int CAMPO_SOLO_LECTURA = 1;

            private static int campoPrivadoEstatico = 2;
            private int campoPrivado = 2;

            public static int CampoPublicoEstatico = 2;
            public int CampoPublico = 2;

            private static int propiedadPrivadaEstatica { get; set; } = 3;
            private int propiedadPrivada { get; set; } = 3;

            public static int PropiedadPublicaEstatica { get; set; } = 3;
            public int PropiedadPublica { get; set; } = 3;

            static Orden() { /*4*/ }
            public Orden() { /*4*/ }

            public static void MetodoPublicoEstatico() { /*5*/}

            public void MetodoPublico() { /*5*/}

            private static void MetodoPrivadoEstatico() { /*6*/ }

            private void MetodoPrivado() { /*6*/ }
        }

        public static object ObtenerNuevoObjeto()
        {
            return null;
        }
    }
}