using HandsonAPIusingEFCodeFirst.Entities;

namespace HandsonAPIusingEFCodeFirst.Repositories
{
    public interface IProductRepository
    {
        void Add(Product product);

        Product GetProduct(int id);

        List<Product> GetAllProducts();

        void Delete(int id);    

        void UpdateProduct(Product product);

    
    }
}
