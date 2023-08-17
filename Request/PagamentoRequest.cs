using SOLID.Response;

namespace SOLID.Request;

public class PagamentoRequest
{
    public PizzaResponse Pizza { get; set; } = null!;
}