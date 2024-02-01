using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Intefaces;

namespace PokemonReviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrountryCtontroller
    {
        private readonly ICountryRepository _countryRepository;
        private readonly IMapper _mapper;

        public CrountryCtontroller(ICountryRepository countryRepository,IMapper mapper)
        {
            _countryRepository = countryRepository;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(200,Type = typeof(IEnumerable<>)]
    }
}
