using API_Peliculas.Models;
using API_Peliculas.Models.Dtos;
using AutoMapper;

namespace API_Peliculas.PeliculasMapper
{
    public class PeliculasMapper : Profile
    {
        public PeliculasMapper()
        {
            CreateMap<Categoria, CategoriaDto>().ReverseMap();
        }
    }
}
