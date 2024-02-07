using MediatR;

namespace SharedKernel;

public interface ICommand<out TResponse> : IRequest<TResponse>;

public interface ICommand : IRequest;
