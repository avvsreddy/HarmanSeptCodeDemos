using CoolProductsAPIService.Model.Data;
using CoolProductsAPIService.Model.Entities;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoolProductsAPIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductsController : ControllerBase
    {

        private readonly ProductsDbContext db = null;

        public ProductsController(ProductsDbContext db)
        {
            this.db = db;
        }
        // Get All Products
        // Design the URL - no verbs
        // GET .../api/products
        [HttpGet]
        [EnableQuery]
        //[Authorize]
        //[EnableCors("_myAllowSpecificOrigins")]
        public IQueryable<Product> GetAllProducts() // Endpoint
        {
            return db.Products.AsQueryable();
        }


        // GET .../api/products/123
        [HttpGet]
        [Route("{id:int}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await db.Products.FindAsync(id);
            if (product == null)
            {
                // return not found http status code - 404
                return NotFound();

            }
            // return ok with data - 200
            return Ok(product);
        }
        // design the endpoint
        // implement the action method

        // get products by name
        // GET .../api/products/name/{iphone}
        [HttpGet]
        [Route("name/{name:alpha}")]
        public async Task<IActionResult> GetProductsByName(string name)
        {
            var products = await db.Products.Where(p => p.Name.Contains(name)).ToListAsync();
            if (products.Count == 0)
            {
                return NotFound();
            }
            return Ok(products);
        }

        // get products by brand
        // get products by coutry
        // get products in stock
        // get cheapest product
        // GET .../api/products/cheapest
        [HttpGet]
        [Route("cheapest")]
        public IActionResult GetCheapestProduct()
        {
            var cheapestProduct = from p in db.Products
                                  orderby p.Price
                                  select p;
            return Ok(cheapestProduct.FirstOrDefault());
        }

        // get constliet product
        // get product in the price range (1000 2000)
        // GET .../api/products/min/{1000}/max/{2000}
        [HttpGet("min/{min:int}/max/{max:int}")]
        public IActionResult GetProductsByPriceRange(int min, int max)
        {
            var products = (from p in db.Products
                            where p.Price >= min && p.Price <= max
                            select p).ToList();

            if (products.Count == 0)
                return NotFound();

            return Ok(products);
        }


        // Add endpoint
        // POST .../api/products

        [HttpPost]
        public IActionResult Post(Product product)
        {
            // validate
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid input");
            }

            db.Products.Add(product);
            db.SaveChanges();
            // return http status code 201 + Location + saved data
            return Created($"api/products/{product.ProductId}", product);

        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            var productToDel = db.Products.Find(id);
            if (productToDel == null)
            {
                return NotFound();
            }
            db.Products.Remove(productToDel);
            db.SaveChanges();
            return Ok();
        }

        //[HttpPatch] Partial update :TODO

        [HttpPut]
        // PUT .../api/products/{id}
        [Route("{id:int}")]
        public IActionResult Put([FromHeader] int id, [FromBody] Product product)
        {
            var productToEdit = db.Products.Find(id);
            if (productToEdit == null)
            {
                return NotFound();
            }

            // use Automappers to reduce the below code

            productToEdit.ProductId = id;
            productToEdit.Name = product.Name;
            productToEdit.Price = product.Price;
            productToEdit.Category = product.Category;
            productToEdit.Brand = product.Brand;
            productToEdit.InStock = product.InStock;
            // validate
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid input");
            }
            //db.Products.Update(product);
            //db.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return Ok();
        }

    }
}
