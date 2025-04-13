// CleanArchitecture.Infrastructure/Repositories/ProductRepository.cs
using CleanArchitectureRetoUno.Domain.Entities;
using CleanArchitectureRetoUno.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CleanArchitectureRetoUno.Infrastructure.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly List<Cart> _cart = new ()
        {
            new Cart { Id = 1, Name = "Carro 1", Price = 10.0m,brand="Cherovlet" },
            new Cart { Id = 2, Name = "Carro 2", Price = 20.0m,brand="Renault" }
        };

        public Cart GetCartById(int id)
        {
            return _cart.FirstOrDefault(p => p.Id == id);
        }

        public List<Cart> GetCartAll()
        {
           return _cart.ToList();
        }
    }
}
