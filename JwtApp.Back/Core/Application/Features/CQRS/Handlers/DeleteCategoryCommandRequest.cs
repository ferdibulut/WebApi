using MediatR;

namespace JwtApp.Back.Core.Application.Features.CQRS.Handlers
{
    public class DeleteCategoryCommandRequest:IRequest
    {
        public int Id { get; set; }
        public DeleteCategoryCommandRequest(int id)
        {
            Id = id;
        }
    }
}
