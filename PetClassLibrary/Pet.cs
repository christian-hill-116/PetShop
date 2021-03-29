using System;

namespace PetClassLibrary
{
    public class Pet
    {
        public string Species { get; set; }
        public string  Type { get; set; }
        public decimal Price { get; set; }

        public Pet()
        {
            Species = "unknown";
            Type = "unknown";
            Price = 0.00M; 
        } 

        public Pet(string a, string b, decimal c)
        {
            Species = a;
            Type = b;
            Price = c;
        }

        override public string ToString()
        {
            return "Species: " + Species + " Type: " + Type + " Price : $" + Price; 
        }
    }
}
