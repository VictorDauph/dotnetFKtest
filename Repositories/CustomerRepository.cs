using FKTest.Context;
using System.Linq;
using FKTest.models;

namespace FKTest.Repositories
{
    public class CustomerRepository<Customer> where Customer : class
    {
        DataContext _dataContext = new DataContext();

        public void Add(Customer customer)
        {
            _dataContext.Add(customer);
            _dataContext.SaveChanges();
        }

        public IQueryable<Customer> GetAll()
        {
            return _dataContext.Set<Customer>();
        }

        public Customer? Get(int id)
        {
            Customer? customerQuery = _dataContext.Find<Customer>(id);


            return customerQuery;
        }



        public void update(Customer customer)
        {
            _dataContext.Update(customer);
            _dataContext.SaveChanges();
        }

        public void delete(int id)
        {
            Customer? customer = _dataContext.Find<Customer>(id);
            if (customer != null)
            {
                _dataContext.Remove(customer);
                _dataContext.SaveChanges();
            }
            
        }
    }
}
