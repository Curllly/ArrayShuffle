using ArrayShufle.Models;

int[] myArray = { 1, 2, 3, 4, 5 };
string[] strings =  { "я", "люблю", "гороховый", "суп", };
int[] testarray = { 0 };

// перемешивание int
foreach (int i in ArrayShuffler.Shuffle(myArray))
{
    Console.WriteLine(i);
}

Console.WriteLine();
// перемешивание string
foreach (string i in ArrayShuffler.Shuffle(strings))
{
    Console.WriteLine(i);
}

Console.WriteLine();
// перемешивание Array
Array[] arrays = { myArray, strings,  testarray};

foreach (var item in ArrayShuffler.Shuffle(arrays))
{
    Console.WriteLine(item);
}