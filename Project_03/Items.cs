//Michael Carroll
//April 2021
//Program.cs
//Project 3

using System;
using System.Collections.Generic;
using System.Text;

namespace Project_03
{
    public class Items
    {
        //----Data Members----//
        private bool hasItem; // this will be true if the user has a given item
        private string itemName; //name of the item
        
        //----Constructor----//
        public Items(string newItemName)
        {
            //user starts with no items
            hasItem = false;
            itemName = newItemName;
        }

        //----Properties----//
        public bool HasItem
        {
            //getter/setter for each item
            get { return hasItem; }
            set { hasItem = value; }
        }
       

        //----Other Methods----//
        public override string ToString()
        {
            //write the name of the item
            return itemName;
        }
    }
}
