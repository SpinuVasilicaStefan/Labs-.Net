using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public partial class Customer
    {
       public Customer()
        {
            this.Order = new HashSet<Order>();
        }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}
