using System.Drawing;

namespace CodigoLimpioApp
{
    public class LSP
    {
        public LSP()
        {
            var imagenProcessor = new ImagenProcessor();

            IImagen imagen15Grados = new Imagen15Grados();

            imagenProcessor.ProcesarImagen(imagen15Grados);

            IImagen imagen30Grados = new Imagen30Grados();

            imagenProcessor.ProcesarImagen(imagen30Grados);
        }
    }

    public class ImagenProcessor
    {
        private IImagen _Imagen { get; set; }
        //private Imagen15Grados _Imagen15Grados { get; set; }
        //private Imagen30Grados _Imagen30Grados { get; set; }

        public void ProcesarImagen(IImagen imagen)
        {
            _Imagen = imagen;

            //TODO

            var imagenRecortada = ObtenerImagen();
        }

        private Bitmap ObtenerImagen()
        {
            //TODO

            return null;
        }

        //public void ProcesarImagen(Imagen15Grados imagen)
        //{
        //    _Imagen15Grados = imagen;

        //    //TODO

        //    var imagenRecortada = ObtenerImagen15GradosRecortada();
        //}

        //private Bitmap ObtenerImagen15GradosRecortada()
        //{
        //    //TODO

        //    return null;
        //}

        //public void ProcesarImagen(Imagen30Grados imagen)
        //{
        //    _Imagen30Grados = imagen;

        //    //TODO

        //    var imagenRecortada = ObtenerImagen30GradosRecortada();
        //}

        //private Bitmap ObtenerImagen30GradosRecortada()
        //{
        //    //TODO

        //    return null;
        //}
    }

    public interface IImagen
    {

    }

    public class Imagen15Grados : IImagen
    {
        public Bitmap ImagenCompleta { get; private set; }
        public Rectangle CoordenadasParaRecorte { get; private set; }

        public void GuardarImagen(Bitmap imagen)
        {
            ImagenCompleta = imagen;
        }

        public void GuardarCoordenadas(Rectangle coordenadas)
        {
            CoordenadasParaRecorte = coordenadas;
        }
    }

    public class Imagen30Grados : IImagen
    {
        public Bitmap ImagenCompleta { get; private set; }
        public Rectangle CoordenadasParaRecorte { get; private set; }

        public void GuardarImagen(Bitmap imagen)
        {
            ImagenCompleta = imagen;
        }

        public void GuardarCoordenadas(Rectangle coordenadas)
        {
            CoordenadasParaRecorte = coordenadas;
        }
    }
}