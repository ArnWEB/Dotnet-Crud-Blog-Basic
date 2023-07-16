using ArnBlog.Web.Data;
using ArnBlog.Web.Models.Domain;
using ArnBlog.Web.Models.View;
using Microsoft.AspNetCore.Mvc;

namespace ArnBlog.Web.Controllers
{
    public class AdminTagsController : Controller
    {
        private readonly ArnblogDbContext arnblogDbContext;

        public AdminTagsController(ArnblogDbContext arnblogDbContext)
        {
            this.arnblogDbContext = arnblogDbContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Add")]
        public IActionResult SubmitTag(AddTagRequest addTagRequest)
        {
            var name = addTagRequest.Name;
            var displayName = addTagRequest.DisplayName;
            var tags = new Tag
            {
                Name = addTagRequest.Name, DisplayName = addTagRequest.DisplayName
            };


            arnblogDbContext.Tags.Add(tags);
            arnblogDbContext.SaveChanges();
            return View("Add");
        }
    }
}
