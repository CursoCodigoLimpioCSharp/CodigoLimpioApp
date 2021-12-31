
namespace CodigoLimpioApp
{
    public class DIP
    {
        //public ContextoBDLocal _ContextoBDLocal { get; set; }
        //public ContextoBDTest _ContextoBDTest { get; set; }
        //public ContextoBDProduccion _ContextoBDProduccion { get; set; }
        public IContexto Contexto { get; set; }

        public DIP(IContexto contexto)
        {
            Contexto = contexto;
        }

        //public DIP(ContextoBDLocal contextoBDLocal)
        //{
        //    _ContextoBDLocal = contextoBDLocal;

        //    //TODO
        //}

        //public DIP(ContextoBDTest contextoBDTest)
        //{
        //    _ContextoBDTest = contextoBDTest;

        //    //TODO
        //}

        //public DIP(ContextoBDProduccion contextoBDProduccion)
        //{
        //    _ContextoBDProduccion = contextoBDProduccion;

        //    //TODO
        //}
    }

    public class ContextoBDLocal : IContexto
    {
        private const string CadenaConexionSQLServer = "";

        public void EstablecerConexion()
        {
            //TODO
        }

        //TODO
    }

    public class ContextoBDTest : IContexto
    {
        private const string CadenaConexionSQLServer = "";

        public void EstablecerConexion()
        {
            //TODO
        }

        //TODO
    }

    public class ContextoBDProduccion : IContexto
    {
        private const string CadenaConexionSQLServer = "";

        public void EstablecerConexion()
        {
            //TODO
        }

        //TODO
    }

    public interface IContexto
    {

    }
}