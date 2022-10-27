// John Magpantay 
// 10-20-2022 
// Mad libs! Revamp
// Peer reviewed by : Christopher Prado               notes: Good work! very different from the last time, code works well and i like your mad libs selection! 





string playAgain = "yes";
while (playAgain == "yes")
{




    Console.WriteLine("Hi, lets play MadLibs! ");
    Console.WriteLine("--------------------------");

    Console.WriteLine("Enter a boys's name: ");
    string boy = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Enter an adjective: ");
    string adjective = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Enter a fast food's name: ");
    string fstFood = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Enter a fruit: ");
    string fruit = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Enter a activity: ");
    string activity = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Enter a color: ");
    string color = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Enter a noun: ");
    string noun = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Enter a emotion: ");
    string emotion = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Enter a feeling: ");
    string feeling = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Enter a day of the week: ");
    string weekday = Console.ReadLine();
    Console.Clear();
    Console.WriteLine(boy + " went to the " + adjective + " " + fstFood + " to get some " + fruit + " but when she got there everyone was " + activity + ". She didn't have her " + color + " " + noun + " so she felt very " + emotion + ". It was a " + feeling + " " + weekday + "!");


    Console.WriteLine("-------------");
    Console.WriteLine("Do you want to play again? yes or no");
    playAgain = Console.ReadLine();
    if (playAgain == "yes")
    {

        Console.WriteLine("Let's Play Again!");

    }
    else
    {
        Console.WriteLine("Thanks for playing my program!");
    }
}
