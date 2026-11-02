using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLabTask
{
    internal class Book
    {
        private int id;
        private string BookTitle;
        private string authorName;
        private double price;
        private int quantity;
        public Book() 
        {
            Console.WriteLine("Default Constructor Created.");
        }

        public Book(int id, string bookTitle, string authorName, double price, int quantity)
        {
            this.id = id;
            BookTitle = bookTitle;
            this.authorName = authorName;
            this.price = price;
            this.quantity = quantity;
        }

        public void setId(int id)
        {
            this.id = id;
        }
        public void setBookTitle(string bookTitle)
        {
            this.BookTitle = bookTitle;
        }
        public void setAuthorName(string authorName)
        {
            this.authorName= authorName;
        }
        public void setPrice(double price)
        {
            this.price = price;
        }
        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }


        public void addQuantity(int amount)
        {
            this.quantity += amount;
        }
        public void sellQuantity(int amount) 
        { 
            this.quantity -= amount;
        }
        public void ShowDetails()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("Book ID : " + id);
            Console.WriteLine("Book Title : " + BookTitle);
            Console.WriteLine("Author Name : " + authorName);
            Console.WriteLine("Book Price : " + price);
            Console.WriteLine("Quantity: " + quantity);
        }


    }
}
