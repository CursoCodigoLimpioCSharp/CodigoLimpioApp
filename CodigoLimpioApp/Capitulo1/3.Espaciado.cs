using System.Collections.Generic;
using System.Linq;

namespace CodigoLimpioApp.Capitulo1
{
    /// <summary>
    /// Cantidad de espacios verticalmente que son minimamente necesarios.
    /// </summary>
    public class Espaciado
    {

        private int propertyPrueba1;
        public int PropertyPrueba1
        {

            get

            {

                return propertyPrueba1;

            }

            set

            {

                propertyPrueba1 = value;

            
            }

        }

        public int PropertyPrueba2 { get; set; }

        public int PropertyPrueba3 { get; set; }

        public int PropertyPrueba4 { get; set; }

        public int PropertyPrueba5 { get; set; }
        public int PropertyPrueba6 { get; set; }
        public int PropertyPrueba7 { get; set; }
        public int PropertyPrueba8 { get; set; }

        public int PropertyPrueba9 { get; set; }
        public int PropertyPrueba10 { get; set; }

        public Espaciado()
        {
            var listaTextos = new List<string>();

            string cadenaDeTexto = (from texto

                                    in listaTextos

                                    where texto.Contains("")

                                    select texto)

                                    .FirstOrDefault();

            string cadenaDeTextoNueva = 

                (from texto
                 in listaTextos
                 where texto.Contains("")
                 select texto)

                 .FirstOrDefault();

            if (true)
            {
                //TODO

            }

            if (true)
            {

                //TODO
            }

            if (true)
            {

                //TODO

            }

            if (true)

            {
                //TODO
            }

        }

    }



    public class EspaciadoArreglado
    {
        private int propertyPrueba1;
        public int PropertyPrueba1
        {
            get
            {
                return propertyPrueba1;
            }
            set
            {
                propertyPrueba1 = value;
            }
        }

        public int PropertyPrueba2 { get; set; }
        public int PropertyPrueba3 { get; set; }
        public int PropertyPrueba4 { get; set; }
        public int PropertyPrueba5 { get; set; }
        public int PropertyPrueba6 { get; set; }
        public int PropertyPrueba7 { get; set; }
        public int PropertyPrueba8 { get; set; }
        public int PropertyPrueba9 { get; set; }
        public int PropertyPrueba10 { get; set; }

        public EspaciadoArreglado()
        {
            var listaTextos = new List<string>();

            string cadenaDeTexto = (from texto in listaTextos  where texto.Contains("") select texto)
                .FirstOrDefault();

            string cadenaDeTextoNueva = (from texto in listaTextos where texto.Contains("") select texto)
                .FirstOrDefault();

            if (true)
            {
                //TODO
            }

            // DEPENDE DEL GUSTO
            int indiceMatriz = 0, maxIndice = 100;
            for (int i = indiceMatriz; i < maxIndice; i++)
            {
                //TODO
            }

            // DEPENDE DEL GUSTO
            List<string> lista = listaTextos;
            foreach (var elemento in lista)
            {
                //TODO
            }

            // DEPENDE DEL GUSTO
            int indiceMatrizNuevo = 0, maxIndiceNuevo = 100;

            for (int i = indiceMatrizNuevo; i < maxIndiceNuevo; i++)
            {
                //TODO
            }

            // DEPENDE DEL GUSTO
            List<string> listaNueva = listaTextos;

            foreach (var elemento in listaNueva)
            {
                //TODO
            }
        }
    }
}