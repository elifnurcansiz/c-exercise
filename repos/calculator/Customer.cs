using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    public  class Customer

    {
        public int Id;
        public string name;
        public List<Order> orders;
        public Customer(int id)
        {
            this.Id = id;
        }
        public Customer(int id,string name )
            :this(id)
        {

        }
    }
    public class Order
    {

    }
}
