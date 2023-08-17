namespace SOLID.Response;

public class PizzaResponse
{
    public int Id { get; set; }

    public required string Sabor { get; set; }

    public int Preco { get; set; }

    public int Quantidade { get; set; }
    
    public bool Pagou { get; set; } = false;
}