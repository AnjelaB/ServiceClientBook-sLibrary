using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace BookLibrary
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    class BookService : IBooksService
    {
        List<Book> booksLibrary;
        int booksId;
        
        BookService()
        {
            booksLibrary = new List<Book>();
            booksId = 0;
        }
        public void Add(string auther,string title,double price,int  year)
        {
            foreach(var book in booksLibrary)
            {
                if(book.Auther == auther && book.Title == title && book.Year == year)
                {
                    return;
                } 
            }
            booksId++;
            booksLibrary.Add(new Book
            {
                Id = booksId,
                Auther = auther,
                Title = title,
                Price = price,
                Year = year
            });
        }

        public IEnumerable<Book> GetListOfBooks()
        {
            return booksLibrary;
        }

        public void UpdatePrice(double newPrice, int id)
        {
            foreach(var book in booksLibrary)
            {
                if (book.Id == id)
                {
                    book.Price = newPrice;
                    break;
                }
            }
        }

    }
}
