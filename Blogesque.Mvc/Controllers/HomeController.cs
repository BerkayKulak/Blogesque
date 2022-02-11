using System.Threading.Tasks;
using Blogesque.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogesque.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IArticleService _articleService;

        public HomeController(IArticleService articleService)
        {
            _articleService = articleService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var articleListDto = await _articleService.GetAllByNonDeletedAndActiveAsync();
            return View(articleListDto.Data);
        }
    }
}
