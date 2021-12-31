using System.Net.Http;

namespace CodigoLimpioApp
{
    public class ISP
    {
        public ISP()
        {
            var httpSender = new HttpSender();

            HttpResponseMessage responseMessage = httpSender.EnviarPedido(null);
        }
    }

    public class HttpSender : IClientEnviar<HttpRequestMessage>
    {
        private HttpClient _HttpClient { get; set; } = new HttpClient();

        public HttpResponseMessage EnviarPedido(HttpRequestMessage requestMessage)
        {
            //TODO

            return null;
        }
    }

    public interface IClientEnviar<T>
    {
        HttpResponseMessage EnviarPedido(T pedido);
    }

    public interface IClientRecibir
    {
        string RespuestaPedido(HttpResponseMessage responseMessage);
    }
}