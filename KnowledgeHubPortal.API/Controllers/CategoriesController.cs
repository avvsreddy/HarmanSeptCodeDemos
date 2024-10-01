using KnowledgeHubPortal.Domain.Entities;
using KnowledgeHubPortal.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace KnowledgeHubPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository repo;

        //DI
        public CategoriesController(ICategoryRepository repo)
        {
            this.repo = repo;
        }


        // Get all categories
        // Design the endpoint
        // GET .../api/categories
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await repo.GetAllAsync());
        }

        // Create Category
        // POST .../api/categories
        [HttpPost]
        public async Task<IActionResult> CreateAsync(Category category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await repo.CreateAsync(category);
            return Created($"api/categories/{category.CategoryID}", category);
        }


    }
}
