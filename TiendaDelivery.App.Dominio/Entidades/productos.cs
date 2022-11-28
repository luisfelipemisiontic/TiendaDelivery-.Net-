namespace TiendaDelivery.App.Dominio
{
    public class producto
    {
        public int Id { get; set; }
        public string imagen { get; set; }
        public string nombre { get; set; }
        public string infGeneral { get; set; }
        public int precio { get; set; }
        public string infNutricional { get; set; }
        public string codInterno { get; set; }
        public string codBarras { get; set; }
        public string promociones { get; set; }
    }
}