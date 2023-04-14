
//using System means that we can use classes from the System namespace.
//using System;
//using System.Runtime.InteropServices;

////namespace is used to organize your code, and it is a container for classes and other namespaces.
//namespace HelloWorld

////The curly braces { } marks the beginning and the end of a block of code.
//{
//    //class is a container for data and methods, which brings functionality to your program.Every line of code that runs in C# must be inside a class.
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Console is a class of the System namespace, which has a WriteLine() method that is used to output/print text.
//            Console.WriteLine("Hello World");
//        }
//    }
//}


using System;

namespace ExerciseShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingList ShoppingList1 = new ShoppingList();
            ShoppingList1.NameShoppingList = "ShoppingList Supermarket";
            ShoppingList1.DateCreation = "2023-04-10";
            ShoppingList1.NumberItems = 3;

            Item item1 = new Item();
            item1.NameShoppingList = "ShoppingList Supermarket";
            item1.NameItem = "Cookies";
            item1.QuantityItem = 2;
            item1.ValueItem = 5;

            Item item2 = new Item();
            item2.NameShoppingList = "ShoppingList Supermarket";
            item2.NameItem = "Orange Juice";
            item2.QuantityItem = 6;
            item2.ValueItem = 3;

            Item item3 = new Item();
            item3.NameShoppingList = "ShoppingList Supermarket";
            item3.NameItem = "Pizza";
            item3.QuantityItem = 2;
            item3.ValueItem = 8;

        }
    }

}