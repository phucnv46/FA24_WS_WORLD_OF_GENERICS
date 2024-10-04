using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using World_Of_Generics_API.DTOs;
using World_Of_Generics_API.Models;
using World_Of_Generics_API.Repositories;

namespace World_Of_Generics_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly Repository<Product,ProductDTO> _repository;

        public ProductController(Repository<Product,ProductDTO> repository)
        {
            _repository = repository;
        }

        [HttpGet("/products")]
        public ActionResult GetProducts() 
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet("/product")]
        public ActionResult GetProduct([FromQuery]long id)
        {
            return Ok(_repository.Get(id));
        }

        [HttpPost("/product")]
        public IActionResult Add(ProductDTO product)
        {
            _repository.Add(product);
            return Ok("Succes");
        }


    }
}
