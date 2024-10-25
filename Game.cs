﻿using static WorldOfZuul.Messages.Messages;
using WorldOfZuul.CommandLogic;

namespace WorldOfZuul
{
    public class Game
    {
        private Room? currentRoom;
        //private Room? previousRoom; TODO: use this if we implement back command
        private readonly  string _mainCityName; 

        public Game(string cityName) {
            _mainCityName = cityName;
            CreateRooms();
        }

        private void CreateRooms()
        {
            MainCity mainCity = new(_mainCityName, "Sample description" ); 
            currentRoom = mainCity;
            
            
            //TODO: Create locations here
            /*
            Room? outside = new("Outside", "You are standing outside the main entrance of the university. To the east is a large building, to the south is a computing lab, and to the west is the campus pub.");
            Room? theatre = new("Theatre", "You find yourself inside a large lecture theatre. Rows of seats ascend up to the back, and there's a podium at the front. It's quite dark and quiet.");
            Room? pub = new("Pub", "You've entered the campus pub. It's a cozy place, with a few students chatting over drinks. There's a bar near you and some pool tables at the far end.");
            Room? lab = new("Lab", "You're in a computing lab. Desks with computers line the walls, and there's an office to the east. The hum of machines fills the room.");
            Room? office = new("Office", "You've entered what seems to be an administration office. There's a large desk with a computer on it, and some bookshelves lining one wall.");

            outside.SetExits(null, theatre, lab, pub); // North, East, South, West

            theatre.SetExit("west", outside);

            pub.SetExit("east", outside);

            lab.SetExits(outside, office, null, null);

            office.SetExit("west", lab);

            currentRoom = outside;
            */
        }

        public void Play()
        {
            Parser parserMain = new("main");
            Parser parserTravel = new("travel");

            PrintWelcome();

            bool continuePlaying = true;
            Command? command; 
            
            while (continuePlaying)
            {
                Console.WriteLine(currentRoom?.Name); //rework
                
                Console.Write("> ");

                string? input = Console.ReadLine();
                switch (currentRoom?.Name) {
                    case "Travel Menu":
                        command = parserTravel.GetCommand(input);
                        break;
                    default:
                        command = parserMain.GetCommand(input);
                        break; 
                }
                
                if (command == null) {
                    Console.WriteLine("I don't know that command.");
                    continue;
                }

                switch(command.CommandType) {
                    case "Travel Menu":
                        Console.WriteLine(currentRoom?.Description);
                        break;
                    /*
                    case "back":
                        if (previousRoom == null)
                            Console.WriteLine("You can't go back from here!");
                        else
                            currentRoom = previousRoom;
                        break;
                    */

                    case "north":
                    case "south":
                    case "east":
                    case "west":
                        Move(command.Name);
                        break;

                    case "quit":
                        continuePlaying = false;
                        break;

                    case "help":
                        PrintHelp();
                        break;

                    default:
                        Console.WriteLine("I don't know what command.");
                        break;
                }
            }

            Console.WriteLine("Thank you for playing World of Zuul!");
        }

        private void Move(string direction)
        {
            if (currentRoom?.Exits.ContainsKey(direction) == true)
            {
                //previousRoom = currentRoom;  
                currentRoom = currentRoom?.Exits[direction];
            }
            else
            {
                Console.WriteLine($"You can't go {direction}!");
            }
        }
        
        public bool Travel() {
            DisplayMessage("travel");
            return true; 
        }

        private static void PrintWelcome()
        {
            DisplayMessage("welcome");
            PrintHelp();
        }

        private static void PrintHelp()
        {
            DisplayMessage("help");
        }
    }
}
