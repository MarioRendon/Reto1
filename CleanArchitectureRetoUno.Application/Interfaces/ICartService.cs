using CleanArchitectureRetoUno.Domain.Entities;

namespace CleanArchitectureRetoUno.Application.Interfaces
{
    public interface ICartService
    {
        Cart GetCartById(int id);
        List<Cart> GetCartAll();
    }
}