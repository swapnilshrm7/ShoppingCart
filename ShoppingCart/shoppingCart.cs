using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ShoppingCart
{
    class Shopping
    {
        public static void Main(string[] args)
        {
            Initializer shop = new Initializer();
            ICartOperations sample = shop.GetCartOperations();
            Inventory allItems = new Inventory();
            int choice = 0;
            while (choice != 6)
            {
                Console.WriteLine("enter your choice : \n\n 1:Show items in cart \n 2:Add item to cart \n 3:Remove item from cart \n 4:Display cart value \n 5:clear cart \n 6:Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    sample.ShowAllCartItems();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("enter id of item to be added :");
                    int choiceOfItem = Convert.ToInt32(Console.ReadLine());
                    var ItemToBeAdded = allItems.AllItems.Find(xy => xy.id == choiceOfItem);
                    Console.WriteLine("enter quantity of item to be added :");
                    int quantity= Convert.ToInt32(Console.ReadLine());
                    if (ItemToBeAdded != null)
                        sample.AddItem(ItemToBeAdded,quantity);
                    else
                        Console.WriteLine("NO MATCH FOUND");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("enter id of item to be removed and its quantity:");
                    int choiceOfItem = Convert.ToInt32(Console.ReadLine());
                    int qnt = Convert.ToInt32(Console.ReadLine());
                    sample.RemoveItem(choiceOfItem, qnt);
                }
                else if (choice == 4)
                {
                    int total = sample.DisplayTotal();
                    Console.WriteLine("Base price : {0} \n GST @ 4% : {1} \n ------------\n Total Amount : {2}", total, total * 0.04, total * 1.04);
                }
                else if (choice == 5)
                {
                    sample.Clear();
                }
                else if(choice==6)
                {

                }
                else
                {
                    Console.WriteLine("Invalid input !!");
                }
            }
        }
    }
}