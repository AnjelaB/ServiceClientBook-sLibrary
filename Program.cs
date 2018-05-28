using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {

 
            Uri baseAddress = new Uri("http://localhost:3000/BookLib/");

            using (ServiceHost host = new ServiceHost(typeof(BookService), baseAddress))
            {
                host.AddServiceEndpoint(typeof(IBooksService), new WSHttpBinding(), "BookService");
                ServiceMetadataBehavior serviceMetadataBehavior = new ServiceMetadataBehavior();
                serviceMetadataBehavior.HttpGetEnabled = true;
                host.Description.Behaviors.Add(serviceMetadataBehavior);
                host.Open();
                Console.WriteLine("The service is ready.");
                Console.ReadLine();

            }
        }
    }
}
