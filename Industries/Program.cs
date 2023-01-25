//Welcome
Console.WriteLine("Industries");
Console.WriteLine("----------");
Console.WriteLine();

//Prepare
string data = "Technology,Health,Finance";
List<string> industries = data.Split(',').ToList();

//Show
foreach (string industry in industries)
{
    Console.WriteLine(industry);
}

//End
Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();