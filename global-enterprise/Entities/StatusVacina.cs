using System.ComponentModel.DataAnnotations;
namespace global_enterprise.Entities;

public class StatusVacina
{
    [Key]
    public int IdStatus { get; set; }
    [Required]
    [MaxLength(20)]
    public string TipoStatus { get; set; }
    [Required]
    public DateTime Data { get; set; }
    [Required]
    [Range(1, 999999)]
    public int NumeroLote { get; set; }
}
