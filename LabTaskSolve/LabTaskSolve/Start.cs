using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTaskSolve
{
    internal class Start
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.SetIsbn("978-0001");
            b1.SetBookTitle("Atomic Habits");
            b1.SetAuthorName("James Clear");
            b1.setPrice(650);
            b1.SetAvailableQuantity(10);

            Book b2 = new Book("978-0002", "Clean Code", "Robert C. Martin", 1200, 4);

            Book b3 = new StoryBook();
            b3.SetIsbn("978-1001");
            b3.SetBookTitle("The Hobbit");
            b3.SetAuthorName("J.R.R. Tolkien");
            b3.setPrice(450);
            b3.SetAvailableQuantity(5);


            StoryBook b4 = new StoryBook("978-1002","Sherlock Holmes","Arthur Conan Doyle",380,3,"Mystery");

            Book[] inventory  = {b1,b2,b3,b4};

            foreach (var item in inventory) 
            {
                item.Showdetails();
            }

            b2.AddQuantity(5);
            b3.AddQuantity(-2);

            b1.SellQuantity(2);
            b3.SellQuantity(3);
            b4.SellQuantity(5);
            b4.SellQuantity(1);
            b2.SellQuantity(0);

            b1.setPrice(-100);
            b1.setPrice(700);

            foreach (var item in inventory)
            {
                item.Showdetails();
            }
            Console.ReadKey();
        }
    }
}
