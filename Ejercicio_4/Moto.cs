namespace Ejercicio_4
{
    internal class Moto
    {
        private int idMoto;
        private string marcaMoto;
        private string modeloMoto;
        private int kmMoto;
        private decimal precioMoto;
        private int annioMoto;
        private bool sidecarMoto;

        public Moto(int idMoto, string marcaMoto, string modeloMoto, int kmMoto, decimal precioMoto, int annioMoto, bool sidecarMoto)
        {
            this.idMoto = idMoto;
            this.marcaMoto = marcaMoto;
            this.modeloMoto = modeloMoto;
            this.kmMoto = kmMoto;
            this.precioMoto = precioMoto;
            this.annioMoto = annioMoto;
            this.sidecarMoto = sidecarMoto;
        }
    }
}