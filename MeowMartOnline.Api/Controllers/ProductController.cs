using MeowMartOnline.Api.Extensions;
using MeowMartOnline.Api.Repositories.Contracts;
using MeowMartOnline.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MeowMartOnline.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        
        [HttpGet]
        //This will bring the user to the product http page from the productDto
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetItems()
        {
            try
            {
                var products = await this.productRepository.GetItems();
                var productCategories = await this.productRepository.GetCategories();
                
                //if there are no products/categories
                if(products == null || productCategories == null)
                {
                    return NotFound();
                }
                else
                {
                    //returns the http page of the product list from the Dto (aka the 200 status code)
                    var productDtos = products.ConvertToDto(productCategories);
                    return Ok(productDtos);
                }
            }
            catch (Exception)
            {
                //if for any reason the data is not retrieved from the DB, a status 500 http page will show up 
                // as a error page
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error! Did not get retrieving data from the database.");
            }
        }
    }
}
