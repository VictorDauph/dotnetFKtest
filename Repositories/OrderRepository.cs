using FKTest.Context;
using FKTest.models;

namespace FKTest.Repositories
{
    public class OrderRepository<Order> where Order : class
    {
        DataContext _dataContext = new DataContext();

        public void Add(Order order)
        {
            _dataContext.Add(order);
            _dataContext.SaveChanges();
        }

        public IQueryable<Order> GetAll()
        {
            return _dataContext.Set<Order>();
        }

        public Order? Get(int id)
        {
            Order? customerQuery = _dataContext.Find<Order>(id);


            return customerQuery;
        }

        public void update(Order order)
        {
            _dataContext.Update(order);
            _dataContext.SaveChanges();
        }

        public void delete(int id)
        {
            Order? order = _dataContext.Find<Order>(id);
            if (order != null)
            {
                _dataContext.Remove(order);
                _dataContext.SaveChanges();
            }

        }
    }
}
