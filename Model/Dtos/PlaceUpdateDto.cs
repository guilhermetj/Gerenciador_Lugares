namespace Gerenciador_Lugares.Model.Dtos;

public class PlaceUpdateDto
{
    public string? Name { get; set; }
    public string? Slug { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
