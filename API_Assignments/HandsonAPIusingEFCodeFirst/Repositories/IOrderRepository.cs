using HandsonAPIusingEFCodeFirst.Entities;
namespace HandsonAPIusingEFCodeFirst.Repositories

{
    public interface IOrderRepository
    {
        void MakeOrder(Order order);
        Order GetOrder(Guid  OrderId);

        List<Order> GetAllOrders(Guid OrderId);




    }
}
