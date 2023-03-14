using Microsoft.AspNetCore.Mvc;

using Pizzas.API.Models;

namespace Pizzas.API.Controllers {

[ApiController]
[Route ("api/[Controller]")]
 public class PizzasController : ControllerBase {
    [HttpGet]
    public IActionResult GetAll() 

     [HttpGet("{Id}") ]
     public IActionResult GetById(int Id)


    

 }

}


