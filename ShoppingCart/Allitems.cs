using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ShoppingCart
{
    public class Inventory
    {
        public List<ItemDetails> AllItems = new List<ItemDetails>()
            {
            new ItemDetails {id=1,name="chips",price=40,brand="lays",quantity=10},
            new ItemDetails {id=2,name="biscuits",price=80,brand="britania",quantity=12},
            new ItemDetails {id=3,name="butter",price=130,brand="amul",quantity=17},
            new ItemDetails {id=4,name="icecream",price=40,brand="Dinshaws",quantity=31},
            new ItemDetails {id=5,name="cream",price=80,brand="nivia",quantity=23},
            new ItemDetails {id=6,name="dairymilk",price=130,brand="cadbury",quantity=18},
            new ItemDetails {id=7,name="bournvita",price=40,brand="cadbury",quantity=31},
            new ItemDetails {id=8,name="cool",price=80,brand="amul",quantity=23},
            new ItemDetails {id=9,name="chips",price=130,brand="uncle chips",quantity=18}
            };
    }
}
