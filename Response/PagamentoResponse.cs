namespace SOLID.Response;

public class PagamentoResponse
{
    public PizzaResponse Pizza { get; set; } = null!;

    public int ValorTotal { get; set; }
}
