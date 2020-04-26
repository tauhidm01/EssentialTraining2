using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining
{
    public class SimpleArray 
    {
        public string[] GroceryList;// Instance variable called 'GroceryList' and its a tring array 
        // but hasn't been intialised to a anyything yet

        public SimpleArray() // constructor for my class
        {
            GroceryList = new string[4] { "Bread", "Milk", "Eggs", "Cheese" };
        }

        public override string ToString() // overriding 'ToString' method
        {
            return "There are " + GroceryList.Length + " and they are: " + GroceryList.ToString();
        }

    }
}
