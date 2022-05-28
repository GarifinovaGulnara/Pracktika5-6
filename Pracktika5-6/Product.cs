using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracktika5_6
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }
        public bool Topical { get; set; }
        public int InStock { get; set; }

        public Product(int id, string name, string description, string manufacturer, int price, bool topical, int inStock)
        {
            Name = name;
            Description = description;
            Manufacturer = manufacturer;
            Price = price;
            Topical = topical;
            InStock = inStock;
            Id = id;
        }

        public override string ToString()
        {
            return $"{Id}) {Name} {Description} {Manufacturer} {Price} {Topical} {InStock}";
        }
    }
}
