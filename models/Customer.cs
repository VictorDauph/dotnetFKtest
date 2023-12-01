using System.ComponentModel.DataAnnotations.Schema;

namespace FKTest.models
{
    public class Customer
    {
        public Customer(string Name) {
            this.Name = Name;
        }
        public int Id { get; set; }

        public string Name { get; set; } = null!;
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
