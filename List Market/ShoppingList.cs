using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseShoppingList
{
    public class ShoppingList
    {
            public string NameShoppingList;
            public string DateCreation;
            public int NumberItems;
            public decimal ValueTotalShoppingList;

            public void ShowShoppingList()
            {
                Console.WriteLine(NameShoppingList + "created in" + DateCreation);

            }
    }

    public class Item : ShoppingList
    {
        public string NameItem;
        public int QuantityItem;
        public decimal ValueItem;
        public decimal ValueTotalItem;
        public decimal ValueTotalShoppingList;
        public int TotalQtItemShoppingList;
        public bool ItemStatus = false;
        public void TotalItem()
        {
            ValueTotalItem = QuantityItem * ValueItem;
            Console.WriteLine(ValueTotalItem);
        }

        public void TotalShoppingList()
        {
            ValueTotalShoppingList += ValueTotalItem;
            Console.WriteLine(ValueTotalShoppingList);
        }

        public void QtItemShoppingList()
        {
            TotalQtItemShoppingList += QuantityItem;
            Console.WriteLine(TotalQtItemShoppingList);
        }

    }
}
