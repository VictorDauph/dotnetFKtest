using FKTest.dto;
using FKTest.models;
using FKTest.Repositories;

namespace FKTest.Services
{
    public class OrderService
    {

        CustomerRepository<Customer> _customerRepository = new CustomerRepository<Customer>();
        OrderRepository<Order> _orderRepository = new OrderRepository<Order>();

        public void addOrder(NewOrderDto orderDto)
        {
            Customer? customer =_customerRepository.Get(orderDto.CustomerId);
            if (customer == null) {
                throw new Exception("customer not found");
            }
            else
            {
                Order order = new Order(orderDto);
                _orderRepository.Add(order);
            }
        }

        public Order GetOrder(int orderId)
        {
            Order? order = _orderRepository.Get(orderId);


            if(order == null)
            {
                throw new Exception("order not found");
            }
            else
            {
                this.addCustomer(order);
            }

            return order;
        }

        private void addCustomer(Order order)
        {
            Customer? customer= _customerRepository.Get(order.CustomerId);
            if (customer == null)
            {
                throw new Exception("customer not found");
            }
            else
            {
                order.Customer = customer;
            }
        }


    }
}
