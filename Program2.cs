using System;

public interface IWindow
{
    void Draw();
}

public class BasicWindow : IWindow
{
    public void Draw()
    {
        Console.WriteLine("Drawing the entire content of the window.");
    }
}

public class ScrollingDecorator : IWindow
{
    private IWindow _window;
    private int _scrollPosition;

    public ScrollingDecorator(IWindow window)
    {
        _window = window;
        _scrollPosition = 0;
    }

    public void Scroll(int position)
    {
        _scrollPosition = position;
    }

    public void Draw()
    {
        Console.WriteLine($"Drawing the scrolled content of the window from position {_scrollPosition}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IWindow basicWindow = new BasicWindow();
        ScrollingDecorator scrollingWindow = new ScrollingDecorator(basicWindow);
        scrollingWindow.Scroll(50);
        scrollingWindow.Draw();
    }
}
