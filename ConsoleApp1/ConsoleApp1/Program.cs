using ConsoleApp1.FactoryPattern;
using ConsoleApp1.FactoryPattern.Factories;

class Program
{
    static void Main(string[] args)
    {
        FactoryPattern();
    }

    static void FactoryPattern()
    {
        Console.WriteLine("Какую мебель вы хотите заказать?");
        Console.WriteLine("> chair - стул");
        Console.WriteLine("> table - стол");

        string NameFurniture = Console.ReadLine();

        FurnitureFactory furnitureFactory = GetFurnitureFactory(NameFurniture);
        IFurniture furniture = furnitureFactory.GetFurniture();
        if(furniture!=null)
        Console.WriteLine($"Ваш заказ '{NameFurniture}' обрабатывается.");
    }
    private static FurnitureFactory GetFurnitureFactory(string NameFurniture) =>
        NameFurniture switch
        {
            "chair" => new ChairFactory(1500),
            "table" => new TableFactory(5000),
            _ => null
        };
    
}