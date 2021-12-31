using System.Drawing;

namespace CodigoLimpioApp.Capitulo1
{
    public class Densidad
    {
        // Se refiere a que tan justo o unido se encuentra el código
        // si tiene los espacios o saltos de lineas necesarios para
        // que se pueda entender de una manera ordenada, concisa y clara.
        public Densidad()
        {
            for(int i=0;i<100;i++)if(i%2==0)return;//TODO

            var nuevaImagen=new Bitmap(1000,1000);
            int nuevoEjeX=(int)(nuevaImagen.Width*1.5);
            int nuevoEjeY=(int)(nuevaImagen.Height*1.5);

            var CoordenadasRecorteImagen = new Rectangle(100, 100, 500, 500);
            var CoordenadasRecorteImagenAumentado = new Rectangle((int)(CoordenadasRecorteImagen.X*1.15), (int)(CoordenadasRecorteImagen.Y*1.15), (int)(CoordenadasRecorteImagen.Width*1.15), (int)(CoordenadasRecorteImagen.Height*1.15));
        }
    }

    public class DensidadArreglado
    {
        public DensidadArreglado()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                    return;

                //TODO
            }

            var nuevaImagen = new Bitmap(1000, 1000);
            int nuevoEjeX = (int)(nuevaImagen.Width * 1.5);
            int nuevoEjeY = (int)(nuevaImagen.Height * 1.5);

            var CoordenadasRecorteImagen = new Rectangle(100, 100, 500, 500);
            var ejeXAumentado = (int)(CoordenadasRecorteImagen.X * 1.15);
            var ejeYAumentado = (int)(CoordenadasRecorteImagen.Y * 1.15);
            var anchoAumentado = (int)(CoordenadasRecorteImagen.Width * 1.15);
            var altoAumentado = (int)(CoordenadasRecorteImagen.Height * 1.15);

            var CoordenadasRecorteImagenAumentado = new Rectangle(
                ejeXAumentado,
                ejeYAumentado,
                anchoAumentado,
                altoAumentado);
        }
    }
}