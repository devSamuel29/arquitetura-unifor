using SOLID.Request;
using SOLID.Response;

namespace SOLID.Interfaces;

public interface IFazerPagamento
{
    PagamentoResponse FazerPagamento(PagamentoRequest request);
}