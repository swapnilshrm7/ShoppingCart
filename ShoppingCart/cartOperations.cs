using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ShoppingCart
{
    public class cartOperations : ICartOperations
    {
        CartItem buy = new CartItem();
        public void ShowAllCartItems()
        {
            //iterate through list and display items
            int serialNo = 1;
            if (buy.cartItems.Count==0)
            {
                Console.WriteLine("Cart Empty!");
            }
            else
            {
                foreach (var item in buy.cartItems)
                {
                    Console.WriteLine("serial no. : {4} Id : {0} Name : {1} Price : {2} Quantity : {3}\n", item.id, item.name, item.price, item.quantity, serialNo);
                    serialNo++;
                }
            }
        }
        public void AddItem(ItemDetails ItemToBeAdded,int quantity)
        {
            var CheckIfItemExist = buy.cartItems.Find(x => x.id == ItemToBeAdded.id);
            if (CheckIfItemExist == null)
            {
                ItemToBeAdded.quantity = quantity;
                buy.cartItems.Add(ItemToBeAdded);
            }
            else
            {
                buy.cartItems.Remove(CheckIfItemExist);
                CheckIfItemExist.quantity += quantity;
                buy.cartItems.Add(CheckIfItemExist);
            }
        }
        public void RemoveItem(int id, int quantity)
        {
            var ItemToBeRemoved = buy.cartItems.Find(x => x.id == id);
            if (ItemToBeRemoved != null)
            {
                buy.cartItems.Remove(ItemToBeRemoved);
                if (ItemToBeRemoved.quantity - quantity > 0)
                {
                    ItemToBeRemoved.quantity = ItemToBeRemoved.quantity - quantity;
                    AddItem(ItemToBeRemoved, ItemToBeRemoved.quantity);
                }
            }
            else
            {
                Console.WriteLine("Item not found");
            }
        }
        public int DisplayTotal()
        {
            //iterate through cart items and add their amounts
            int total = 0;
            foreach (var item in buy.cartItems)
            {
                total += item.price * item.quantity;
            }
                return total;
        }
        public void Clear()
        {
            buy.cartItems.Clear();
        }
    }
}
