using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    public class Basket
    {
        private ArrayList products;
        private double totalPrice;
        public Basket() {
            products = new ArrayList();
            totalPrice = 0;
        }

        public void add(Product p)
        {
            products.Add(p);
            totalPrice += (p.getPrice() * p.getQuantity());
        }

        public int Size() { return  products.Count; }
    }
}
