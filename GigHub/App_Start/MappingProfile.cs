using AutoMapper;
using GigHub.Controllers.Api;
using GigHub.Dtos;
using GigHub.Models;

namespace GigHub.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.Initialize(c =>
            {
                c.CreateMap<ApplicationUser, UserDto>();
                c.CreateMap<Gig, GigDto>();
                c.CreateMap<Notification, NotificationDto>();
            });
        }

    }
}