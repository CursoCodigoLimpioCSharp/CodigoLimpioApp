using System.Collections.Generic;

namespace CodigoLimpioApp.Capitulo3
{
    /// <summary>
    /// Se refiere al tamaño vertical y horizontal.
    /// Esto depende completamente de donde se este escribiendo el código.
    /// Sea una clase, un constructor o un método, la finalidad es siempre la misma,
    /// escribir código que no sea extenso, que sea facil de usar, entender y modificar.
    /// </summary>
    public class Tamaño { }
     
    /// <summary>
    /// En mi experiencia he visto clases que van desde las 50 líneas de código hasta más de 14000.
    /// El tamaño de las clases va definido por la cantidad de elementos que esta contenga mientras
    /// todos esos elementos sean responsabilidad de dicha clase.
    /// 
    /// En mi opinión el tamaño de las clases depende de sus responsabilidades, esto puede variar mucho
    /// dependiendo con lo que se esta trabajando.
    /// 
    /// La clase con 14000 líneas de código con la que llegue a trabajar tenia responsabilidades de mas de
    /// 10 objetos, lo más probable es que con un refactoring dicha clase quedaría con quizás 2000 líneas
    /// que serían enteramente de su responsabilidad. Lo que trato de plantear aquí es un tema de organización,
    /// donde deberían estar localizado el código de manera que sea fácil de encontrar y que se encuentre
    /// donde pertenece.
    /// </summary>
    public class Clases
    {
        /// <summary>
        /// Clase Auditor con responsabilidades que no son de dicha clase.
        /// En total son 1050 líneas de código en métodos,
        /// de los cuales 700 líneas no son responsabilidad de esta clase.
        /// </summary>
        public class Auditor
        {
            public void Auditar() { /*300*/ }

            public void GuardarAuditoria() { /*50*/ }

            // Calculadora
            public void CalcularNominas() { /*200*/ }

            // RRHH
            public void PagarSueldos() { /*100*/ }

            // Calculadora
            public void CalcularImpuestos() { /*250*/ }

            // Impresora
            public void ImprimirDocumentos() { /*50*/ }

            // RRHH
            public void EnviarCorreosConNominas() { /*100*/ }
        }

        public class MuchoAnchoHorizontal
        {
            public MuchoAnchoHorizontal(int numero1, int numero2, object objeto, string mensaje, Dictionary<int, Dictionary<int, string>> diccionarioDentroDeDiccionario, List<object> listaDeObjetos)
            {
                //TODO
            }
        }

        public class MuchoAnchoHorizontalArreglado
        {
            public MuchoAnchoHorizontalArreglado(int numero1, int numero2, object objeto, string mensaje,
                Dictionary<int, Dictionary<int, string>> diccionarioDentroDeDiccionario, List<object> listaDeObjetos)
            {
                //TODO
            }

            public MuchoAnchoHorizontalArreglado(
                int numero1,
                int numero2,
                object objeto,
                string mensaje,
                Dictionary<int, Dictionary<int, string>> diccionarioDentroDeDiccionario,
                List<object> listaDeObjetos,
                bool flag)
            {
                //TODO
            }
        }
    }

    /// <summary>
    /// Los constructores y métodos deberían tener un maxímo de código como lo permita la pantalla donde se este trabajando.
    /// El objetivo de esto es no tener que hacer scroll de arriba/abajo ni de izquierda/derecha.
    /// El objetivo es ver el código en la pantalla para poder enfocarnos en el.
    /// </summary>
    public class ConstructoresYMetodos
    {
        public List<string> ListaMensajes { get; private set; }

        /// <summary>
        /// Obtener las cadenas de texto del parametro diccionarioConDiccionarioMensajes.
        /// </summary>
        public ConstructoresYMetodos(Dictionary<int, Dictionary<int, string>> diccionarioConDiccionarioMensajes)
        {
            if (diccionarioConDiccionarioMensajes == null)
                return;

            ListaMensajes = new List<string>();

            foreach (var diccionarioMensaje in diccionarioConDiccionarioMensajes.Values)
            {
                foreach (var mensaje in diccionarioMensaje.Values)
                {
                    if (string.IsNullOrEmpty(mensaje))
                        continue;

                    switch (mensaje)
                    {
                        case "0":
                            continue;
                        case "1":
                            ListaMensajes.Add(mensaje);
                            break;
                        case "2":
                            ListaMensajes.Add(mensaje);
                            break;
                        case "3":
                            ListaMensajes.Add(mensaje);
                            break;
                        case "4":
                            ListaMensajes.Add(mensaje);
                            break;
                        case "5":
                            ListaMensajes.Add(mensaje);
                            break;
                        case "6":
                            ListaMensajes.Add(mensaje);
                            break;
                        case "7":
                            ListaMensajes.Add(mensaje);
                            break;
                        case "8":
                            ListaMensajes.Add(mensaje);
                            break;
                        case "9":
                            ListaMensajes.Add(mensaje);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Obtener las cadenas de texto del parametro diccionarioConDiccionarioMensajes.
        /// </summary>
        public void Metodo(Dictionary<int, Dictionary<int, string>> diccionarioConDiccionarioMensajes)
        {
            if (diccionarioConDiccionarioMensajes == null)
                return;

            ListaMensajes = new List<string>();

            foreach (var diccionarioMensaje in diccionarioConDiccionarioMensajes.Values)
            {
                foreach (var mensaje in diccionarioMensaje.Values)
                {
                    if (string.IsNullOrEmpty(mensaje))
                        continue;

                    AñadirMensaje(mensaje);
                }
            }
        }

        /// <summary>
        /// Añadir mensaje a la propiedad ListaMensajes
        /// </summary>
        private void AñadirMensaje(string mensaje)
        {
            switch (mensaje)
            {
                case "0":
                    break;
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    ListaMensajes.Add(mensaje);
                    break;
                default:
                    break;
            }
        }
    }
}