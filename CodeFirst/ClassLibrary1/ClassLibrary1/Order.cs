using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public long TotalValue { get; set; }
        public System.DateTime Date { get; set; }
        public int CustomerCustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
