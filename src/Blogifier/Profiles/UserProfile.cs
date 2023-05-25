using AutoMapper;
using Blogifier.Identity;
using Blogifier.Shared;

namespace Blogifier.Profiles;

public class UserProfile : Profile
{
  public UserProfile()
  {
    CreateMap<UserInfo, UserDto>().ReverseMap();
  }
}
