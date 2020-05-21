//Marshall Slagle
//Created: 4/3/20
//Modified for Assignment 3: 4/14/20
//Modified for Assignment 4: 4/23/20
using System;
namespace A2_SlagleMarshall
{
    public abstract class Book
    {
        private int catalogNumber;
        private string title;
        private string authors;
        protected Customer c;
        protected DateTime dueDate;


        public abstract DateTime findDueDate();

        public int CatalogNumber
        {
            get{ return catalogNumber; }
        }


        public bool CheckOut(Customer c)
        {
            if (this.c != null)
            {
                return false;
            }
            else
            {
                this.c = c;
                this.dueDate = DateTime.Now;
                this.dueDate = findDueDate();
                return true;
            }
        }

        public bool CheckIn()
        {
            if (this.c != null)
            {
                this.c = null;
                return true;
            }
            else
            {
                return false;
            }
        }


        public override string ToString()
        {
            if (this.c == null)
            {
                return String.Format("{0,-6}{1,-20}{2,-16}{3,-26}{4,-30}", this.catalogNumber, this.title, this.authors, "Available", "");
            }
            else
            {
                return String.Format("{0,-6}{1,-20}{2,-16}{3,-26}{4,-30}", this.catalogNumber, this.title, this.authors,"Checked out to Customer " + this.c.Id, "Due on " + this.dueDate);
            }
        }

        public Book(string title, string authors, int catalogNo)
        {
            this.title = title;
            this.authors = authors;
            this.catalogNumber = catalogNo;
        }

        public Book()
        {
           
        }
    }
}
