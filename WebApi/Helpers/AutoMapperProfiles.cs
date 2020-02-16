
using System.Linq;
using AutoMapper;
using NetCoreAngular_Project.DTO;

namespace NetCoreAngular_Project.Helpers
{
   public class AutoMapperProfiles:Profile{
       public AutoMapperProfiles()
       {
           CreateMap<City,CityForListDto>()
           .ForMember(dest => dest.PhotoUrl,opt=>{
               opt.MapFrom(src=>src.Photos.FirstOrDefault(x=>x.IsMain).Url);
           });
           ;

           CreateMap<City,CityForDetailDto>();
       }
   }
}