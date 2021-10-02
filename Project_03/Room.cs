//Michael Carroll
//April 2021
//Room.cs
//Project 3

using System;
using System.Collections.Generic;
using System.Text;

namespace Project_03
{
    public class Room
    {
        //----Data Members----//
        public const int noDoor = -1; //if there is no door it is -1
        protected string name; //name of room
        protected string description; //description of room
        protected int nDoor; //north door index
        protected int sDoor; //south door index
        protected int eDoor; //east door index
        protected int wDoor; //west door index
        protected bool firstVisit; //is it the user's first time in the room?

        //----Parameterized Constructor----//
        public Room(string newName, string newDescription, int newNDoor, 
            int newSDoor, int newEDoor, int newWDoor)
        {
            //get all information about the room from program.cs
            name = newName;
            description = newDescription;
            nDoor = newNDoor;
            sDoor = newSDoor;
            eDoor = newEDoor;
            wDoor = newWDoor;
            firstVisit = true;
        }

        //----Properties----//
        public string getName()
        {
            //get room name
            return name;
        }

        public string getDescription()
        {
            //get room description
            return description;
        }

        public int goNorth()
        {
            //get north door index
            return nDoor;
        }

        public int goSouth()
        {
            //get south door index
            return sDoor;
        }

        public int goEast()
        {
            //get east door index
            return eDoor;
        }

        public int goWest()
        {
            //get west door index
            return wDoor;
        }

        public bool FirstVisit
        {
            //get/set firstvisit
            get { return firstVisit; }
            set { firstVisit = value; }
        }

        //----Other Methods----//
        public override string ToString()
        {
            //return room description
            return description;
        }
    }
}
