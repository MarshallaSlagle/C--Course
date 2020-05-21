//Marshall Slagle
//Created: 4/3/20
//Modified for Assignment 3: 4/14/20
//Modified for Assignment 4: 4/23/20
using System;
using System.Collections.Generic;

namespace A2_SlagleMarshall
{
    public class Library
    {
        List<Customer> customerArray = new List<Customer>();
        List<Book> bookArray = new List<Book>();


        public bool RenewBook(int bookCatalogNum)
        {
            bool result = false;

            for (int i = 0; i < this.bookArray.Count; i++)
            {
                if (this.bookArray[i] != null && this.bookArray[i].CatalogNumber == bookCatalogNum && this.bookArray[i] is TextBook)
                {
                    TextBook  t = (TextBook) this.bookArray[i];
                    result = t.Renew();
                    return result;
                }
            }

            return result;
        }


        public void AddNewCustomer(String customerName)
        {
            customerArray.Add(new Customer(customerName, customerArray.Count+1));
        }

        public void AddNewBook(string bookTitle, String bookAuthor)
        {
           bookArray.Add(new GeneralBook(bookTitle, bookAuthor, (100 + (bookArray.Count + 1))));
        }

        public void AddNewBook(string bookTitle, String bookAuthor, int edition)
        {
            bookArray.Add(new TextBook(bookTitle, bookAuthor, (100 + (bookArray.Count + 1)), edition));
        }

        public bool IssueBook(int custId, int bookCatalogNum)
        {
            bool result = false;
            

            for (int i = 0; i < this.bookArray.Count; i++)
            {
                if (this.bookArray[i] != null && this.bookArray[i].CatalogNumber == bookCatalogNum)
                {
                    for (int j = 0; j < this.customerArray.Count; j++)
                    {
                        if (this.customerArray[j] != null && this.customerArray[j].Id == custId)
                        {
                            result = this.bookArray[i].CheckOut(this.customerArray[j]);
                            return result;
                        }
                    }
                }
            }

            return result;
        }

        public bool ReturnBook(int bookCatalogNum)
        {
            bool result = false;

            for (int i = 0; i < this.bookArray.Count; i++)
            {
                if (this.bookArray[i] != null && this.bookArray[i].CatalogNumber == bookCatalogNum)
                {
                    result = this.bookArray[i].CheckIn();
                    return result;
                }
            }

            return result;
        }

        public Library()
        {
        }

        public override string ToString()
        {
            string result = "";

            for (int i = 0; i < customerArray.Count; i++)
            {
                if (customerArray[i] != null)
                {
                    result = result + customerArray[i].ToString() + "\n";
                }
                if (i == (customerArray.Count - 1))
                {
                    result = result + "\n";
                }
            }

            for (int i = 0; i < bookArray.Count; i++)
            {
                if (bookArray[i] != null)
                {
                    result = result + bookArray[i].ToString() + "\n";
                }
            }

            return result;
        }
    }
}
