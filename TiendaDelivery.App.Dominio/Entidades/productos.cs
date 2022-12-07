using System.ComponentModel.DataAnnotations;


namespace TiendaDelivery.App.Dominio
{
    public class producto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "ERROR.. Imagen Obligatoria")]
        public string imagen { get; set; }
        [Required(ErrorMessage = "ERROR.. Nombre Obligatorio")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "ERROR.. infgeneral Obligatoria")]
        public string infGeneral { get; set; }
        [Required(ErrorMessage = "ERROR.. Precio Obligatorio")]
        public int precio { get; set; }
        public string infNutricional { get; set; }
        [Required(ErrorMessage = "ERROR.. CodInterno Obligatorio")]
        public string codInterno { get; set; }
        public string codBarras { get; set; }
        public string promociones { get; set; }
    }
}