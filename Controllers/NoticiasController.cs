using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Noticias.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Noticias.Controllers
{
    [Route("[controller]")]
    public class NoticiasController : Controller
    {
        private readonly ILogger<NoticiasController> _logger;
        private readonly NoticiasService _noticiasService;

        public NoticiasController(ILogger<NoticiasController> logger, NoticiasService noticiasService)
        {
            _logger = logger;
            _noticiasService = noticiasService;
        }

        [HttpGet]
        [Route("")]
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            List<Post> posts = await _noticiasService.ObtenerPosts();
            return View(posts); // Pasamos la lista directamente como modelo
        }
    }
}
