using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTaskSolve
{
    internal class Book
    {
        private string isbn;
        private string bookTitle;
        private string authorName;
        private double price;
        private int availableQuantity;

        public Book()
        {
            Console.WriteLine("Default Book Constructor Called.");
        }
        public Book(string isbn,string bookTitle,string authorName,double price,int availableQuantity){
            this.isbn =isbn;
            this.bookTitle =bookTitle;
            this.authorName =authorName;
            this.price =price;
            this.availableQuantity =availableQuantity;
        }

        public void SetIsbn(string isbn) 
        {  
            this.isbn =isbn;
        }
        public void SetBookTitle(string bookTitle) 
        {  
            this.bookTitle =bookTitle;
        }
        public void SetAuthorName(string authorName) 
        {  
            this.authorName =authorName;
        }
        public void setPrice(double price) 
        {
            if(price < 0) {
                Console.WriteLine("Price Rejected.");
                return; }
            else
            {
                this.price = price;
            }
             
        }
        public void SetAvailableQuantity(int availableQuantity) 
        {  
            this.availableQuantity = availableQuantity; 
        }

        public string GetIsbn()
        {
            return this.isbn;
        }

        public string GetBookTitle()
        {
            return this.bookTitle;
        }

        public string GetAuthorName()
        {
            return this.authorName;
        }

        public double GetPrice()
        {
            return this.price;
        }

        public int GetAvailableQuantity()
        {
            return this.availableQuantity;
        }

        public void AddQuantity(int amount)
        {
            if (amount > 0)
            {
                this.availableQuantity += amount;
            }
            else
            {
                Console.WriteLine("Invalid Amount");
            }
        }

        public virtual void SellQuantity(int amount) 
        {
            if (amount <=0)
            {
                Console.WriteLine("Invalid amount");
                return;
            }
            if(amount > this.availableQuantity)
            {
                Console.WriteLine("Insufficient stock for " + this.bookTitle);
            }
            else
            {
                this.availableQuantity -= amount;
                Console.WriteLine(amount + " copy/copies of " + this.bookTitle + " sold. Remaining : " + this.availableQuantity);
            }

        }

        public virtual void Showdetails()
        {
            Console.WriteLine("-------- Book Details --------");
            Console.WriteLine("ISBN : " + isbn);
            Console.WriteLine("Title : " + bookTitle);
            Console.WriteLine("Author : " + authorName);
            Console.WriteLine("Price : " + price);
            Console.WriteLine("available Quantity : " + availableQuantity);
        }

    }
}
