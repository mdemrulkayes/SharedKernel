using MediatR;

namespace SharedKarnel;

public interface ICommand<out TResponse> : IRequest<TResponse>;

public interface ICommand : IRequest;
