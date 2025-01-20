
using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Timers;
using static System.Formats.Asn1.AsnWriter;




//game start
//introduction
//bools and int to be used later on through the code
bool playerAroundCornerRight = false;
bool playerAroundCornerLeft = false;
bool playerRanBat = false;
bool playerKillBat = false;
int playerGold = int.Parse("0");
int playerScore = int.Parse("0");
Console.WriteLine("WARNING type responses how they are shown");
Console.WriteLine(" ");
Console.WriteLine("you are an explorer");
Console.WriteLine(" ");
Console.WriteLine("you came to this dungeon in a search for treasure");
Console.WriteLine(" ");
Console.WriteLine("you brought a handful of supplies");
Console.WriteLine(" ");
Console.WriteLine("Would you like to view them?");
Console.WriteLine(" ");
Console.WriteLine("[yes]");
Console.WriteLine("[no]");
// player input
string PlayerInput1 = Console.ReadLine();

if (PlayerInput1 == "yes")
{
    //decision
    //list of items brought
    Console.WriteLine("You have brought the various items");
    Console.WriteLine(" ");
    Console.WriteLine("Mace");
    Console.WriteLine(" ");
    Console.WriteLine("Sword");
    Console.WriteLine(" ");
    Console.WriteLine("Spear");
    Console.WriteLine(" ");
    Console.WriteLine("A book about monster weakness's");
    Console.WriteLine(" ");
    Console.WriteLine("Would you like to read the book?");
    Console.WriteLine("[yes]");
    Console.WriteLine("[no]");
    //player input
    string playerInput2 = Console.ReadLine();
    if (playerInput2 == "yes")
    {
        //list of what items do made intentionally vague
        Console.WriteLine("Zombies are weak to slashing");
        Console.WriteLine(" ");
        Console.WriteLine("Skeletons are weak to blugeoning");
        Console.WriteLine(" ");
        Console.WriteLine("Spiders are weak to being stabbed");
        Console.WriteLine(" ");
        Console.WriteLine("Bats are weak to being stabbed");
        Console.WriteLine(" ");
    };
    
}

//set strings to display text that will be used alot in the code
string eventAll = "What would you do \n[sword]\n[spear]\n[mace]\n[run] ";
string gameOver = "\nGAME OVER";
    Console.WriteLine("As you enter the dungeon you enter a foyer");
    //player can choose which direction they want to go
    Console.WriteLine("you have the option to move either");
    Console.WriteLine("[left]");
    Console.WriteLine("[right]");
    Console.WriteLine("[escape]");
