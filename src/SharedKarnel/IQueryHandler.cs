using MediatR;

namespace SharedKernel;
public interface IQueryHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse> 
    where TCommand : IQuery<TResponse>;
