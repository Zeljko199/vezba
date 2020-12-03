using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    class MenuItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public MenuItem(int id, string title, string description, double price)
        {
            Id = id;
            Title = title;
            Description = description;
            Price = price;
        }
    }
}
