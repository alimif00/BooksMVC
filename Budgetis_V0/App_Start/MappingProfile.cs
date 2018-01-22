using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Budgetis_V0.Dtos;
using Budgetis_V0.Models;

namespace Budgetis_V0.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Tache, TacheDto>();
            Mapper.CreateMap<TacheDto, Tache>().ForMember(m => m.id, opt => opt.Ignore());

            Mapper.CreateMap<TypeCategorie, TypeCategorieDto>();
            Mapper.CreateMap<Categorie, CategorieDto>();
        }
    }
}