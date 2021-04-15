using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    /* property in yanında kare varsa snippet denir 
    tab yapınca kod açılır*/
    class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int CategoryId { get; set; }
        public int UnitsInStock { get; set; }
    }
}
