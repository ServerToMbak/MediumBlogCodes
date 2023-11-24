
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


        // will retrurn the product list which will be including every product which Name starts with 'S' letter 
        [HttpGet("startsWith'S'Query")]
        public ActionResult GetProducts()
        {
            var data = _context.Products;

            var response = data.Where(i => i.Name.StartsWith("s")).ToList();

            //Second way to do the same operationb
            var response2 =
                from product in data
                where product.Name.StartsWith("s")
                select product;


            return Ok(response);

            //return Ok(response2); // this will return the same data 
        }

        // This method will make the same operation in sql with order by as below script
        //SELECT* FROM Products ORDER BY Name; 
        // It will return the data with priority of prdouct Name Ascending  [a-z]
        [HttpGet("orderByAscending")]
        public ActionResult GetProductsOrderByAscending()
        {
            var data = _context.Products;

            var response =
                from product in data
                orderby product.Name
                select product;

            return Ok(response);
        }

        // This method will make the same operation in sql with order by as below script
        //SELECT* FROM Products ORDER BY Name DESC;
        // It will return the data with priority of prdouct Name Descending  [z-a]
        [HttpGet("orderByDescending")]
        public ActionResult GetProductsOrderByDescending()
        {
            var data = _context.Products;

            var response =
                from product in data
                orderby product.Name descending
                select product;

            return Ok(response);
        }
        // it will make a join operation -- it will go and connect with categoryId to category table and get
        // category with product data together 

        [HttpGet("Join Operations")]
        public ActionResult GetProductsWithCategoryInformations()
        {
             
            var query = from product in _context.Products
                        join category in _context.Categories
                        on product.CategoryId equals category.Id
                        select new { product.Category, product.Name };

            return Ok(query);
        }
    }
}
