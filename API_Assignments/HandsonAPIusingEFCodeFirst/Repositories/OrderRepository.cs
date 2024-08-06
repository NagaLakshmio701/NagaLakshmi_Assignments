using HandsonAPIusingEFCodeFirst.Entities;

namespace HandsonAPIusingEFCodeFirst.Repositories
{
    public class OrderRepository: IOrderRepository
    {

        private readonly ECommContext _context;

        public OrderRepository()
        {
            _context = new ECommContext();
        }

        public List<Order> GetAllOrders(Guid OrderId)
        {
            return _context.Orders.ToList();
        }

        public Order GetOrder(Guid OrderId)
        {
          return   _context.Orders.SingleOrDefault(o=>o.OrderID == OrderId);

        }

        public void MakeOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }
    }
}
