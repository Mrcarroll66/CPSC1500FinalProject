//Michael Carroll
//April 2021
//Program.cs
//Project 3

using System;

namespace Project_03
{
    class Program
    {
        static void Main(string[] args) //main
        {
            Items[] itemList = new Items[5]; //initalize item list array
            Room[] roomList = new Room[14]; //initalize room list array
            PopulateItems(itemList); //call method to populate item array
            PopulateArray(roomList); //call method to poulate room array
            Welcome(roomList); //call method to welcome user, and set up game
            Game(roomList, itemList); //call game method, where most of the code is located
        }

        static void Welcome(Room[] roomList) //welcome method
        {
            Console.WriteLine("Welcome to Adventure! \npress q " +
                "or type quit to quit at any time." +
                "Type hint if you are lost.");
            Console.WriteLine("-------------------------------" +
                "-------------------------------------"); //Welcome user
            Description(roomList, 0); //call method to display discription
        }

        static string Input() //whenever you need to ask for input
        {
            Console.Write("--> "); 
            string usrInput = Console.ReadLine(); //Store user's input
            return usrInput; //return it
        }

        static void PopulateArray(Room[] roomList) //populate room array method
        {
            roomList[0] = new Room("English department sitting area",
                "You are in the sitting area outside the English department" +
                " on the third floor of Decker" +
                "\nThere are tables and chairs all around you," +
                " with various students sitting around them." +
                "\nBehind you are offices. In front, there is a hallway that goes north and south.",
                4, 1, -1, -1); //the user starts in the english department lobby area in decker
            //they can proceed north or south from here, or talk to Jonah
            roomList[1] = new ComplexRoom("CompSci Hallway West end",
                "You are in the west end of the hallway near the computer science department." +
                "\nThere are classrooms on both sides of the hall." +
                "\nThere is a glass case diplaying various old computer technology.",
                0, -1, 2, -1, 6, -1, -1, -1); //this is the end of the hallway to the south
            //the user can enter a classroom to find the magic word GBGR, or head east
            roomList[2] = new Room("CompSci Hallway East end",
               "You are in the east end of the hallway near the computer science department." +
               "\nThere is a doorway leading to the computer science faculty offices." +
               "\nNext to the door, a bullitin board shows all the students in the department." +
               "\nAt the end of the hall, it turns to the left.",
                3, 7, -1, 1); //this is the other end of the hallway. the user can enter
            //Koontz's office from here or go north
            roomList[3] = new ComplexRoom("History/PolySci Department",
                "You are in front of the history and political science faculty offices." +
                "\nThe hallway continues to the left, where you can see the Genesys lab.",
                -1, 2, -1, 4, -1, -1, -1, -1); // this is the northeast corner of the building
            //there is a 20% chance for doctor post to appear when the user enters the room
            roomList[4] = new ComplexRoom("Math Department",
                "You are in the hallway outside the department of mathmatics." +
                "\nThere are offices on one side, and classroms on the other side of the hall." +
                "\nThere is an elevator at the end of the hall.",
                -1, 0, 3, -1, 5, -1, -1, -1); //this is the northwest corner of the building
            //if the user has a sandwich, they can give it to Rodney and enter the classroom
            //or get in the elevator
            roomList[5] = new ComplexRoom("Northwest Classroom",
                "You are in a classroom." +
                "\nThere are desks facing a whiteboard at the back of the room." +
                "\nDr. Taylor is standing in the room." +
                "\n\"Just in time for my exam.\" he says to you.",
                -1, -1, -1, -1, -1, 4, -1, -1); //upon entering this classroom, Dr Taylor
            //will make the player do a math exam, where all the answers are 42
            //after completing the exam, Dr. Taylor will drop a key
            roomList[6] = new ComplexRoom("Southwest Classroom",
                "You are in a classroom." +
                "\nDesks face a chalkboard to your left." +
                "\nYou see writing on the chalkboard, it says: magic word GBGR",
                -1, -1, -1, -1, -1, 1, -1, -1); //this classroom will show the user the magic word
            roomList[7] = new ComplexRoom("CompSci Faculty Offices",
                "You are in a small room with 4 office doors." +
                "\nStarting on your left, the first door has a plaque that says Charles Koontz," +
                "\n the second door says Jason Lowmiller, " +
                "\nthe third door says Dr. Jennifer Coy." +
                "\nthe last door says Jon Craton",
                2, -1, -1, -1, 8, -1, -1, -1); //you can enter here from the southeast hall.
            //from here you can go into Koontz's office
            roomList[8] = new ComplexRoom("Koontz's office",
                "You are inside Professor Koontz's office." +
                "\nThere is a desk with a computer, and various other items on it." +
                "\nProfessor Koontz is sitting behind the desk." +
                "\nHe tells you the watermelon story.",
                -1, -1, -1, -1, -1, 7, -1, -1); //Koontz will tell the user the watermelon story
            //then give them the lost ID
            roomList[9] = new ComplexRoom("Elevator 3rd floor",
                "You are inside the elevator on third floor." +
                "\nThere are 4 buttons and a keyhole.",
                -1, -1, -1, -1, -1, 4, -1, 10); //the user can enter the elevator from the 3rd
            //floor, where they can go down to BOD or the secret basement if they have the key
            roomList[10] = new ComplexRoom("Elevator BOD",
                "You are inside the elevator on the bottom floor of Decker." +
                "\nThere are 4 buttons and a keyhole.",
                -1, -1, -1, -1, -1, 11, 9, -1); //the user can ride the elevator to BOD
            //or user the key to go to the scret basement
            roomList[11] = new Room("Bottom of Decker",
                "You are in the bottom of Decker." +
                "\nThere are people sitting at the tables, and in chairs around the floor." +
                "\nCreate is in front of you, the elevator is behind you." +
                "\nThere is a large staircase that goes up in the middle of the room.",
                -1, -1, -1, 12); // the user can go into the elevator or go west towards creat
            roomList[12] = new Room("Create", 
                "You are at the create sandwich shop in the bottom of Decker." +
                "\nMarty is behind the counter." +
                "\n\"Hi do you want your usual?\"",
                -1, -1, 11, -1); // the user can buy a sandwich if the have the ID
            roomList[13] = new Room("Secret Basement",
                "You are in the secret basement under Decker Hall." +
                "\nPJP stands in front of a screen that is flashing red." +
                "\n\"Help\" he says, \"Ball state is launching nukes at us, " +
                "\nwe need the nuclear launch codes to stop them!\"", -1, -1, -1, -1);
            //the user can enter this room if they have the elevator key
            //if they come here with the codes, they win
        }

