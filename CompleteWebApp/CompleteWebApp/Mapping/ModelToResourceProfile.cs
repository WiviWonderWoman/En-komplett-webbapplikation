using AutoMapper;
using CompleteWebApp.Domain.Models;
using CompleteWebApp.Resources;

namespace CompleteWebApp.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            this.CreateMap<Rover, RoverResource>();
        }
    }
}
