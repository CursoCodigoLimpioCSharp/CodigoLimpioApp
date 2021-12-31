using System;
using System.Collections.Generic;
using System.Linq;
using CodigoLimpioApp.Capitulo5.Dto;
using CodigoLimpioApp.Capitulo5.Enums;
using CodigoLimpioApp.Capitulo5.Helpers;

namespace CodigoLimpioApp.Capitulo5
{
    /// <summary>
    /// El método va a recibir un diccionario con 4 llaves "A", "B", "C" y "Z". Como valor tendra una lista
    /// con valores double.
    /// 
    /// El objetivo del método es devolver las llaves "A", "B", "C" con el promedio de los valores de la lista
    /// de doubles.
    /// </summary>
    public class Ejemplo1
    {
        public List<Tuple<string, double>> ObtenerPromediosPorTipo(Dictionary<string, List<double>> tipoValores)
        {
            // Promedios a retornar
            List<Tuple<string, double>> res = new List<Tuple<string, double>>();
            // Estos se toman
            var a = "A";
            var b = "B";
            var c = "C";
            // Este se excluye
            var z = "Z";
            // Promedio a acumular
            double prom = 0;

            var tiposA = tipoValores.Where(w => w.Key == "A").Select(s => s.Value).ToList();
            prom = 0;
            if (tiposA.Count() > 0)
            {
                for (int i = 0; i < tiposA.Count(); i++)
                {
                    for (int j = 0; j < tiposA[i].Count; j++)
                    {
                        prom = prom + tiposA[i][j];
                    }
                }

                res.Add(new Tuple<string, double>("A", prom / tiposA[0].Count()));
            }

            var tiposB = tipoValores.Where(w => w.Key == "B").Select(s => s.Value).ToList();
            prom = 0;
            if (tiposB.Count() > 0)
            {
                for (int i = 0; i < tiposB.Count(); i++)
                {
                    for (int j = 0; j < tiposB[i].Count; j++)
                    {
                        prom = prom + tiposB[i][j];
                    }
                }

                res.Add(new Tuple<string, double>("B", prom / tiposB[0].Count()));
            }

            var tiposC = tipoValores.Where(w => w.Key == "C").Select(s => s.Value).ToList();
            prom = 0;
            if (tiposC.Count() > 0)
            {
                for (int i = 0; i < tiposC.Count(); i++)
                {
                    for (int j = 0; j < tiposC[i].Count; j++)
                    {
                        prom = prom + tiposC[i][j];
                    }
                }

                res.Add(new Tuple<string, double>("C", prom / tiposC[0].Count()));
            }

            return res;
        }
    }

    public class Ejemplo1Arreglado
    {
        private const string TIPO_A_EXCLUIR = "Z";

        /// <summary>
        /// Obtener promedios por tipo excluyendo al tipo "Z".
        /// </summary>
        public List<TipoPromedio> ObtenerPromediosPorTipo(Dictionary<string, List<double>> tipoValores)
        {
            var resultadoPromedios = new List<TipoPromedio>();
            var tipoValoresParaPromediar = tipoValores.Where(w => w.Key != TIPO_A_EXCLUIR);

            foreach (var tipoValor in tipoValoresParaPromediar)
            {
                var tipo = tipoValor.Key.Convertir<Tipo>();
                var promedio = tipoValor.Value.Average();
                var tipoPromedio = new TipoPromedio(tipo, promedio);

                resultadoPromedios.Add(tipoPromedio);
            }

            return resultadoPromedios;
        }
    }
}