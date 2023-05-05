namespace Ejercicio_4
{
    internal class Auto
    {
        private int idAuto;
        private string marcaAuto;
        private string modeloAuto;
        private int kmAuto;
        private decimal precioAuto;
        private int annioAuto;
        private bool airbagAuto;

        public Auto(int idAuto, string marcaAuto, string modeloAuto, int kmAuto, decimal precioAuto, int annioAuto, bool airbagAuto)
        {
            this.idAuto = idAuto;
            this.marcaAuto = marcaAuto;
            this.modeloAuto = modeloAuto;
            this.kmAuto = kmAuto;
            this.precioAuto = precioAuto;
            this.annioAuto = annioAuto;
            this.airbagAuto = airbagAuto;
        }
    }
}