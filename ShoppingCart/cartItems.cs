using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ShoppingCart
{
    public class CartItem
    {
        public List<ItemDetails> cartItems = new List<ItemDetails>()
        {
            new ItemDetails {id=1,name="chips",price=40,brand="lays",quantity=1},
            new ItemDetails {id=2,name="biscuits",price=80,brand="britania",quantity=2},
            new ItemDetails {id=3,name="butter",price=130,brand="amul",quantity=1}
        };
    }
}
