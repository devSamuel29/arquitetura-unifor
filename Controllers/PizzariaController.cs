using SOLID.Request;
using SOLID.Response;
using SOLID.Interfaces;

using Microsoft.AspNetCore.Mvc;

namespace SOLID.PizzariaController;

[ApiController]
[Route("/[controller]")]
public class PizzariaController : ControllerBase
{
    private readonly IFazerPizza _fazerPizza;

    private readonly IFazerPagamento _fazerPagamento;

    private static List<PizzaResponse> _pizza = new();

    public PizzariaController(IFazerPizza fazerPizza, IFazerPagamento fazerPagamento)
    {
        _fazerPizza = fazerPizza;
        _fazerPagamento = fazerPagamento;
    }

    [HttpPost("fazer-pizza")]
    public IActionResult FazerPizza(PizzaRequest request)
    {
        var pizza = _fazerPizza.FazerPizza(request);
        _pizza.Add(pizza);
        return Ok(pizza);
    }

    [HttpPost("fazer-pagamento")]
    public IActionResult FazerPagamento()
    {
        PagamentoRequest request = new PagamentoRequest()
        {
            Pizza = _pizza.Last()
        };

        return Ok(_fazerPagamento.FazerPagamento(request));
    }
}
