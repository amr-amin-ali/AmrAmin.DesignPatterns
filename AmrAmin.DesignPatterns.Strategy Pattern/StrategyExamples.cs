namespace AmrAmin.DesignPatterns.Strategy_Pattern;
using System;

using AmrAmin.DesignPatterns.Strategy_Pattern.ConcreteStrategies;
using AmrAmin.DesignPatterns.Strategy_Pattern.ImageStorageExample;

public static class StrategyExamples
{
    public static void RunExamples()
    {
        RunGangOfFourExample();
        RunImageStorageExample();
    }
    private static void RunGangOfFourExample()
    {
        Console.WriteLine(" __________________________________________________________________________________");
        Console.WriteLine("/                                                                                  \\");
        Console.WriteLine("|      Use StrategyPattern to test the ShippingCalculator example                   |");
        Console.WriteLine("|                                                                                   |");
        Console.WriteLine("|                                                                                   |");
        Console.WriteLine("|                                    [START]                                        |");
        Console.WriteLine("|                                                                                   |");

        // Create a ShippingCalculator instance
        var shippingCalculator = new ShippingCalculatorContext();

        // Set the shipping strategy for electronic products
        shippingCalculator.SetShippingStrategy(new ElectronicShippingConcreteStrategy());
        double electronicShippingCost = shippingCalculator.CalculateShippingCost(new DeliveryAddress { /* address details */ });
        Console.WriteLine($"|          Electronic product shipping cost: {electronicShippingCost}");

        // Set the shipping strategy for books
        shippingCalculator.SetShippingStrategy(new BookShippingConcreteStrategy());
        double bookShippingCost = shippingCalculator.CalculateShippingCost(new DeliveryAddress { /* address details */ });
        Console.WriteLine($"|          Book shipping cost: {bookShippingCost}");

        // Set the shipping strategy for clothing
        shippingCalculator.SetShippingStrategy(new ClothingShippingConcreteStrategy());
        double clothingShippingCost = shippingCalculator.CalculateShippingCost(new DeliveryAddress { /* address details */ });
        Console.WriteLine($"|          Clothing shipping cost: {clothingShippingCost}");

        Console.WriteLine("|                                                                                   |");
        Console.WriteLine("|                                    [END]                                          |");
        Console.WriteLine("\\===================================================================================/");

    }
    private static void RunImageStorageExample()
    {
        Console.WriteLine(" __________________________________________________________________________________");
        Console.WriteLine("/                                                                                  \\");
        Console.WriteLine("|      Use StrategyPattern to test the ImageStorage example                         |");
        Console.WriteLine("|                                                                                   |");
        Console.WriteLine("|                                                                                   |");
        Console.WriteLine("|                                    [START]                                        |");
        Console.WriteLine("|                                                                                   |");
        var imageData = File.ReadAllBytes(@"D:\Amr_Amin.JPG");

        var jpegCompressor = new JpegCompressor();
        var blackAndWhiteFilter = new BlackAndWhiteFilter();
        var imageStorage = new ImageStorage(jpegCompressor, blackAndWhiteFilter);
        imageStorage.Store(imageData);

        Console.WriteLine("|                                                                                   |");

        var imageData2 = File.ReadAllBytes(@"D:\Amr_Amin.JPG");
        var pngCompressor = new JpegCompressor();
        var highContrastFilter = new HighContrastFilter();
        var imageStorage2 = new ImageStorage(pngCompressor, highContrastFilter);
        imageStorage2.Store(imageData2);

        Console.WriteLine("|                                                                                   |");
        Console.WriteLine("|                                    [END]                                          |");
        Console.WriteLine("\\===================================================================================/");

    }
}
