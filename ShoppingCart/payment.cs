using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ShoppingCart
{
    public class Pay
    {
        public void COD(List<ItemDetails> Items)
        {
            //implement COD functionality
            Console.WriteLine("Pay By cash when item arrives....\n\n\n Order successfully placed!");
        }
        public void OnlinePayment(List<ItemDetails> Items)
        {
            //implement Online payment functionality
            Console.WriteLine("\nPlease Wait.....\n\n connecting to payment gateway....");
        }
    }
}
