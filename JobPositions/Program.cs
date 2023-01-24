//Welcome message
Console.WriteLine("Job Positions");
Console.WriteLine("-------------");
Console.WriteLine();

//Prepare values
string data = "Functional Consultant,Technical Support,Manager,Administrator";
List<string> positions = data.Split(',').ToList();

//Show values
foreach (string position in positions)
{
    Console.WriteLine(position);
}

//End
Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();