using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P224Juan.ViewModels.Basket
{
    public class BasketVM
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public double DiscountPrice { get; set; }
        public string Image { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
    }
}
