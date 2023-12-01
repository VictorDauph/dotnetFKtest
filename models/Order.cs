using FKTest.dto;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FKTest.models
{
    [Index(nameof(OrderNumber), IsUnique = true)]
    public class Order
    {
        private Order() { }

        public Order(NewOrderDto dto) { 
        
            this.OrderNumber = dto.OrderNumber;
            this.CustomerId = dto.CustomerId;
        }
        public int Id { get; set; }

        public int OrderNumber { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
    }
}
