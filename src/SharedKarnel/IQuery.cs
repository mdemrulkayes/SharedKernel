using MediatR;

namespace SharedKernel;
public interface IQuery<out TResponse> : IRequest<TResponse>;
