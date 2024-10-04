using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using World_Of_Generics_API.DTOs;
using World_Of_Generics_API.Models;
using World_Of_Generics_API.Repositories;

namespace World_Of_Generics_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly Repository<Category,CategoryDTO> _repository;

        public CategoryController(Repository<Category,CategoryDTO> repository)
        {
            _repository = repository;
        }

        [HttpGet("/Categorys")]
        public ActionResult GetCategorys()
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet("/Category")]
        public ActionResult GetCategory([FromQuery] long id)
        {
            return Ok(_repository.Get(id));
        }
    }
}
