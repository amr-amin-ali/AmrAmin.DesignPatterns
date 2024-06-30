namespace AmrAmin.DesignPatterns.Creational.BuilderPattern;
// Builder
public interface IBuilder
{
    void AddSlide(Slide slide);
    void GetPdfDocument();
    void GetMovie();
}