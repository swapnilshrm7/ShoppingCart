using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    interface ICartOperations
    {
       void ShowAllCartItems();
       void AddItem(ItemDetails ItemToBeAdded, int quantity);
       void RemoveItem(int id, int quantity);
       int DisplayTotal();
       void Clear();
    }
}
