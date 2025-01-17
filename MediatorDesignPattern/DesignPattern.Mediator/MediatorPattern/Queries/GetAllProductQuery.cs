using DesignPattern.Mediator.MediatorPattern.Results;
using MediatR;

namespace DesignPattern.Composite.MediatorPattern.Queries
{
  public class GetAllProductQuery : IRequest<List<GetAllProductQueryResult>>
  {

  }
}
