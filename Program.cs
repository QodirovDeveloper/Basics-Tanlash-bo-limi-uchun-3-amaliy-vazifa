System.Console.WriteLine("1. Palindrome Tekshiruvi");
Console.Write("Bir satr kiriting: ");
string satr = Console.ReadLine();

string orqaTomonga = new string(satr.Reverse().ToArray());

if (satr.Equals(orqaTomonga, StringComparison.OrdinalIgnoreCase))
    Console.WriteLine("Palindrom");
else
    Console.WriteLine("Palindrom emas");

//====================================

System.Console.WriteLine("2. Temperatura O'girish");
Console.Write("Selsiyus bo'yicha temperaturani kiriting: ");
double celsius = double.Parse(Console.ReadLine());

double fahrenheit = (celsius * 9 / 5) + 32;
double kelvin = celsius + 273.15;

Console.WriteLine($"Selsiyus: {celsius}, Fahrenheit: {fahrenheit}, Kelvin: {kelvin}");

//============================================

System.Console.WriteLine("3. Sonlarni Tartiblash");
Console.Write("Sonlarni kiriting (vergul bilan ajratilgan): ");
string input = Console.ReadLine();
int[] sonlar = input.Split(',').Select(int.Parse).ToArray();

// Tartiblangan qator
int[] tartiblangan = sonlar.OrderBy(x => x).ToArray();
Console.WriteLine("Tartiblangan qator: " + string.Join(", ", tartiblangan));

// Teskari tartib
int[] teskariTartib = sonlar.OrderByDescending(x => x).ToArray();
Console.WriteLine("Teskari tartib: " + string.Join(", ", teskariTartib));

//=====================================================

System.Console.WriteLine("4. Berilgan Matnning Simvol Sanasini Hisoblash");
Console.Write("Matn kiriting: ");
string matn = Console.ReadLine();

Dictionary<char, int> simvolSanash = new Dictionary<char, int>();

foreach (char simvol in matn)
{
    if (simvolSanash.ContainsKey(simvol))
        simvolSanash[simvol]++;
    else
        simvolSanash[simvol] = 1;
}

foreach (var kvp in simvolSanash)
{
    Console.WriteLine($"'{kvp.Key}': {kvp.Value} martta");  
}
