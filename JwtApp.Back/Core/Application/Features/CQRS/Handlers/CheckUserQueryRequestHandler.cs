using JwtApp.Back.Application.Interfaces;
using JwtApp.Back.Core.Application.Dto;
using JwtApp.Back.Core.Application.Features.CQRS.Queries;
using JwtApp.Back.Core.Domain;
using JwtApp.Back.Persistance.Repositories;
using MediatR;

namespace JwtApp.Back.Core.Application.Features.CQRS.Handlers
{
    public class CheckUserQueryRequestHandler : IRequestHandler<CheckUserQueryRequest, CheckUserResponseDto>
    {
        private readonly IRepository<AppUser> _userRepository;
        private readonly IRepository<AppRole> _roleRepository;

        public CheckUserQueryRequestHandler(IRepository<AppUser> userRepository, IRepository<AppRole> roleRepository)
        {
            _userRepository = userRepository;
            _roleRepository = roleRepository;
        }

        public async Task<CheckUserResponseDto> Handle(CheckUserQueryRequest request, CancellationToken cancellationToken)
        {
            var dto = new CheckUserResponseDto();
            var user = await _userRepository.GetByFilterAsync(x => x.Username == request.Username && x.Password == request.Password);
            if (user == null)
            {
                dto.IsExits = false;
            }
            else
            {
                dto.Username = user.Username;
                dto.Id = user.Id;
                dto.IsExits = true;
                var role = await _roleRepository.GetByFilterAsync(x=>x.Id==user.AppRoleId);
            }
            return dto;
        }
    }
}
