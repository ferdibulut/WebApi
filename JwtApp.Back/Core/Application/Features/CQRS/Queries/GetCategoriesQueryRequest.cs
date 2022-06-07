using JwtApp.Back.Core.Application.Dto;
using MediatR;

namespace JwtApp.Back.Core.Application.Features.CQRS.Commands
{
    public class GetCategoriesQueryRequest:IRequest<List<CategoryListDto>>
    {
    }
}
