﻿using System.Threading.Tasks;
using Blogesque.Entities.Concrete;
using Blogesque.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Blogesque.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly AboutUsPageInfo _aboutUsPageInfo;

        public HomeController(IArticleService articleService, IOptions<AboutUsPageInfo> aboutUsPageInfo)
        {
            _articleService = articleService;
            _aboutUsPageInfo = aboutUsPageInfo.Value;
        }
        [HttpGet]
        public async Task<IActionResult> Index(int? categoryId, int currentPage = 1, int pageSize = 5, bool isAscending = false)
        {
            var articlesResult = await (categoryId == null
                ? _articleService.GetAllByPagingAsync(null, currentPage, pageSize, isAscending)
                : _articleService.GetAllByPagingAsync(categoryId.Value, currentPage, pageSize, isAscending));
            return View(articlesResult.Data);
        }
        [HttpGet]
        public async Task<IActionResult> About()
        {
            return View(_aboutUsPageInfo);
        }
    }
}
