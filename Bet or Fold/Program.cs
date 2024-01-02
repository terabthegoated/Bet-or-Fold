using System;
Intro();

// Add parameters to PlayGame and Game methods to pass and return points
static void PlayGame(ref int player, ref int computer)
{
    Console.WriteLine("\n\t\t\t\t\t\t\t\t   Welcome to Bet or Fold!");
    Console.WriteLine("\t\t\t\t\t\t\t\t   Press Enter to Continue");
    Console.ReadKey();
    Game(ref player, ref computer);
}


static void Game(ref int player, ref int computer)
{
    Random random = new Random();

    int Ucard1 = random.Next(1, 14);
    int Ucard2 = random.Next(1, 14);
    int Ucard3 = random.Next(1, 14);
    int Ucard4 = random.Next(1, 14);

    int Ccard1 = random.Next(1, 14);
    int Ccard2 = random.Next(1, 14);
    int Ccard3 = random.Next(1, 14);
    int Ccard4 = random.Next(1, 14);

    Console.WriteLine("\n\t\t\t\t\t\t\t\t    WELCOME GAMBLERS!!!");
    Console.WriteLine("\t\t\t\t\t\t\t\t    This game is called Bet or Fold");
    Console.WriteLine("\t\t\t\t\t\t\t\t    LET THE GAME BEGIN!!!");
    Console.WriteLine("\t\t\t\t\t\t    -----------------------------------------------------------");



    int playerTotal = Ucard1 + Ucard2 + Ucard3 + Ucard4;
    int computerTotal = Ccard1 + Ccard2 + Ccard3 + Ccard4;

    Console.WriteLine("\t\t\t\t\t\t\t\t    Player:");
    Console.WriteLine("\t\t\t\t\t\t\t\t    Here are your cards:");
    Console.WriteLine("\t\t\t\t\t\t\t\t    Card 1:" + Ucard1);
    Console.WriteLine("\t\t\t\t\t\t\t\t    Card 2:" + Ucard2);
    Console.WriteLine("\t\t\t\t\t\t\t\t    Card 3:" + Ucard3);
    Console.WriteLine("\t\t\t\t\t\t\t\t    Card 4:" + Ucard4);
    Console.WriteLine("\t\t\t\t\t\t    -----------------------------------------------------------");

    Console.WriteLine("\t\t\t\t\t\t\t\t    Computer:");
    Console.WriteLine("\t\t\t\t\t\t\t\t    Your opponent's cards:");
    Console.WriteLine("\t\t\t\t\t\t\t\t    Card 1:?");
    Console.WriteLine("\t\t\t\t\t\t\t\t    Card 2:?");
    Console.WriteLine("\t\t\t\t\t\t\t\t    Card 3:?");
    Console.WriteLine("\t\t\t\t\t\t\t\t    Card 4:?");
    Console.WriteLine("\t\t\t\t\t\t    -----------------------------------------------------------");

    Console.Write("\n\t\t\t\t\t    Do you want to bet or fold? [press 'y or Y' to continue, and any key to end]: ");
    string decision = Console.ReadLine();

    if (decision == "Y" || decision == "y")
    {
        Console.Write("\n\t\t\t\t\t\t\t\t PLACE YOUR BET[Lowest $10]: $");
        int bet = int.Parse(Console.ReadLine());

        Console.WriteLine("\n\t\t\t\t\t\t\t\t    Player's Card:");
        Console.WriteLine("\t\t\t\t\t\t\t\t    Card 1:" + Ucard1);
        Console.WriteLine("\t\t\t\t\t\t\t\t    Card 2:" + Ucard2);
        Console.WriteLine("\t\t\t\t\t\t\t\t    Card 3:" + Ucard3);
        Console.WriteLine("\t\t\t\t\t\t\t\t    Card 4:" + Ucard4);

        Console.WriteLine("\n\t\t\t\t\t\t\t\t    Computer's Card:");
        Console.WriteLine("\t\t\t\t\t\t\t\t    Card 1:" + Ccard1);
        Console.WriteLine("\t\t\t\t\t\t\t\t    Card 2:" + Ccard2);
        Console.WriteLine("\t\t\t\t\t\t\t\t    Card 3:" + Ccard3);
        Console.WriteLine("\t\t\t\t\t\t\t\t    Card 4:" + Ccard4);

        Console.WriteLine("\n\t\t\t\t\t\t\t\t    Total:");
        Console.WriteLine("\t\t\t\t\t\t\t\t    Player:" + playerTotal);
        Console.WriteLine("\t\t\t\t\t\t\t\t    Computer:" + computerTotal);

        if (playerTotal > computerTotal)
        {
            Console.WriteLine($"\n\t\t\t\t\t\t\t\t    Congratulations, You Won ${bet}!");
            player += bet; // Add the bet to player's points
            computer -= bet; // Deduct the bet from computer's points
        }
        else if (playerTotal < computerTotal)
        {
            Console.WriteLine($"\n\t\t\t\t\t\t\t\t    Oh no, You Lose ${bet} :((");
            player -= bet; // Deduct the bet from player's points
            computer += bet; // Add the bet to computer's points

        }
        else
        {
            Console.WriteLine("\n\t\t\t\t\t\t\t\t\t    Draw!!");
            // Points remains the same in case of a draw
        }
    }
    else
    {
        Console.WriteLine("\n\t\t\t\t\t\t\t\t  The Game Has Ended. :(");
    }

    Thread.Sleep(2000);
    Console.Write("\n\t\t\t\t\t    Would you like to play again?[Press 'y' or 'Y' to continue or any key to stop]: ");
    char Continue = Convert.ToChar(Console.ReadLine());
    if (Continue == 'Y' || Continue == 'y')
    {
        Console.Clear();
        player = 1000;
        computer = 1000;
        Game(ref player, ref computer); // Pass parameters when calling Game() recursively
    }


    else
    {
        Console.WriteLine("\t\t\t\t\t\t\t\t    The Game has Ended. :(");
    }
    Thread.Sleep(2000);
    Console.ReadKey();
}



