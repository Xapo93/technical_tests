using Microsoft.AspNetCore.Mvc;
using Telus.Api.Models;
using Telus.Api.Services;

namespace Telus.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class QuotesController : ControllerBase
{
    private readonly IQuoteService _quoteService;

    public QuotesController(IQuoteService quoteService)
    {
        _quoteService = quoteService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<QuoteModel>> GetAll() =>
        Ok(_quoteService.GetAll());

    [HttpGet("search")]
    public ActionResult<IEnumerable<QuoteModel>> Search([FromQuery] string q)
    {
        if (string.IsNullOrWhiteSpace(q))
            return BadRequest("Search term is required.");

        return Ok(_quoteService.Search(q));
    }

    [HttpGet("{id:int}")]
    public ActionResult<QuoteModel> GetById(int id)
    {
        var quote = _quoteService.GetById(id);
        return quote is null ? NotFound() : Ok(quote);
    }
}
