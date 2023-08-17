using SOLID.Request;
using SOLID.Response;

namespace SOLID.Interfaces;

public interface IFazerPizza
{
    PizzaResponse FazerPizza(PizzaRequest request);
}