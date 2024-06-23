namespace AmrAmin.DesignPatterns.Behavioral.StrategyPattern.ImageStorageExample;
public class ImageStorage
{
    private readonly ICompressor _compressor;
    private readonly IFilter _filter;

    public ImageStorage(ICompressor compressor, IFilter filter)
    {
        _compressor = compressor;
        _filter = filter;
    }

    public void Store(byte[] data)
    {
        if (data == null || data.Length == 0)
        {
            throw new ArgumentNullException(nameof(data));
        }
        // Apply the selected compression algorithm
        _compressor.Compress(data);

        // Apply the selected filtering algorithm
        _filter.Apply(data);

        // Store the processed image data

        string filePath = Path.Combine("D:", "result.jpg");

        try
        {
            // Saving the image data (assuming JPG format based on filename extension)
            File.WriteAllBytes(filePath, data);
        }
        catch (Exception ex)
        {
            // Handle exception (e.g., log error, notify user)
            Console.WriteLine("Error saving image: " + ex.Message);
        }
    }
}
