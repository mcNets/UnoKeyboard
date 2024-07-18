using Windows.Foundation;

namespace UnoKeyboard;

public static class KeyPathGeometry
{
    // LeftArrow
    //     H=10 W=10
    //     Data="M2,5 L4,1 M2,5 L4,9 M2,5 L9,5"
    //
    // Shift
    //     H=10 W=10
    //     Data="M5,2 L2,4 M5,2 L8,4 M5,2 L5,10"
    //
    // Backspace
    //     H=10 W=16
    //     Data="M1,5 L4,1 15,1 15,9 4,9 1,5 M7,3 L11,7 M7,7 L11,3"
    //
    // Enter
    //     H=10 W=12
    //     Data="M2,5 L4,2 M2,5 L4,8 M2,5 L10,5 10,2"

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

    // M1,5 L4,1 15,1 15,9 4,9 1,5 M7,3 L11,7 M7,7 L11,3
    public static PathGeometry Backspace =>
        new()
        {
            Figures =
            [
                new PathFigure()
                {
                    StartPoint = new Point(1, 5),
                    Segments =
                    [
                        new LineSegment() { Point = new Point(4, 1) },
                        new LineSegment() { Point = new Point(15, 1) },
                        new LineSegment() { Point = new Point(15, 9) },
                        new LineSegment() { Point = new Point(4, 9) },
                        new LineSegment() { Point = new Point(1, 5) },
                    ],
                    IsClosed = false
                },
                new PathFigure()
                {
                    StartPoint = new Point(7, 3),
                    Segments =
                    [
                        new LineSegment() { Point = new Point(11, 7) },
                    ],
                    IsClosed = false
                },
                new PathFigure()
                {
                    StartPoint = new Point(7, 7),
                    Segments =
                    [
                        new LineSegment() { Point = new Point(11, 3) },
                    ],
                    IsClosed = false
                },
            ]
        };
}