        static void PopulateItems(Items[] itemList) //populate each element of the item array
        {
            itemList[0] = new Items("elevator key"); //the key can be obtained from Dr. Taylor
            itemList[1] = new Items("Jonah's ID"); //the ID can be obtained from Professor Koontz
            itemList[2] = new Items("sandwich from Create"); //a sandwich can be bought with the ID
            itemList[3] = new Items("Dr. Post's book"); //The book can be obtained from Jonah
            itemList[4] = new Items("nuclear launch codes"); //The codes are obtained from Dr. Post
        }

        static void Game(Room[] roomList, Items[] itemList) //game, where most of the code is
        {
            int currentLoc = 0; //current location; used for index when referencing itemlist
            string input; // user input variable
            bool examPassed = false; //this is false until the user passes the exam
            bool rodney = true; //this is true until the user gives rodney the sandwich
            bool givenBook = false; //this is false until the user is given the book
            while (true) //always true until break;
            {
                if (currentLoc == 13 && itemList[4].HasItem == true)
                {
                    //if the user is in the secret basement with the codes
                    Console.WriteLine("You give PJP the nuclear launch codes." +
                        "He quickly types them in to a computer. The lights stop flashing." +
                        "\n\"Thank you for saving us!\" PJP says." +
                        "\nYou Win!"); 
                    break; //YOU WIN!
                }
                if (currentLoc == 8 && itemList[1].HasItem == false)
                {
                    //if the user is in Koontz's office without the ID
                    Console.WriteLine("He hands you an ID he found in the hall." +
                        "\nIt belongs to Jonah Warren");
                    itemList[1].HasItem = true; //give user ID
                }
                if (currentLoc == 3 && itemList[4].HasItem == false)
                {
                    //if the user is in the history dept without the codes
                    RandomAppearance(itemList); //chance for Dr Post to appear
                }
                if (currentLoc == 5 && examPassed == false)
                {
                    //if the user is in the classroom and hasn't passed the exam
                    examPassed = MathExam(itemList); //call exam method
                }
                input = Input();//call input method
                input = input.ToLower(); //convert to lowercase for easier logic
                //test user input
                if (input == "quit" || input == "q")
                {
                    //quit game
                    break;
                }
                else if (input == "s" || input == "south")
                {
                    //if south door exists
                    if (roomList[currentLoc].goSouth() > -1)
                    {
                        currentLoc = roomList[currentLoc].goSouth(); //currentloc equals new index
                        Description(roomList, currentLoc); //read description
                    }
                    else
                    {
                        Console.WriteLine("You cannot move that direction.");
                    }
                }
                if (input == "n" || input == "north")
                {
                    //if north door exists
                    if (roomList[currentLoc].goNorth() > -1)
                    {
                        currentLoc = roomList[currentLoc].goNorth(); //currentloc equals new index
                        Description(roomList, currentLoc); //read description
                    }
                    else
                    {
                        Console.WriteLine("You cannot move that direction.");
                    }
                }
                else if (input == "e" || input == "east")
                {
                    //if east door exists
                    if (roomList[currentLoc].goEast() > -1)
                    {
                        currentLoc = roomList[currentLoc].goEast(); //currentloc equals new index
                        Description(roomList, currentLoc); //read description
                    }
                    else
                    {
                        Console.WriteLine("You cannot move that direction.");
                    }
                }
                else if (input == "w" || input == "west")
                {
                    //if west door exists
                    if (roomList[currentLoc].goWest() > -1)
                    {
                        currentLoc = roomList[currentLoc].goWest(); //currentloc equals new index
                        Description(roomList, currentLoc); //read description
                    }
                    else
                    {
                        Console.WriteLine("You cannot move that direction.");
                    }
                }
                else if (input == "u" || input == "up")
                {
                    try
                    {
                        //if up door exists
                        if (((ComplexRoom)roomList[currentLoc]).goUp() > -1)
                        {
                            //currentloc equals new index
                            currentLoc = ((ComplexRoom)roomList[currentLoc]).goUp(); 
                            Description(roomList, currentLoc); //read description
                        }
                        else
                        {
                            Console.WriteLine("You cannot move that direction.");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("You cannot move that direction.");
                    }
                }
                else if (input == "d" || input == "down")
                {
                    try
                    {
                        //if down door exists
                        if (((ComplexRoom)roomList[currentLoc]).goDown() > -1)
                        {
                            //currentloc equals new index
                            currentLoc = ((ComplexRoom)roomList[currentLoc]).goDown(); 
                            Description(roomList, currentLoc); //read description
                        }
                        else
                        {
                            Console.WriteLine("You cannot move that direction.");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("You cannot move that direction.");
                    }
                }
                else if (input == "i" || input == "in")
                {
                    try
                    {
                        //if in door exists
                        if (((ComplexRoom)roomList[currentLoc]).goIn() > -1)
                        {
                            if (rodney == true && currentLoc == 4)
                            { //if the user in outside the classroom with rodney
                                Console.WriteLine("Rodney the Raven blocks the" +
                                    "door to the classroom." +
                                    "\nYou can't get past him." +
                                    "\nHe looks hungry.");
                                if (itemList[2].HasItem == true)
                                { //if they have the sandwich
                                    Console.WriteLine("You give Rodney your sandwich." +
                                        "He moves out of the doorway.");
                                    itemList[2].HasItem = false; //user used item
                                    rodney = false; //rodney is gone
                                }
                            }
                            else
                            {
                                //currentloc equals new index
                                currentLoc = ((ComplexRoom)roomList[currentLoc]).goIn(); 
                                Description(roomList, currentLoc); //read description
                            }
                        }
                        else
                        {
                            Console.WriteLine("You cannot move that direction.");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("You cannot move that direction.");
                    }
                }
                else if (input == "o" || input == "out")
                {
                    try
                    {
                        //if out door exists
                        if (((ComplexRoom)roomList[currentLoc]).goOut() > -1)
                        {
                            //currentloc equals new index
                            currentLoc = ((ComplexRoom)roomList[currentLoc]).goOut();
                            Description(roomList, currentLoc); //read description
                        }
                        else
                        {
                            Console.WriteLine("You cannot move that direction.");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("You cannot move that direction.");
                    }
                }
                else if (input == "elevator")
                {
                    //if the user wants to ride the elevator
                    if (currentLoc == 11 || currentLoc == 13)
                    { 
                        //it can be ridden from room 11 and 13
                        currentLoc = 10;
                        Description(roomList, currentLoc); //read description
                    }
                    else if (currentLoc == 4)
                    {
                        //it can also be ridden from room 4
                        currentLoc = 9;
                        Description(roomList, currentLoc); //read description
                    }
                    else
                    {
                        Console.WriteLine("There is no elevator here.");
                    }
                }
                else if (input == "key")
                {
                    //if the user is in the elevator and uses the key
                    if (currentLoc == 9 || currentLoc == 10)
                    {
                        if (itemList[0].HasItem == true)
                        {
                            Console.WriteLine("You ride the elevator down.");
                            currentLoc = 13;
                            Description(roomList, currentLoc); //read description
                        }
                        else
                        {
                            Console.WriteLine("You do not have a key.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("There is nowhere to use a key.");
                    }
                }
                else if (input == "talk" && currentLoc == 0)
                {
                    //if the user chooses to talk in the starting area
                    if (givenBook == false)
                    {
                        //if they don't already have the book
                        if (itemList[1].HasItem == false)
                        {
                            //if they don't have the ID
                            Console.WriteLine("You speak to a student sitting" + 
                                " at one of the tables." +
                                "\n\"I'm Jonah\", he says." +
                                "\"I seem to have lost my ID, can you help me find it?\"");
                        }
                        else
                        {
                            //Give jonah the ID
                            Console.WriteLine("You give Jonah his ID." +
                                "\n\"I need to give this book to Dr. Post, " +
                                "but I have a 420 page paper I need to finish." +
                                "\nCan you give it to her if you see her?\"");
                            itemList[1].HasItem = false; //remove id
                            itemList[3].HasItem = true; //add book
                        }
                    }
                }
                else if (input == "buy" && currentLoc == 12)
                {
                    //if the user buys a sandwich
                    if (itemList[1].HasItem == true)
                    {
                        //only if they have the ID already
                        Console.WriteLine("You buy a sandwich at create" +
                            " using Jonah's raven dollars.");
                        itemList[2].HasItem = true;
                    }
                    else
                    {
                        //otherwise they cannot buy it
                        Console.WriteLine("You cannot buy a sandwich with no raven dollars.");
                    }
                }
                else if (input == "gbgr")
                {
                    //magic word teleports to starting location
                    currentLoc = 0;
                    Description(roomList, currentLoc);
                }
                else if (input == "look")
                {
                    //describe room again
                    roomList[currentLoc].FirstVisit = true;
                    Description(roomList, currentLoc);
                }
                else if (input == "hint")
                {
                    //display help is the user is lost
                    Console.WriteLine("Type any direction to move that way" +
                        "(north/south/east/west/up/down/in/out)" +
                        "\nType elevator to ride the elevator." +
                        "\nTry typing the name of an object to use it." +
                        "\nType items to see your items." +
                        "\nTry to talking to people. ;)");
                }
                else if (input == "items")
                {
                    //display the users current items
                    DisplayItems(itemList);
                }
                else if (input == "board" && currentLoc == 2)
                {
                    //easter egg: you can see the students from the department
                    Console.WriteLine("You look at the bullitin board." +
                        " There are some students' names you can read." +
                        "\nJohnathan Alford  Allexus Bain  Michael Carroll" +
                        "\nIsaac Coats  Caleb Faulkner  Austin Lyons" +
                        "\nAndrew McCarroll  Emmalee Paarlberg  Nolan Renie" +
                        "\nIsaiah Schoen  Tom Sheahan  Jacob Spires" +
                        "\nCollin Stewart  Jeremiah Swisher  Josh Westrum");
                }
            }
        }

        static void Description(Room[] roomList, int currentLoc) //describe current room
        {
            if (roomList[currentLoc].FirstVisit == true)
            {
                //if it is the user's first time in the room
                Console.WriteLine(roomList[currentLoc]);
                roomList[currentLoc].FirstVisit = false;
            }
            else
            {
                //otherwise print the name
                Console.WriteLine(roomList[currentLoc].getName());
            }
        }

        static bool MathExam(Items[] itemList) //Dr. Taylor's math exam
        {
            string answer; // store the answer
            int numCorrect = 0; //number correct
            //there are 4 questions below
            //each answer is 42, if the user passes they get a key
            Console.Write("Question 1: What's 40 + 2? ");
            answer = Console.ReadLine();
            if (answer == "42")
            {
                numCorrect++;
            }
            Console.Write("Question 2: What's the square root of 1764? ");
            answer = Console.ReadLine();
            if (answer == "42")
            {
                numCorrect++;
            }
            Console.Write("Question 3: What's 7 times 6? ");
            answer = Console.ReadLine();
            if (answer == "42")
            {
                numCorrect++;
            }
            Console.Write("Question 4: What's 2898 divided by 69? ");
            answer = Console.ReadLine();
            if (answer == "42")
            {
                numCorrect++;
            }
            if (numCorrect >= 3)
            {
                Console.WriteLine("You passed!" +
                    "\nDr Taylor congratulates you, then leaves the room." + 
                    "\nHe drops a key on the way out." + 
                    "\nYou pick up the key.");
                itemList[0].HasItem = true; //get key
                return true;
            }
            else
            {
                Console.WriteLine("You failed.");
                return false;
            }
        }

        static void RandomAppearance(Items[] itemList) //Dr. post might appear
        {
            Random rand = new Random();
            int chance = rand.Next(1, 11); //random number
            if (chance == 1 || chance == 2) //20% chance
            {
                Console.WriteLine("Dr. Post comes out of her office." +
                    "\nShe is holding a piece of paper" + 
                    " that says something about nuclear launch codes.");
                if(itemList[3].HasItem == true)
                {
                    //if they have book, get codes
                    Console.WriteLine("You give Dr. Post the book." +
                        "\nShe trades you for the paper in her hands.");
                    itemList[3].HasItem = false; //give book
                    itemList[4].HasItem = true;// get codes
                }
            }
        }

        static void DisplayItems(Items[] itemList) //display the users items
        {
            foreach (Items item in itemList)
            {
                //show each item if they have it

                if (item.HasItem == true)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
