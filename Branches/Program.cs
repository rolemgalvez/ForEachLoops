//Welcome message
Console.WriteLine("Branches");
Console.WriteLine("--------");
Console.WriteLine();

//Prepare values
string data = "Pasay,Quirino,Makati,Guadalupe";
List<string> branches = data.Split(',').ToList();

//Show values
foreach (string branch in branches)
{
    Console.WriteLine(branch);
}

//End
Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();