using CleanArchitectureRetoUno.Application.Interfaces;
using CleanArchitectureRetoUno.Domain.Entities;
using CleanArchitectureRetoUno.Domain.Interfaces;

namespace CleanArchitectureRetoUno.Application.Services
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;
        public CartService(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public Cart GetCartById(int id)
        {
            return _cartRepository.GetCartById(id);
        }

        public List<Cart> GetCartAll()
        {
            return _cartRepository.GetCartAll();
        }
    }
}