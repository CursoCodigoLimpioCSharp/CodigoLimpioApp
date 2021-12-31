using System;
using System.Collections.Generic;

namespace CodigoLimpioApp.Capitulo5
{
    public class Ejemplo3
    {
        // Obtener la suma de una lista de montos con diferentes tipos de monedas
        // Hacer la conversion entre monedas y sumar
        public Ejemplo3()
        {
            var monedas = new Dictionary<string, float>
            {
                { "USD-EUR", 0.84f },
                { "USD-NZD", 1.46f },
                { "EUR-USD", 1.18f },
                { "EUR-NZD", 1.73f },
                { "NZD-USD", 0.68f },
                { "NZD-EUR", 0.58f }
            };

            var transacciones = new List<Tuple<string, float>>
            {
                new Tuple<string, float>("USD", 1),
                new Tuple<string, float>("USD", 2),
                new Tuple<string, float>("USD", 3),

                new Tuple<string, float>("EUR", 1),
                new Tuple<string, float>("EUR", 2),
                new Tuple<string, float>("EUR", 3),

                new Tuple<string, float>("NZD", 1),
                new Tuple<string, float>("NZD", 2),
                new Tuple<string, float>("NZD", 3),
            };

            var res = ObtenerTotal(transacciones, monedas, "USD");

            // USD
            // 1+2+3=6
            // 0.84+1.68+2.52=5.04
            // 1.46+2.92+4.38=8.76
            // 19.80
        }

        public float ObtenerTotal(IList<Tuple<string, float>> transacciones, IDictionary<string, float> monedas, string monedaEsperada)
        {
            float resultado = 0;

            foreach (var transaccion in transacciones)
            {
                var cambio = (monedaEsperada.Equals(transaccion.Item1)) ? 1 : monedas[$"{monedaEsperada}-{transaccion.Item1}"];

                resultado = resultado + (transaccion.Item2 * cambio);
            }

            return resultado;
        }

        //var transacciones = new List<Transaccion>
        //    {
        //        new Transaccion("USD", 0),
        //        new Transaccion("USD", 0),
        //        new Transaccion("USD", 0),
        //        new Transaccion("EUR", 0),
        //        new Transaccion("EUR", 0),
        //        new Transaccion("EUR", 0),
        //        new Transaccion("NZD", 0),
        //        new Transaccion("NZD", 0),
        //        new Transaccion("NZD", 0)
        //    };

        //public class Transaccion
        //{
        //    public string Moneda { get; set; }
        //    public float Valor { get; set; }

        //    public Transaccion(string moneda, float valor)
        //    {
        //        Moneda = moneda;
        //        Valor = valor;
        //    }
        //}
    }
}