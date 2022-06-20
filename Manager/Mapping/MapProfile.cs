using AutoMapper;
using Core.DTO;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Personnel, PersonnelDTO>().ReverseMap();
        }
    }
}
