using MediatR;

namespace SharedKarnel;
public interface IQuery<out TResponse> : IRequest<TResponse>;
