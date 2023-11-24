
using LINQ.Data;
using Microsoft.AspNetCore.Mvc;

namespace LINQ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("startsWith'S'Query")]
        public ActionResult GetProducts()
        {
            var data = _context.Products;

            var response = data.Where(i => i.Name.StartsWith("s")).ToList();

            //Second way to do the same operationb
            var response2 =
                from product in _context.Products
                where product.Name.StartsWith("s")
                select product;


            return Ok(response);

            //return Ok(response2); // this will return the same data 
        }


        [HttpGet("orderBy")]
        public ActionResult GetProductsOrderBy()
        {
            var data = _context.Products;

            var response =
                from product in _context.Products
                orderby product.Name
                select product;

            return Ok(response);
        }
    }
}
