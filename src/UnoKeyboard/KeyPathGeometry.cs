using Windows.Foundation;

namespace UnoKeyboard;

public static class KeyPathGeometry
{
    public static PathGeometry Shift =>
        new()
        {
            Figures =
            [
                new PathFigure()
                {
                    StartPoint = new Point(5, 2),
                    Segments =
                    [
                        new LineSegment() { Point = new Point(2, 4) },
                    ],
                    IsClosed = false
                },
                new PathFigure()
                {
                    StartPoint = new Point(5, 2),
                    Segments =
                    [
                        new LineSegment() { Point = new Point(8, 4) },
                    ],
                    IsClosed = false
                },
                new PathFigure()
                {
                    StartPoint = new Point(5, 2),
                    Segments =
                    [
                        new LineSegment() { Point = new Point(5, 10) },
                    ],
                    IsClosed = false
                },
            ]
        };

    public static PathGeometry Enter =>
        new()
        {
            Figures =
            [
                new PathFigure()
                {
                    StartPoint = new Point(2, 5),
                    Segments =
                    [
                        new LineSegment() { Point = new Point(4, 2) },
                    ],
                    IsClosed = false
                },
                new PathFigure()
                {
                    StartPoint = new Point(2, 5),
                    Segments =
                    [
                        new LineSegment() { Point = new Point(4, 8) },
                    ],
                    IsClosed = false
                },                
                new PathFigure()
                {
                    StartPoint = new Point(2, 5),
                    Segments =
                    [
                        new LineSegment() { Point = new Point(10, 5) },
                        new LineSegment() { Point = new Point(10, 2) },
                    ],
                    IsClosed = false
                },
            ]
        };
}