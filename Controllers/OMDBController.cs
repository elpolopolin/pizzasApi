// http://www.omdbapi.com/?i=tt3896198&apikey=8005dd4
using Microsoft.AspNetCore.Mvc;
using Pizzas.API.Models;
using Pizzas.Api.Utils;
namespace Pizzas.API.Controllers;

[Apicontroller]
[Route("api/[controller]")]

public class OMDBController : ControllerBase
{
    [httpGet("movie/{imdbId)")]

    public IActionResult GetByImdbId(string ImdbID)
    {
        return OK("El id enviado es:" + ImdbID);
    }


     [httpGet(search)]

     public IActionResult GetByTerm([FromQUery] string term)
     {
        return OK("El id enviado es:" + term);
     }

     string apiResponse = await HTTPHelper.GetContentAsync("https://omdbp.api.com/s=toy", null);
     returnValue = JsonSerializer.Deselialize<....>(apiResponse);
}