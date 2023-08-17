using SOLID.Request;
using SOLID.Response;
using SOLID.Interfaces;
using SOLID.Models;

namespace SOLID.Repository;

public class FazerPizzaRepository : IFazerPizza
{
    private static int COUNT = 0;

    public PizzaResponse FazerPizza(PizzaRequest request)
    {
        COUNT++;
        var model = new PizzaModel()
        {
            Id = COUNT,
            Quantidade = request.Quantidade,
            Sabor = request.Sabor,
        };

        if (model.Sabor == 0)
        {
            return new PizzaResponse() { Id = model.Id, Sabor = "Mussarela", Preco = 25, Quantidade = request.Quantidade };
        }

        return new PizzaResponse() { Id = model.Id, Sabor = "Calabresa", Preco = 23, Quantidade = request.Quantidade };
    }
}
