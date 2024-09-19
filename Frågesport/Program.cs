int point = 0;
Console.WriteLine("Video game quiz");

Console.WriteLine("Question one: What was Super Mario originally known as?");
Console.WriteLine("a) Rescueman b) Plungerman c) Jumpman");

String answer1 = Console.ReadLine();
if (answer1 == "c")
{
Console.WriteLine("Correct");
    point += 1;
}
else
{
    Console.WriteLine("Incorrect");
}

Console.WriteLine("Question two: How many Boos are there to catch in luigi's mansion 1?");
Console.WriteLine("a) 45 b) 50 c) 62");

String answer2 = Console.ReadLine();
if (answer2 == "b")
{
    Console.WriteLine("Correct");
    point += 1;
}
else
{
    Console.WriteLine ("Incorrect");
}

Console.WriteLine("Question three: What is the name of John Marston's wife in red dead redemption?");
Console.WriteLine("a) Abby b) Abigail c) Abbeli");

String answer3 = Console.ReadLine();
if (answer3 == "b")
{
    Console.WriteLine("Correct");
    point += 1;
}
else
{
    Console.WriteLine("Incorrect");
}

{
Console.WriteLine($"You got {point} points ");
}
Console.ReadLine();