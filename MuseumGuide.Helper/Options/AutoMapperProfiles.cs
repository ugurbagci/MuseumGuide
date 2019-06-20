using AutoMapper;
using MuseumGuide.DTO;
using MuseumGuide.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MuseumGuide.Helper.Options
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Museum, MuseumForList>().ForMember(dest => dest.PhotoUrl, opt =>
            {
                opt.MapFrom(src => src.Photos.FirstOrDefault(x => x.IsMain).Url);

            });

            CreateMap<Museum, MuseumForDetail>();
            CreateMap<PhotoForCreation, Photo>();
            CreateMap<PhotoForReturn, Photo>();
        }
    }
}
