using System.Web.Http;
using Entity;
using Service;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [RoutePrefix("api/category")]
    public class CategoryController : ApiController
    {
        private ICategoryService categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        [Route("ping")]
        public IHttpActionResult Ping()
        {
            return Ok("PONG");
        }

        [HttpPost]
        public IHttpActionResult Create(CategoryModel model)//FormCollection collection
        {
            try
            {
                var category = new Category();
                category.Name = model.Name;

                categoryService.Insert(category);

                return Ok(new { results = "DONE" });
            }
            catch
            {
                return Ok();
            }
        }
    }
}

