using System.Drawing;

namespace CodigoLimpioApp
{
    public class OCP
    {
        public OCP()
        {
            var imagenHandler = new ImagenHandler();

            var imagenPerfil = new Imagen(TipoImagen.PERFIL);
            imagenHandler.ProcesarImagen(imagenPerfil);

            var imagenFrontal = new Imagen(TipoImagen.FRONTAL);
            imagenHandler.ProcesarImagen(imagenFrontal);

            var imagen15Grados = new Imagen(TipoImagen.GRADOS_15);
            imagenHandler.ProcesarImagen(imagen15Grados);
        }
    }

    public enum TipoImagen
    {
        PERFIL = 1,
        FRONTAL = 2,
        GRADOS_15 = 3,
        GRADOS_30 = 4,
        GRADOS_45 = 5,
        GRADOS_60 = 6
    }

    public class ImagenHandler
    {
        public Bitmap ProcesarImagen(Imagen imagen)
        {
            switch (imagen.TipoDeImagen)
            {
                case TipoImagen.PERFIL:
                    //TODO recorte
                    break;
                case TipoImagen.FRONTAL:
                    //TODO recorte
                    break;
                case TipoImagen.GRADOS_15:
                    //TODO recorte
                    break;
                case TipoImagen.GRADOS_30:
                    //TODO recorte
                    break;
                case TipoImagen.GRADOS_45:
                    //TODO recorte
                    break;
                case TipoImagen.GRADOS_60:
                    //TODO recorte
                    break;
                default:
                    //TODO recorte
                    break;
            }

            return null;
        }
    }

    public class Imagen
    {
        public Bitmap ImagenCompleta { get; set; }
        public Rectangle CoordenadasParaRecorte { get; set; }
        public TipoImagen TipoDeImagen { get; set; }

        public Imagen(TipoImagen tipoImagen)
        {
            TipoDeImagen = tipoImagen;
        }
    }
}