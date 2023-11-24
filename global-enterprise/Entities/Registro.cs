using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace global_enterprise.Entities
{
    public class Registro
    {
        [Key]
        public int IdRegistro { get; set; }
        [Required]
        [MaxLength(11)]
        public string CPF { get; set; }
        [Required]
        [MaxLength(11)]
        public string Vacina { get; set; }
        [Required]
        [MaxLength(11)]
        public string Unidade { get; set; }

    }
}
