using AutoMapper;
using Domain;

namespace Application.Automobili
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Automobil, AutomobilDTO>();
            CreateMap<SveOAutomobilu, SveOAutomobilimaDTO>()
                .ForMember(d => d.VrsteKaroserija, o => o.MapFrom(s => s.Karoserija.Vrsta))
                .ForMember(d => d.VrsteKubikaza, o => o.MapFrom(s => s.Kubikaza.Vrsta))
                .ForMember(d => d.VrsteKwks, o => o.MapFrom(s => s.Kwks.Vrsta))
                .ForMember(d => d.VrstaPogona, o => o.MapFrom(s => s.Pogon.Vrsta))
                .ForMember(d => d.VrstaOpreme, o => o.MapFrom(s => s.Oprema.Vrsta));
        }
    }
}