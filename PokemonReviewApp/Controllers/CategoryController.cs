using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Intefaces;
using PokemonReviewApp.Models;
using PokemonReviewApp.Repository;

namespace PokemonReviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Category>))]
        public IActionResult GetCategory()
        {
            var categories = _mapper.Map<List<CategoryDto>>(_categoryRepository.GetCategories());
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(categories);
        }

        [HttpGet("{categoryId}")]
        [ProducesResponseType(200, Type = typeof(Category))]
        [ProducesResponseType(400)]
        public IActionResult GetCategory(int CategoryId)
        {
            if (!_categoryRepository.CategoriesExists(CategoryId))
                return NotFound();

            var Category = _mapper.Map<CategoryDto>(_categoryRepository.GetCategory(CategoryId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(Category);
        }

        [HttpGet("pokemon/{categoryId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]
        [ProducesResponseType(400)]
        public IActionResult GetpokemonByCategoryId(int categoryId)
        {
            var pokemons = _mapper.Map<List<PokemonDto>>(_categoryRepository.GetPokemonByCategory(categoryId));

            if(!ModelState.IsValid)
                return BadRequest();

            return Ok(pokemons);
        }

    }
}
