using System.ComponentModel.DataAnnotations;

namespace FinalProjectBikes.Modelo
{
    public class Proveedor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? NameProveedor { get; set; }

        [Required(ErrorMessage = "El telefono es requerido")]
        [StringLength(10, ErrorMessage = "Maximo 10 caracteres")]
        public string? PhoneNumberProveedor { get; set; }

        [Required(ErrorMessage = "La direccion es requerida")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? DirectionProveedor { get; set; }

        [Required(ErrorMessage = "El modelo es requerido")]
        [StringLength(20, ErrorMessage = "Maximo 100 caracteres")]
        public string? ModelBikeProveedor { get; set; }
        [Required(ErrorMessage = "El precio es requerido")]
        [StringLength(20, ErrorMessage = "Maximo 20 caracteres")]
        public  string? PriceProveedor { get; set; }

        [Required(ErrorMessage = "La cantidad de bicicletas a enviar es requerida")]
        [StringLength(10000,ErrorMessage = "Maximo 1000 caracteres")]
        public string? AmountProveedor { get; set; }


    }
}
