using SOLID.Enums;

namespace SOLID.Request;

public class PizzaRequest
{
    public SaborPizza Sabor { get; set; }

    public int Quantidade { get; set; }
}