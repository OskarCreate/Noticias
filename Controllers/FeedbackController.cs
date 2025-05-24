using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Noticias.Data;


namespace Noticias.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeedbackController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

    public FeedbackController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Feedback>> Get() => _context.Feedbacks.ToList();

    [HttpPost]
    public async Task<IActionResult> Post(Feedback feedback)
    {
        var yaExiste = _context.Feedbacks.Any(f => f.PostId == feedback.PostId);
        if (yaExiste) return BadRequest("Ya existe feedback para este post.");

        _context.Feedbacks.Add(feedback);
        await _context.SaveChangesAsync();
        return Ok(feedback);
    }
        
    }
}