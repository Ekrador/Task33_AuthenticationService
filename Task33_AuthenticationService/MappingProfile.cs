using AutoMapper;

namespace Task33_AuthenticationService
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserViewModel>().ConstructUsing(v => new UserViewModel(v));
        }
    }
}
