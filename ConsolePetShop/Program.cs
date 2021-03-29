using PetClassLibrary;
using System;

namespace ConsolePetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory s = new Inventory();

            Console.WriteLine("Welocme to the pet shop. First you must create an inventory. Then you may add some pets to the shopping cart. Finally you may checkout which will give you a total value of the shopping cart.");

            int action = chooseAction();

            while( action != 0)
            {
                Console.WriteLine("you chose " + action);

                switch (action)
                {
                    //add item to inventoey
                    case 1:
                        Console.WriteLine("you chose to add a pet to the inventory");
                        String petType = "";
                        String petSpecies = "";
                        Decimal petPrice = 0;

                        Console.WriteLine("What is the pet type? dog, cat, fish etc.");
                        petType = Console.ReadLine();
                        Console.WriteLine("What is the " + petType + " species?");
                        petSpecies = Console.ReadLine();
                        Console.WriteLine("What is the price for a " + petSpecies + "?");
                        petPrice = int.Parse( Console.ReadLine());

                        Pet newPet = new Pet(petType, petSpecies, petPrice);
                        s.PetList.Add(newPet);

                        printPetList(s);
                        break;

                    //add pet to your order
                    case 2:
                        Console.WriteLine("You chose to add a pet to your order list");
                        printPetList(s);
                        Console.WriteLine("What would you like to buy? (number)");
                        int petChosen = int.Parse(Console.ReadLine());

                        s.OrderList.Add(s.PetList[petChosen]);

                        printOrderList(s);
                        break;

                    //checkout
                    case 3:
                        printOrderList(s);
                        Console.WriteLine("The total cost of your pets are: " + s.Checkout());
                        break;

                    default:
                        break;

                }
                action = chooseAction();
            }
           
        }

        private static void printOrderList(Inventory s)
        {
            Console.WriteLine("Pet you have chosen to buy");
            for (int i = 0; i < s.OrderList.Count; i++)
            {
                Console.WriteLine("Pet #" + i + " " + s.OrderList[i]);
            }
        }

        private static void printPetList(Inventory s)
        {
            for(int i = 0; i < s.PetList.Count; i++ )
            {
                Console.WriteLine("Pet #" + i + " " + s.PetList[i]);
            }
        }

        static public int chooseAction()
        {
            int choice = 0;
            Console.WriteLine("Choose an action: (0) to quit (1) to add a new pet to the inventory (2) add pet to order");

            choice = int.Parse(Console.ReadLine());
            return choice;

        }



    }
}
