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

        public void remove(int index)
        {
            totalPrice -= ((products[index] as Product).getPrice() * (products[index] as Product).getQuantity());
            products.RemoveAt(index);

            Console.WriteLine("REMOVE SIZE: " + Size().ToString());
        }
            
        public void clear()
        {
            products.Clear();
            totalPrice = 0;
        }

        public int Size() { return  products.Count; }
        public double getTotalPrice() { return totalPrice;}
        public ArrayList getProducts() { return products;}
    }
}
