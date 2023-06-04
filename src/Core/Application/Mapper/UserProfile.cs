using AutoMapper;

namespace Application.Mapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Domain.User, Models.NewsUserViewModel>();
        }
    }
}