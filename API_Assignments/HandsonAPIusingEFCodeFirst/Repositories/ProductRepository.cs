using HandsonAPIusingEFCodeFirst.Entities;

namespace HandsonAPIusingEFCodeFirst.Repositories

{
    public class ProductRepository:IProductRepository
    {
        private readonly ECommContext _context;

        public ProductRepository()
        {
            _context = new ECommContext ();
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public Product GetProduct(int id)
        {
            return _context.Products.SingleOrDefault(x => x.ProductId  == id);
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public void UpdateProduct(Product product)
        {
           _context.Products.Update(product);
            _context.SaveChanges();
            
        }

        public void Delete(int id)
        {
           var Produtc= _context.Products.Find(id);
            _context.Products.Remove(Produtc);

            _context.SaveChanges();


        }
    }


}