//player input
string playerInput3 = Console.ReadLine();
//pathway left
if (playerInput3 == "left")
{
    //player decisions
    Console.WriteLine("you walk towards the end of the hall and notice a stool with a skeleton sitting on it");
    Console.WriteLine("it slowly gets up and begins to prepare to attack you");
    Console.WriteLine($"{eventAll}");
    //results
    string inputLeft = Console.ReadLine();
    if (inputLeft == "sword")
    {
        Console.WriteLine("Your sword cuts off the skeletons head but the body seems to move fine without it");
        Console.WriteLine("the body stabs you with the heads view on the ground");
        //game end
        Console.WriteLine($"{gameOver}");
    };
    if (inputLeft == "spear")
    {
        Console.WriteLine("Your spear goes straight through the skeletons head");
        Console.WriteLine("it seems unfazed and  stabs you instead");
        //game end
        Console.WriteLine($"{gameOver}");
    };
    if (inputLeft == "run")
    {
        Console.WriteLine("You are stabbed in the back while you tried to escape");
        //game end
        Console.WriteLine($"{gameOver}");
    };
    if (inputLeft == "mace")
    {
        //correct choice
        Console.WriteLine("You completely crush the skeleton to pieces");
        Console.WriteLine(" ");
        Console.WriteLine("you head around the corner");
        //forces the next scene to play
        playerAroundCornerLeft = true;
    };
};
//pathway right
if (playerInput3 == "right")
{
    Console.WriteLine("you enter the hallway but before you can react a giant bat flys toward you");
    Console.WriteLine($"{eventAll}");
    string inputRight = Console.ReadLine();
    if (inputRight == "sword")
    {
        Console.WriteLine("You miss the bat and it fly's off");
    };
    if (inputRight == "mace")
    {
        Console.WriteLine("You miss the bat and it fly's off");
    };
    if (inputRight == "spear")
    {
        Console.WriteLine("you stab straight through the bats head");
        // sets the bool to true so we can add it to the score later
        playerKillBat = true;
    }
    else if (inputRight == "run")
    {
        Console.WriteLine("You escaped the dungeon");
        //game end
        Console.WriteLine($"{gameOver}");
        playerRanBat = true;
    };
    //all choices lead here other than escaping
    if (playerRanBat == false)
    {
        Console.WriteLine("you have time to view your surrounding\nyou have the option to go around a corner or enter a room");
        Console.WriteLine("Where will you go");
        Console.WriteLine("[corner]");
        Console.WriteLine("[room]");
        string playerInput4 = Console.ReadLine();
        //player input
        if (playerInput4 == "corner")
        {//forces the next scene to play
            playerAroundCornerRight = true;
        };
        if (playerInput4 == "room")
        {
            Console.WriteLine("You find a room with some beds and a small amount of gold on a table however it is guarded by a giant spider");
            Console.WriteLine($"{eventAll}");
            string playerInput5 = Console.ReadLine();
            //player input
            if (playerInput5 == "sword")
            {
                Console.WriteLine("you miss the attack with the sword and the spider jumps on your head and slowly starts to poison you with its fangs");
                Console.WriteLine($"{gameOver}");
            };
            if (playerInput5 == "mace")
            {
                Console.WriteLine("you miss the attack with the mace and  the spider jumps on your head slowly and starts to poison you with its fangs");
                //game over
                Console.WriteLine($"{gameOver}");
            };
            if (playerInput5 == "run")
            {
                Console.WriteLine("You try to escape and get caught by the spiders web and devoured");
                //game over
                Console.WriteLine($"{gameOver}");
            };
            if (playerInput5 == "spear")
            {
                Console.WriteLine("you stab the spider head on and cause it to collapse \nyou grab some 75 gold coins and head out of the room and around the corner");
                //adds the gold the player grabbed to the total gold
                playerGold += 75;
                //forces the next scene to play
                playerAroundCornerRight = true;
            };

        };
    };
    //player escapes
    if (playerInput3 == "run")
    {
        Console.WriteLine("you chose to escape the dungeon without any loot...");
        Console.WriteLine("but at least you are alive");
        Console.WriteLine($"{gameOver}");
        //game end
    };
};
//assigns playerAroundCorner to be PlayerAroundCornerLeft or right meaning only one needs to be true
bool playerAroundCorner = playerAroundCornerLeft || playerAroundCornerRight;
if (playerAroundCorner = true) //player goes around the corner
    {


        Console.WriteLine("As you turn the corner you stumble onto a large room with tons of gold covering the ground\n but there is a zombie guarding it");
        Console.WriteLine($"{eventAll}");
        //player input
        string playerInput6 = Console.ReadLine();
        if (playerInput6 == "run")
        {
            Console.WriteLine("As you try to run away you trip and get mauled by the zombie");
            Console.WriteLine($"{gameOver}");
            //game end
        };
        if (playerInput6 == "spear")
        {
            Console.WriteLine("your spear gets stuck in the zombies chest, while you try to pull it out the zombie moves closer to you and eats you");
            Console.WriteLine($"{gameOver}");
            //game end
        };
        if (playerInput6 == "mace")
        {
            Console.WriteLine("You attempt to crush the zombie with the mace to little effect the zombie shrugs the hit off and eats you");
            Console.WriteLine($"{gameOver}");
            //game end
        };
        if (playerInput6 == "sword")
        {
            Console.WriteLine("you slash the zombies head clean off making it lose connection to its brain it stops moving");
            Console.WriteLine("you grab as much loot as you can hold in the final room and decide its time to leave the dungeon");
            playerGold += 100;
        };
        // times player score by gold and removes some if they killed the bat
        Console.WriteLine($"playerGold = {playerGold} x 10 score");
        playerScore = playerGold * 10;
        if (playerKillBat == true)
        {
            Console.WriteLine($"was the bat killed {playerKillBat}-10 score");
            playerScore -= 10;
        };
        Console.WriteLine($"You escaped the dungeon with a score of {playerScore}");
        //game finishs
    };
