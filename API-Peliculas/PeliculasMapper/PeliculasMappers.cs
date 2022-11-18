using API_Peliculas.Models;
using API_Peliculas.Models.Dtos;
using AutoMapper;

namespace API_Peliculas.PeliculasMapper
{
    public class PeliculasMappers : Profile
    {
        public PeliculasMappers()
        {
            CreateMap<Categoria, CategoriaDto>().ReverseMap();
        }
    }
}
