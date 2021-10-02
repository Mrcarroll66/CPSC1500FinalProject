//Michael Carroll
//April 2021
//ComplexRoom.cs
//Project 3

using System;
using System.Collections.Generic;
using System.Text;

namespace Project_03
{
    public class ComplexRoom : Room
    {
        //----Data Members----//
        private int inDoor; //in door index
        private int outDoor; //out door index
        private int upDoor; //up door index
        private int downDoor; //down door index

        //----Parameterized Constructor----//
        public ComplexRoom(string name, string description,
            int nDoor, int sDoor, int eDoor, int wDoor,
            int nInDoor, int nOutDoor, int nUpDoor, int nDownDoor) : 
            base(name, description, nDoor, sDoor, eDoor, wDoor)

        {
            //get values from the program.cs
            inDoor = nInDoor;
            outDoor = nOutDoor;
            upDoor = nUpDoor;
            downDoor = nDownDoor;
        }

        //----Properties----//
        public int goIn()
        {
            //returns if there is a door here
            return inDoor;
        }

        public int goOut()
        {
            //returns if there is a door here
            return outDoor;
        }

        public int goUp()
        {
            //returns if there is a door here
            return upDoor;
        }

        public int goDown()
        {
            //returns if there is a door here
            return downDoor;
        }
        //----Other Methods----//
    }
}
