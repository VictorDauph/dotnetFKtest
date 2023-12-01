using FKTest.Context;
using FKTest.dto;
using FKTest.models;
using FKTest.Repositories;
using FKTest.Services;
using Microsoft.AspNetCore.Mvc;

namespace FKTest.Controllers
{
    public class GenericController : ControllerBase
    {
        DataContext _dataContext = new DataContext();
        CustomerRepository<Customer> customerRepository = new CustomerRepository<Customer>();
        OrderService orderService = new OrderService();

        [HttpPost("/newCustomer")]
        public void newCustomer(NewCustomerDto dto)
        {
            Customer customer = new Customer(dto.Name);

            customerRepository.Add(customer);
        }

        [HttpGet("/customer/{id}")]
        public Customer? GetCustomer(int id)
        {
            IEnumerable<Customer> customerQuery = from customer in _dataContext.Customers
                                                  where customer.Id == id
                                                  select customer;

            Customer? result = customerQuery.FirstOrDefault();

            return result;
        }

        [HttpPost("/newOrder")]
        public void newOrder(NewOrderDto dto)
        {
            orderService.addOrder(dto);
        }

        [HttpGet("/order/{id}")]
        public Order GetOrder(int id) {
            return orderService.GetOrder(id);
        }
    }
}
