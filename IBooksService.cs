using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;
namespace BookLibrary
{
    [ServiceContract]
    interface IBooksService
    {
        [OperationContract]
        IEnumerable<Book> GetListOfBooks();
        [OperationContract]
        void UpdatePrice(double newPrice,int id);
        [OperationContract]
        void Add(string auther, string title, double price, int year);
    }
}
