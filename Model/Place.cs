namespace Test_BackEnd.Model;

public class Place
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}

