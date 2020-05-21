//Marshall Slagle
//Created: 4/3/20
//Modified for Assignment 3: 4/14/20
//Modified for Assignment 4: 4/23/20
using System;
namespace A2_SlagleMarshall
{
    public class Customer
    {
        private int id;
        private string name;

        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Customer(string name, int id)
        {
            this.id = id; this.name = name;
        }

        public override string ToString()
        {
            return String.Format("{0,-5}{1,-10}", id, name);
        }
    }
}
