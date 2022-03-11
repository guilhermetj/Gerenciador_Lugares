using System.ComponentModel.DataAnnotations;

namespace Gerenciador_Lugares.Model.Dtos;

public class PlaceCreateDto
{
    [StringLength(20, MinimumLength = 1, ErrorMessage = "Nomes podem conter no maximo 20 caracteres")]
    public string Name { get; set; }
    public string Slug { get; set; }
    public string City { get; set; }
    [StringLength(2, MinimumLength = 2, ErrorMessage = "Estados devem conter 2 caracteres")]
    public string State { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

}
