namespace AmrAmin.DesignPatterns.Strategy_Pattern;
using System;

using AmrAmin.DesignPatterns.SharedKernel;
using AmrAmin.DesignPatterns.Strategy_Pattern.ConcreteStrategies;
using AmrAmin.DesignPatterns.Strategy_Pattern.ImageStorageExample;

public static class StrategyExamples
{
    public static void RunExamples()
    {
        RunGangOfFourExample();
        Console.WriteLine("\n\n");
        RunImageStorageExample();
        Console.WriteLine("\n\n");
    }
    private static void RunGangOfFourExample()
    {
        UiSkelton.DrawHeader("Use StrategyPattern to test the ShippingCalculator example");


        // Create a ShippingCalculator instance
        var shippingCalculator = new ShippingCalculatorContext();

        // Set the shipping strategy for electronic products
        shippingCalculator.SetShippingStrategy(new ElectronicShippingConcreteStrategy());
        double electronicShippingCost = shippingCalculator.CalculateShippingCost(new DeliveryAddress { /* address details */ });

        UiSkelton.WriteIndentedText1($"Electronic product shipping cost: {electronicShippingCost}");

        // Set the shipping strategy for books
        shippingCalculator.SetShippingStrategy(new BookShippingConcreteStrategy());
        double bookShippingCost = shippingCalculator.CalculateShippingCost(new DeliveryAddress { /* address details */ });

        UiSkelton.WriteIndentedText1($"Book shipping cost: {bookShippingCost}");

        // Set the shipping strategy for clothing
        shippingCalculator.SetShippingStrategy(new ClothingShippingConcreteStrategy());
        double clothingShippingCost = shippingCalculator.CalculateShippingCost(new DeliveryAddress { /* address details */ });

        UiSkelton.WriteIndentedText1($"Clothing shipping cost: {clothingShippingCost}");

        UiSkelton.DrawFooter();

    }
    private static void RunImageStorageExample()
    {
        UiSkelton.DrawHeader("Use StrategyPattern to test the ImageStorage example");



        var imageData = File.ReadAllBytes(@"D:\Amr_Amin.JPG");

        var jpegCompressor = new JpegCompressor();
        var blackAndWhiteFilter = new BlackAndWhiteFilter();
        var imageStorage = new ImageStorage(jpegCompressor, blackAndWhiteFilter);
        imageStorage.Store(imageData);

        UiSkelton.DrawLineSeparator();

        var imageData2 = File.ReadAllBytes(@"D:\Amr_Amin.JPG");
        var pngCompressor = new JpegCompressor();
        var highContrastFilter = new HighContrastFilter();
        var imageStorage2 = new ImageStorage(pngCompressor, highContrastFilter);
        imageStorage2.Store(imageData2);

        UiSkelton.DrawFooter();

    }
}
