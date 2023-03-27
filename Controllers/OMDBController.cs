
using Microsoft.AspNetCore.Mvc;
using Pizzas.API.Models;
using Pizzas.Api.Utils;

namespace Pizzas.API.Controllers;

[ApiController]
[Route("api/[Controller]")]

//https://www.omdbapi.com/?i={}&apikey=8005dd4

public class OMDBController : ControllerBase
{
   [HttpGet("movie/{imdbTitle)")]

    public IActionResult GetByImdbTitle(string ImdbTitle)
    {
        string apiResponse = HTTPHelper.ObtenerPorTitulo(ImdbTitle);

        return Ok(apiResponse);
    }


     [HttpGet("search")]

     public IActionResult GetByTerm([FromQuery] string term)
     {
        return Ok("El id enviado es:" + term);
     }

    /* string apiResponse = await HTTPHelper.GetContentAsync("https://omdbp.api.com/s=toy", null);
     returnValue = JsonSerializer.Deselialize<>(apiResponse);
     */
}