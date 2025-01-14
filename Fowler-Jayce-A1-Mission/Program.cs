//game start
// the choice
Console.WriteLine("As you are on your journey you find yourself at a fork in the road.");
Thread.Sleep(400);
Console.WriteLine("Will you head");
Thread.Sleep(200);
Console.WriteLine("[Left]");
Thread.Sleep(200);
Console.WriteLine("[Right]");
string text = Console.ReadLine();
//tells about the choice you made
if (text == "Left")
{
    Console.WriteLine("You arrive in a small settement ravaged by the empire");
};
if (text == "left")
{
    Console.WriteLine("You arrive in a small settement ravaged by the empire");
}
else if (text == "right")
{
    Console.WriteLine("you arrive at a mountain with a small trail leading around it");
};

if (text == "Right")
{
    Console.WriteLine("you arrive at a mountain with a small trail leading around it");
}
// repeats the code if you choose otherwise
else
{

};
// says that you are stopped and ends the game
Thread.Sleep(300);
Console.WriteLine(".");
Thread.Sleep(300);
Console.WriteLine(".");
Thread.Sleep(300);
Console.WriteLine(".");
Thread.Sleep(300);
Console.WriteLine("you are now stopped what will you do? Thats it for now!");
return;
