using System;
using System.Collections.Generic;
using System.Text;

namespace PetClassLibrary
{
    public class Inventory
    {
        public List<Pet> PetList { get; set; }

        public List<Pet> OrderList { get; set; }

        public Inventory()
        {
            PetList = new List<Pet>();
            OrderList = new List<Pet>();
        }

        public decimal Checkout()
        {
            //init total cost
            decimal totalCost = 0;

            foreach(var c in OrderList)
            {
                totalCost += c.Price;
            }

            OrderList.Clear();
            return totalCost;
        }
    }
}