// Modify Menu method to pass and receive points
static void Menu()
{
    int playerPoints = 1000;
    int computerPoints = 1000;

    bool isRunning = true;
    int selectedOption = 0;

    while (isRunning)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\t\t\t\t\t\t\t            (PRESS ENTER ALWAYS)");
        Console.WriteLine("\t\t\t\t\t\t\t\t    ----- Game Menu -----");
        Console.WriteLine("\t\t\t\t\t\t\t\t         1. Start Game");
        Console.WriteLine("\t\t\t\t\t\t\t\t         2. About");
        Console.WriteLine("\t\t\t\t\t\t\t\t         3. Exit");
        Console.WriteLine("\t\t\t\t\t\t\t\t    ---------------------");
        Console.Write("\t\t\t\t\t\t\t\t    Select an option: ");
        try
        {
            selectedOption = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("\t\t\t\t\t\t\t\t    Invalid input. Please enter a number.");
            Console.ReadKey(true);
            continue;
        }

        switch (selectedOption)
        {
            case 1:
                Console.WriteLine("\n\t\t\t\t\t\t\t\t       Game Starts!!");
                Console.ReadKey(true);
                PlayGame(ref playerPoints, ref computerPoints);
                break;

            case 2:
                // Options menu 
                ShowOptionsMenu();
                break;
            case 3:
                // Exit Game 
                Console.WriteLine("\n\n\t\t\t\t\t\t\t\t        Exiting game...");
                isRunning = false;
                break;
            default:
                Console.WriteLine("\n\n\t\t\t\t\t\t\t\t        Invalid option.");
                Console.ReadKey(true);
                break;
        }
    }
}
static void Intro()
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\t\t\t\t _______   _______ ___________         ______    _______        _______  ______   ___      ________");
    Console.WriteLine("\t\t\t\t|   _  \"\\ /\"     \"(\"     _   \")       /    \" \\  /\"      \\      /\"     \"|/    \" \\ |\"  |    |\"      \"\\");
    Console.WriteLine("\t\t\t\t(. |_)  :(: ______))__/  \\\\__/       // ____  \\|:        |    (: ______// ____  \\||  |    (.  ___  :)");
    Console.WriteLine("\t\t\t\t|:     \\/ \\/    |     \\\\_ /         /  /    ) :|_____/   )     \\/    |/  /    ) :|:  |    |: \\   ) ||");
    Console.WriteLine("\t\t\t\t(|  _  \\\\ // ___)_    |.  |        (: (____/ // //      /      // ___(: (____/ // \\  |___ (| (___\\ ||");
    Console.WriteLine("\t\t\t\t|: |_)  :(:      \"|   \\:  |         \\        / |:  __   \\     (:  (   \\        / ( \\_|:  \\|:       :)");
    Console.WriteLine("\t\t\t\t(_______/ \\_______)    \\__|          \\\"_____/  |__|  \\___)     \\__/    \\\"_____/   \\_______(________/");
    Console.WriteLine("\t\t\t\t _____     _____     _____             _____      _____          _____     _____     _____     _____");
    Console.WriteLine("\t\t\t\t|A ^  |   |2    |   |3    |           |\\ ~ /|    |Joker|        |4    |   |5    |   |6    |   |7    |");
    Console.WriteLine("\t\t\t\t| / \\ |   |  o  |   | o o |           |}}:{{|    |==%, |        | o o |   | o o |   | o o |   | o o |");
    Console.WriteLine("\t\t\t\t| \\ / |   |     |   |     |           |}}:{{|    | \\/>\\|        |     |   |  o  |   | o o |   |o o o|");
    Console.WriteLine("\t\t\t\t|  .  |   |  o  |   |  o  |           |}}:{{|    | _>^^|        | o o |   | o o |   | o o |   | o o |");
    Console.WriteLine("\t\t\t\t|____A|   |____2|   |____3|           |/_~_\\|    |/_\\/_|        |____4|   |____5|   |____9|   |____7|");
    Console.ReadKey();
    Menu();
}

