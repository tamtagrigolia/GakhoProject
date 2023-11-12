using AutoMapper;
using GakhoProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.Options;

namespace GakhoProject.Configuration
{
    public class Gakharia : Profile
    {
        public Gakharia()
        {
            CreateMap<UserRegistraionModel, IdentityUser>()
                .ForMember(x => x.UserName, Options => Options.MapFrom(x => x.Email));
        }
    }
}
