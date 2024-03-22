namespace TestCarousel;

public class MainViewModel
{
    public List<int> CarouselItems { get; } = Enumerable.Range(0, 10).ToList();
}