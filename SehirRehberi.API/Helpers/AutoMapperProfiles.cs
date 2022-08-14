using AutoMapper;
using SehirRehberi.API.DTOS;
using SehirRehberi.API.Model;

namespace SehirRehberi.API.Helpers
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<City,CityForListDto>()
                .ForMember(dest=>dest.PhotoUrl,opt =>
                {
                    opt.MapFrom(
                        src => src.Photos.Where(p => p.IsMain == true)
                                  .FirstOrDefault().Url
                        );
                });

            CreateMap<City, CityForDetailDto>();
        }
    }
}
