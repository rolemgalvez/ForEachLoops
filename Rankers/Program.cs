//Welcome message
Console.WriteLine("Rankers");
Console.WriteLine("-------");
Console.WriteLine();

//Prepare values
string data = "Juan,Pedro,Maria,Wapali";
List<string> rankers = data.Split(',').ToList();

//Show values
foreach (string ranker in rankers)
{
    Console.WriteLine(ranker);
}

//End
Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();