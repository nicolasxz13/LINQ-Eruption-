List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};

// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");

//PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");

//..
Console.WriteLine("Start work");

//1
Console.WriteLine("-1-");
Console.WriteLine(eruptions.FirstOrDefault(a => a.Location == "Chile"));

//2
Console.WriteLine("-2-");
var eruptionresult = eruptions.FirstOrDefault(a => a.Location == "Hawaiian Is");
if (eruptionresult != null)
{
    Console.WriteLine(eruptionresult);
}
else
{
    Console.WriteLine("No Hawaiian Is Eruption found");
}

//3
Console.WriteLine("-3-");
Console.WriteLine(eruptions.FirstOrDefault(a => a.Year > 1900 && a.Location == "New Zealand"));

//4
Console.WriteLine("-4-");
IEnumerable<Eruption> tempresult = eruptions.Where(a => a.ElevationInMeters > 2000);
PrintEach(tempresult);

//5
Console.WriteLine("-5-");
IEnumerable<Eruption> tempresultWithL = eruptions.Where(a => a.Volcano.StartsWith("L"));
PrintEach(tempresultWithL);
int countWithL = 0;
foreach (var result in tempresultWithL)
{
    countWithL++;
}
Console.WriteLine(countWithL);

//6
Console.WriteLine("-6-");
int maxelevation = 0;
maxelevation = eruptions.Max(a => a.ElevationInMeters);
Console.WriteLine(maxelevation);

//7
Console.WriteLine("-7-");
Console.WriteLine(eruptions.FirstOrDefault(a => a.ElevationInMeters == maxelevation)?.Volcano);

//8
Console.WriteLine("-8-");
IEnumerable<Eruption> tempoldEruptionn = eruptions
    .Where(a => a.Year < 1000)
    .OrderBy(a => a.Volcano);

PrintEach(tempoldEruptionn);

//9
Console.WriteLine("-9-");
IEnumerable<string> temperuptionName = eruptions.Select(a => a.Volcano);
PrintEach(temperuptionName);

//..
// Execute Assignment Tasks here!

// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}
