using System;
using System.IO;
using System.Text.Json;
using EcoTropolis.CommandLogic;
using EcoTropolis.InventorySystem;


namespace EcoTropolis.Locations
{
    public class Barcelona : Location
    {
        private readonly string _messagesPath = "game_texts.json";
        private readonly Game _game;
        private readonly Player _player;

        public Barcelona(Game game, Player player) : base("Barcelona")
        {
            _game = game;
            _player = player;
        }

        public override void DisplayStartMessage()
        {
            throw new NotImplementedException();
        }

        public override void ShowDescription()
        {
            throw new NotImplementedException();
        }

        public override void Play()
        {
            DisplayStartMessage();
            bool isPlaying = true;

            while (isPlaying)
            {
                Console.WriteLine(Messages["barcelona_intro"]);
                string? input = Console.ReadLine()?.ToLower();

                if (input == "train")
                {
                    GoCenter();
                }
                else
                {
                    Console.WriteLine("Invalid command, please try again.");
                    Console.WriteLine();
                }
            }
        }

        public override bool ExecuteCommand(Command command)
        {
            throw new NotImplementedException();
        }

        public void BarcelonaStart()
        {
            var messages = LoadMessages();

            Console.WriteLine(messages["barcelona_start"]);

            string? input;
            do
            {
                Console.Write("Introduce un comando: ");
                input = Console.ReadLine()?.ToLower();
                if (input != "train")
                {
                    Console.WriteLine("Invalid command, please try again");
                }
            } while (input != "train");

            Console.WriteLine(messages["barcelona_train"]);
        }

        private void GoCenter()
        {
            var messages = LoadMessages();

            Console.WriteLine(messages["go_center_start"]);

            bool commandActive = true;

            while (commandActive)
            {
                Console.Write("Enter a command: ");
                string? command = Console.ReadLine()?.ToLower();

                switch (command)
                {
                    case "look":
                        DisplaySituation1();
                        commandActive = false;
                        break;

                    default:
                        Console.WriteLine("Invalid command, please try again.");
                        break;
                }
            }
        }

        public void DisplaySituation1()
        {
            var messages = LoadMessages();
            var dialogue = LoadDialogue("dialogue1");

            Console.WriteLine(messages["situation1_start"]);
            Console.WriteLine(messages["situation1_prompt"]);
            DisplayDialogue(dialogue);

            bool commandActive = true;

            while (commandActive)
            {
                Console.Write("Enter a command: ");
                string? command = Console.ReadLine()?.ToLower();

                switch (command)
                {
                    case "look":
                        DisplaySituation2();
                        commandActive = false;
                        break;

                    case "meeting":
                        HandleMeeting();
                        commandActive = false;
                        break;

                    default:
                        Console.WriteLine("Invalid command, please try again.");
                        break;
                }
            }
        }

        private void DisplaySituation2()
        {
            var messages = LoadMessages();
            var dialogue = LoadDialogue("dialogue2");

            Console.WriteLine(messages["situation1_start"]);
            Console.WriteLine(messages["situation1_prompt"]);
            DisplayDialogue(dialogue);

            bool commandActive = true;

            while (commandActive)
            {
                Console.Write("Enter a command: ");
                string? command = Console.ReadLine()?.ToLower();

                switch (command)
                {
                    case "look":
                        DisplaySituation3();
                        commandActive = false;
                        break;

                    case "meeting":
                        HandleMeeting();
                        commandActive = false;
                        break;

                    default:
                        Console.WriteLine("Invalid command, please try again.");
                        break;
                }
            }
        }

        private void DisplaySituation3()
        {
            var messages = LoadMessages();
            var dialogue = LoadDialogue("dialogue3");

            Console.WriteLine(messages["situation1_start"]);
            DisplayDialogue(dialogue);

            bool commandActive = true;

            while (commandActive)
            {
                Console.Write("Enter a command: ");
                string? command = Console.ReadLine()?.ToLower();

                if (command == "meeting")
                {
                    HandleMeeting();
                    commandActive = false;
                }
                else
                {
                    Console.WriteLine("Invalid command, please try again.");
                }
            }
        }

        private void HandleMeeting()
        {
            var dialogue = LoadDialogue("meeting_start");
            var decisions = LoadDecisions();

            Console.WriteLine(dialogue["npc_intro"]);
            Console.WriteLine(dialogue["npc_request"]);

            int decision1Choice = Decision1(decisions["decision1"]);
            int decision2Choice = Decision2(decisions["decision2"]);
            int decision3Choice = Decision3(decisions["decision3"]);

            Console.WriteLine("\nResumen de tus decisiones:");
            Console.WriteLine($"Decisión 1: {decisions["decision1"]["options"][decision1Choice.ToString()]}");
            Console.WriteLine($"Decisión 2: {decisions["decision2"]["options"][decision2Choice.ToString()]}");
            Console.WriteLine($"Decisión 3: {decisions["decision3"]["options"][decision3Choice.ToString()]}");
        }

        private int Decision1(Dictionary<string, object> decision) => HandleDecision(decision);

        private int Decision2(Dictionary<string, object> decision) => HandleDecision(decision);

        private int Decision3(Dictionary<string, object> decision) => HandleDecision(decision);

        private int HandleDecision(Dictionary<string, object> decision)
        {
            Console.WriteLine("\n" + decision["text"]);
            var options = (JsonElement)decision["options"];
            foreach (var option in options.EnumerateObject())
            {
                Console.WriteLine($"{option.Name}: {option.Value.GetProperty("text").GetString()}");
            }

            int choice;
            while (true)
            {
                Console.Write("Vote (1, 2, 3): ");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out choice) && choice >= 1 && choice <= 3)
                {
                    return choice;
                }
                Console.WriteLine("Invalid input, please write 1, 2 o 3.");
            }
        }

        private Dictionary<string, Dictionary<string, object>> LoadDecisions()
        {
            try
            {
                string jsonString = File.ReadAllText(_messagesPath);
                var data = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, Dictionary<string, object>>>>(jsonString);
                return data["decisions"];
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return new Dictionary<string, Dictionary<string, object>>();
            }
        }

        private Dictionary<string, string> LoadMessages()
        {
            try
            {
                string jsonString = File.ReadAllText(_messagesPath);
                var messages = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(jsonString);
                return messages["messages"];
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar los mensajes: " + ex.Message);
                return new Dictionary<string, string>();
            }
        }

        private void DisplayDialogue(Dictionary<string, string> dialogue)
        {
            Console.WriteLine(dialogue["npc_intro"]);
            Console.WriteLine($"Player: {dialogue["player_question"]}");
            Console.WriteLine($"NPC: {dialogue["npc_response"]}");
            Console.WriteLine(dialogue["npc_goodbye"]);
        }

        private Dictionary<string, string> LoadDialogue(string dialogueKey)
        {
            try
            {
                string jsonString = File.ReadAllText(_messagesPath);
                var data = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, Dictionary<string, string>>>>(jsonString);
                return data["dialogue"][dialogueKey];
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading dialogue: " + ex.Message);
                return new Dictionary<string, string>();
            }
        }
    }
}