static void ShowOptionsMenu()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\t\t\t\t\t\t\t            ------ Options ------");
    Console.WriteLine("\t\t\t\t\t\t\t            1. Mechanics of the Game");
    Console.WriteLine("\t\t\t\t\t\t\t            2. Creator");
    Console.WriteLine("\t\t\t\t\t\t\t            3. Programming Language Used");
    Console.WriteLine("\t\t\t\t\t\t\t            4. Back");
    Console.WriteLine("\t\t\t\t\t\t\t            -----------------------");

    Console.Write("\t\t\t\t\t\t\t\t     Select an option: ");
    int selectedOption = Convert.ToInt32(Console.ReadLine());
    switch (selectedOption)
    {
        case 1:
            Console.WriteLine("\n\n\t\t\t\t\t\t\t\t  Hi Gamers! Welcome to Bet or Fold\n");
            Console.WriteLine("\t\t\t\t\t\t\t  1. This game is called Bet or Fold.\r\n" +
                "\t\t\t\t\t\t\t  2. It means this is a gamble game.\r\n" +
                "\t\t\t\t\t\t\t  3. Firstly, if you enter 'start game', the game will start;\r\n" +
                "\t\t\t\t\t\t\t  4. Then after that the game will give you 4 cards;\r\n" +
                "\t\t\t\t\t\t\t  5. You will see your card but your enemy/computer card will not;\r\n" +
                "\t\t\t\t\t\t\t  6. If you think that your card is higher than the enemy/computer;\r\n" +
                "\t\t\t\t\t\t\t  7. You can bet at your own risk;\r\n" +
                "\t\t\t\t\t\t\t  8. This bet is lowest 10$ only;\r\n" +
                "\t\t\t\t\t\t\t  9: Just click Y or y if you want to bet;\r\n" +
                "\t\t\t\t\t\t\t  10. And if you think that your cards are lower than the enemy/computer;\r\n" +
                "\t\t\t\t\t\t\t  11. You can click any letter or number it will cancel or it will end except Y or y");  
            Console.WriteLine("\n\n\t\t\t\t\t\t\t  GAMBLER REMINDER: THIS IS A GAMBLE GAME SO IT MEANS YOU HAVE TO TAKE RISK!!");
            break;
        case 2:
            Console.WriteLine("\n\n\n\t\t\t\t\t\t\t          Jorell Baskin C.Esteban");
            Console.WriteLine("\t\t\t\t\t\t\t          Charles Dicken Lane P. Eneria");
            Console.WriteLine("\t\t\t\t\t\t\t          Ahron C. Valenzuela");
            Console.WriteLine("\n\t\t\t\t\t\t\t         All Rights and Credits to the Owners.");
            break;
        case 3:
            Console.WriteLine("\n\n\t\t\t\t\t\t\t\t       ██████╗ ██╗ ██╗ ");
            Console.WriteLine("\t\t\t\t\t\t\t\t      ██╔════╝████████╗");
            Console.WriteLine("\t\t\t\t\t\t\t\t      ██║     ╚██╔═██╔╝");
            Console.WriteLine("\t\t\t\t\t\t\t\t      ██║     ████████╗");
            Console.WriteLine("\t\t\t\t\t\t\t\t      ╚██████╗╚██╔═██╔╝");
            Console.WriteLine("\t\t\t\t\t\t\t\t      ╚═════╝ ╚═╝ ╚═╝ ");
            break;
        case 4:
            Menu();
            Console.WriteLine("");
            break;
        default:
            Console.WriteLine("\t\t\t\t\t\t\t\t        Invalid option.");
            Console.ReadKey(true);
            break;
    }
    Option(); // just repeated the option method so that it can appear in the console
}
static void Option()
{

    try
    {
        int selectedOption = Convert.ToInt32(Console.ReadLine());

        switch (selectedOption)
        {
            case 1:
                Console.WriteLine("\n\n\t\t\t\t\t\t\t\t  Hi Gamers! Welcome to Bet or Fold\n");
                Console.WriteLine("\t\t\t\t\t\t\t  1. This game is called Bet or Fold.\r\n" +
                    "\t\t\t\t\t\t\t  2. It means this is a gamble game.\r\n" +
                    "\t\t\t\t\t\t\t  3. The first step in this game is you click the start;\r\n" +
                    "\t\t\t\t\t\t\t  4. Then after that the game will give you 4 cards;\r\n" +
                    "\t\t\t\t\t\t\t  5. You will see your card but your enemy/computer card will not;\r\n" +
                    "\t\t\t\t\t\t\t  6. If you think that your card is higher than the enemy/computer;\r\n" +
                    "\t\t\t\t\t\t\t  7. You can bet at your own risk;\r\n" +
                    "\t\t\t\t\t\t\t  8. This bet is 100-1000 range only;\r\n" +
                    "\t\t\t\t\t\t\t  9: Just click Y or y if you want to bet;\r\n" +
                    "\t\t\t\t\t\t\t  10. And if you think that your cards are lower than the enemy/computer;\r\n" +
                    "\t\t\t\t\t\t\t  11. You can click any letter or number it will cancel or it will end except Y or y");
                Console.WriteLine("\n\n\t\t\t\t\t\t\t  GAMBLER REMINDER: THIS IS A GAMBLE GAME SO IT MEANS YOU HAVE TO TAKE RISK!!");
                break;
            case 2:
                Console.WriteLine("\n\n\n\t\t\t\t\t\t\t          Jorell Baskin C.Esteban");
                Console.WriteLine("\t\t\t\t\t\t\t          Charles Dicken Lane P. Eneria");
                Console.WriteLine("\t\t\t\t\t\t\t          Ahron C. Valenzuela");
                Console.WriteLine("\n\t\t\t\t\t\t\t         All Rights and Credits to the Owners.");
                break;
            case 3:
                Console.WriteLine("\n\n\t\t\t\t\t\t\t\t       ██████╗ ██╗ ██╗ ");
                Console.WriteLine("\t\t\t\t\t\t\t\t      ██╔════╝████████╗");
                Console.WriteLine("\t\t\t\t\t\t\t\t      ██║     ╚██╔═██╔╝");
                Console.WriteLine("\t\t\t\t\t\t\t\t      ██║     ████████╗");
                Console.WriteLine("\t\t\t\t\t\t\t\t      ╚██████╗╚██╔═██╔╝");
                Console.WriteLine("\t\t\t\t\t\t\t\t      ╚═════╝ ╚═╝ ╚═╝ ");
                break;
            case 4:
                Menu();
                Console.WriteLine("");
                break;
            default:
                Console.WriteLine("\t\t\t\t\t\t\t\t        Invalid option.");
                Console.ReadKey(true);
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("\t\t\t\t\t\t\t          Please Click any Key to go back.");
        Console.ReadKey(true);
        Menu();
    }
}