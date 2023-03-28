using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Pizzas.API.Models;
using Pizzas.Api.Utils;

namespace Pizzas.API.Controllers;

[ApiController]
[Route("api/[Controller]")]

//https://www.omdbapi.com/?i={}&apikey=8005dd4

// Get By Id http://localhost:5052/api/OMDB/movie/tt3530896 (PostMan)

public class OMDBController : ControllerBase
{
    [HttpGet("movie/{ImdbTitle}")]

    public async Task<IActionResult> GetByImdbTitle(string ImdbTitle)
    {
        string apiResponse = await HTTPHelper.ObtenerPorId(ImdbTitle);

        return Ok(apiResponse);
    }


/*
     [HttpGet("movieTitle/{titulo}")]

     public IActionResult ObtenerPorTitulo([FromQuery] string titulo)
     {
      string apiResponse = HTTPHelper.ObtenerPorId("https://www.omdbapi.com/?apikey=8005dd4&t=" + titulo);
        return Ok(apiResponse);
        
     }

    /* string apiResponse = await HTTPHelper.GetContentAsync("https://omdbp.api.com/s=toy", null);
     returnValue = JsonSerializer.Deselialize<>(apiResponse);
     */
}