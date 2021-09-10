using Microsoft.AspNetCore.Mvc;
using SchoolOf.Data.Abstraction;
using SchoolOf.Data.Models;
using SchoolOf.Dtos;
using System.Collections.Generic; 
using System.Threading.Tasks;

namespace SchoolOf.ShoppingCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductsController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ProductDto>), 200)]
        public async Task<IActionResult> GetProducts()
        {
            var myListOfProducts = new List<ProductDto>();
            var productsFromDb = this._unitOfWork.GetRepository<Product>().Find(product => !product.IsDeleted);

            foreach(var p in productsFromDb)
            {
                myListOfProducts.Add(new ProductDto {
                    Category = p.Category,
                    Description = p.Description,
                    Id = p.Id,
                    Image = p.Image,
                    Name = p.Name,
                    Price = p.Price
                });
            }

            return Ok(myListOfProducts);
        }
    }
}
