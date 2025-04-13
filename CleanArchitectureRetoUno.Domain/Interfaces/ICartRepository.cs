    using CleanArchitectureRetoUno.Domain.Entities;

    namespace CleanArchitectureRetoUno.Domain.Interfaces;
    
    public interface ICartRepository
    {
        Cart GetCartById(int id);
        List<Cart> GetCartAll();
    }