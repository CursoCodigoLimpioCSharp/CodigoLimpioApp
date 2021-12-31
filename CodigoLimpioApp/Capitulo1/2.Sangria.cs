using System.Collections.Generic;
using System.Linq;

namespace CodigoLimpioApp.Capitulo1
{
    public class Sangria
    {
        /// <summary>
        /// La sangria o espaciado de izquierda a derecha, se refiere al espacio que se deja para diferenciar
        /// las lineas que pertenecen al mismo método o grupo de código
        /// </summary>
        public Sangria()
        {
            // El texto se va hacia la derecha, hay que moverse hacia la derecha
            // para poder ver toda la linea de código
            string consultaSQL1 = "SELECT * " + "FROM ... " + "WHERE ... " + "GROUP BY ... " + "GROUP BY ... " + "GROUP BY ... " + "GROUP BY ... " + "ORDER BY ...;";

            string consultaSQL2 = "SELECT * " +
                "FROM ... " +
                "WHERE ... " +
                "GROUP BY ... " +
                "ORDER BY ...;";

            string consultaSQLConFormato1 = string.Format("SELECT * FROM {0} WHERE {1} GROUP BY {2} ORDER BY {3};", "", "", "", "");

            string consultaSQLConFormato2 = string.Format("SELECT * FROM {0} WHERE {1} GROUP BY {2} ORDER BY {3};",
                "",
                "",
                "",
                "");

            // Caso con pocos valores
            string.Format("{0}{1}{2}", "0", "1", "2");
            // Caso con muchos valores
            string.Format("{0}{1}{2}{3}{4}{5}",
                           "0",
                           "1",
                           "2",
                           "3",
                           "4",
                           "5");
            // Caso con muchos valores mejor formateado
            string.Format("{0}{1}{2}{3}{4}{5}",
                "0",
                "1",
                "2",
                "3",
                "4",
                "5");

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
                //TODO
                //TODO
                //TODO
            }

            var listaTextos = new List<string>();

            listaTextos.Where(w => w.Contains(""))
                .FirstOrDefault();

            listaTextos.Where(w => w.Contains("")).FirstOrDefault();

            string cadenaDeTexto = (from texto
                in listaTextos
                where texto.Contains("")
                select texto)
                .FirstOrDefault();

            string cadenaDeTextoNueva = (from texto
                                    in listaTextos
                                    where texto.Contains("")
                                    select texto)
                                    .FirstOrDefault();
        }

        public void Aux()
        {
            var listaTextos = new List<string>();

            string cadenaDeTexto = (from texto in listaTextos where texto.Contains("") select texto)
                .FirstOrDefault();

            string cadenaDeTextoNueva = (from texto in listaTextos where texto.Contains("") select texto)
                .FirstOrDefault();
        }
    }
}