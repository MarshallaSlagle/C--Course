//Marshall Slagle
//Created: 4/3/20
//Modified for Assignment 3: 4/14/20
//Modified for Assignment 4: 4/23/20
using System;
namespace A2_SlagleMarshall
{
    public class TextBook: Book, IRenewable
    {
        private int edition;

        public bool Renew()
        {
            if (this.c == null)
            {
                return false;
            }
            else
            {
                this.dueDate = this.dueDate.AddDays(15.00);
                return true;
            }
        }

        public override DateTime findDueDate()
        {
            return (this.dueDate.AddDays(30.00));
        }

        public TextBook(string title, string authors, int catalogNo, int edition): base(title, authors, catalogNo)
        {
            this.edition = edition;
        }

        public override string ToString()
        {
            return (base.ToString() + string.Format("{0,-10}{1,-20}", "", "Edition: " + this.edition));
        }
    }
}
