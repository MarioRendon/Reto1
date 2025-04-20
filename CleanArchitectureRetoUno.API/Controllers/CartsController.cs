
using CleanArchitectureRetoUno.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace CleanArchitecture.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize] // Protege todo el controlador
    public class CartsController : ControllerBase
    {
        private readonly ICartService _cartService; 

        public CartsController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpGet("{id}")]
        public IActionResult GetCartById(int id)
        {
            var cart = _cartService.GetCartById(id);
            if (cart == null)
            {
                return NotFound();
            }
            return Ok(cart);
        }

         [HttpGet()]
        public IActionResult GetCartAll()
        {
            var carts = _cartService.GetCartAll();
           
            return Ok(carts);
        }

    }
}
