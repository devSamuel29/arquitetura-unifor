using SOLID.Enums;

namespace SOLID.Models;

public class PizzaModel
{
    public int Id { get; set; }

    public SaborPizza Sabor { get; set; }

    public int Quantidade { get; set; }
}