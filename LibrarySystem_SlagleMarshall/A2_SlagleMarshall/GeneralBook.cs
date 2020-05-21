//Marshall Slagle
//Created: 4/3/20
//Modified for Assignment 3: 4/14/20
//Modified for Assignment 4: 4/23/20
using System;
namespace A2_SlagleMarshall
{
    public class GeneralBook: Book
    {
        public override DateTime findDueDate()
        {
            this.dueDate = DateTime.Now;
            return (this.dueDate.AddDays(7.00));
        }

        public GeneralBook(string title, string authors, int catalogNo) : base(title, authors, catalogNo)
        {
        }
    }
}
