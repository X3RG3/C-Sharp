using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLabTask
{
    internal class M
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            Console.WriteLine("Enter Inputs for Book 1: ");
            Console.Write("Enter Book ID : ");
            b1.setId(int.Parse(Console.ReadLine()));
            Console.Write("Enter Book Title: ");
            b1.setBookTitle(Console.ReadLine());

            Console.Write("Enter Author Name : ");
            b1.setAuthorName(Console.ReadLine());

            
            Console.Write("Enter Price : ");
            b1.setPrice(double.Parse(Console.ReadLine()));
            Console.Write("Enter Quantity : ");
            b1.setQuantity(int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter Inputs for Book 2: ");

            int ID, Quantity;
            string BookTitle, AuthorName;
            double Price;

            Console.Write("Enter Book ID : ");
            ID = int.Parse(Console.ReadLine());
            Console.Write("Enter Book Title: ");
            BookTitle = Console.ReadLine();

            Console.Write("Enter Author Name : ");
            AuthorName = Console.ReadLine();


            Console.Write("Enter Price : ");
            Price = double.Parse(Console.ReadLine());
            Console.Write("Enter Quantity : ");
            Quantity = int.Parse(Console.ReadLine());
            Book b2 = new Book(ID,BookTitle,AuthorName,Price,Quantity);
            Console.WriteLine("Details Before Adding or Selling : ");

            b1.ShowDetails();
            b2.ShowDetails();

            

            Console.Write("Add Books for b1 :");
            b1.addQuantity(int.Parse(Console.ReadLine()));

            b1.ShowDetails();

            Console.Write("Sell Books for b1 : ");
            b1.sellQuantity(int.Parse(Console.ReadLine()));

            b1.ShowDetails();

            Console.Write("Add Books for b2 :");
            b2.addQuantity(int.Parse(Console.ReadLine()));

            b2.ShowDetails();

            Console.Write("Sell Books for b2 : ");
            b2.sellQuantity(int.Parse(Console.ReadLine()));

            b2.ShowDetails();

            Console.WriteLine("Final Details After Adding or Selling : ");

            b1.ShowDetails();
            b2.ShowDetails();

            Console.ReadKey();

        }
    }
}
