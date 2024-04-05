using LibraryAPI.Models.Requests;
using LibraryAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase
{
    private readonly IBookService _service;
    
    public BooksController(IBookService service)
    {
        _service = service;
    }

    [HttpGet("{filter}/{value}")]
    public async Task<IActionResult> GetAsync([FromRoute] Filter filter, string value)
    {
        var request = new GetBooksByParamsRequest() {Filter = filter, Value = value};
        var response = await _service.GetBooksByParams(request);

        return Ok(response);
    }
}