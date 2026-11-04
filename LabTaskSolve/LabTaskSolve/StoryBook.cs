using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTaskSolve
{
    internal class StoryBook : Book
    {
        private string category;
        public StoryBook() 
        {
            Console.WriteLine("Default storyBook Constructor Called");
        }
        public StoryBook(string isbn, string bookTitle, string authorName, double price, int availableQuantity,string category) :base(isbn,bookTitle,authorName,price,availableQuantity)
        {
            this.category = category;
        }

        public void SetCategory(string category) 
        {
            this.category=category;
        }
        public string GetCategory() 
        {
            return this.category;
        }

        public override void SellQuantity(int amount)
        {
            int quantity = base.GetAvailableQuantity();
            quantity -= amount;
            base.SellQuantity(quantity);
            if (quantity<3)
            {
                Console.WriteLine("LOW STOCK ALERT : " + GetBookTitle()+"["+category+"] only "+GetAvailableQuantity()+"left!");
            }
        }

        public override void Showdetails()
        {
            Console.WriteLine("-------- Story Book Details --------");
            base.Showdetails();
            Console.WriteLine("Category : " + category);

        }

    }
}
