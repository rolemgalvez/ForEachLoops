//Welcome
Console.WriteLine("Banks");
Console.WriteLine("-----");
Console.WriteLine();

//Prepare
string data = "BDO,BPI,PNB";
List<string> banks = data.Split(',').ToList();

//Show
foreach (string bank in banks)
{
    Console.WriteLine(bank);
}

//End
Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();