using SOLID.Request;
using SOLID.Response;
using SOLID.Interfaces;

namespace SOLID.Repository;

public class FazerPagamentoRepository : IFazerPagamento
{
    public PagamentoResponse FazerPagamento(PagamentoRequest request)
    {
        request.Pizza.Pagou = true;
        return new PagamentoResponse() { ValorTotal = request.Pizza.Preco * request.Pizza.Quantidade, Pizza = request.Pizza };
    }
}
