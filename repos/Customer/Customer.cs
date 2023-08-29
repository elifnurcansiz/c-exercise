using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    public class Customer : CustomerBase1
    {
        public int Id;
        public string Name;
        private int id;

        public Customer()
        {

        }
        public Customer(int id)
        {
            this.id = id;


        }
        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;

        }
    }
}