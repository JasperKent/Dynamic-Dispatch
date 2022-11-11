using ConsoleApp;

try
{
    dynamic bag = new PropertyBag();

    bag.Wibble = 27;
    bag.Wobble = "Hello";

    Console.WriteLine(bag.Wibble);
    Console.WriteLine(bag.Wobble);
    Console.WriteLine(bag.Wubble);

}
catch(Exception ex)
{
    Console.WriteLine($"{ex.GetType().Name}: {ex.Message}");
}
