using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
     public class ClientData
    {
        public static readonly List<Client> clients = new List<Client>()
        {
            new Client()
            {
                Id = 1, 
                Name = "Mark", 
                City = "Tallinn"
            },
            new Client()
            {
                Id = 2, 
                Name = "Anna", 
                City = "Tartu"
            },
            new Client()
            {
                Id = 3, 
                Name = "John", 
                City = "Tallinn"
            },
            new Client()
            {
                Id = 4, 
                Name = "Maria", 
                City = "Narva"
            },
            new Client()
            {
                Id = 5, 
                Name = "Karl", 
                City = "Pärnu"
            },
        };

    }
}
