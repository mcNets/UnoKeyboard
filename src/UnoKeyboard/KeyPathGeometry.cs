using Windows.Foundation;

namespace UnoKeyboard;

public static class KeyPathGeometry
{
    /// <summary>
    /// Space 
    /// 
    ///     H=10 W=10
    ///     Data="M0,3 L0,5 L10,5 L10,3"
    /// </summary>
    public static PathGeometry Space =>
        new()
        {
            Figures =
            [
                new PathFigure()
                {
                    StartPoint = new Point(0, 3),
                    Segments =
                    [
                        new LineSegment() { Point = new Point(0, 5) },
                        new LineSegment() { Point = new Point(10, 5) },
                        new LineSegment() { Point = new Point(10, 3) },
                    ],
                    IsClosed = false
                },
            ]
        };

    /// <summary>
    /// Shift
    /// 
    ///     H=10 W=10
    ///     Data="M5,2 L2,4 M5,2 L8,4 M5,2 L5,10"
    /// </summary>
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

    /// <summary>
    /// Enter
    /// 
    ///     H=10 W=12
    ///     Data="M2,5 L4,2 M2,5 L4,8 M2,5 L10,5 10,2"
    /// </summary>
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

    /// <summary>
    /// Back
    /// 
    ///     H=10 W=16
    ///     Data="M1,5 L4,1 15,1 15,9 4,9 1,5 M7,3 L11,7 M7,7 L11,3"
    /// </summary>
    public static PathGeometry Back =>
        new()
        {
            Figures =
            [
                new PathFigure()
                {
                    StartPoint = new Point(1, 4),
                    Segments =
                    [
                        new LineSegment() { Point = new Point(3, 1) },
                        new LineSegment() { Point = new Point(12, 1) },
                        new LineSegment() { Point = new Point(12, 7) },
                        new LineSegment() { Point = new Point(3, 7) },
                        new LineSegment() { Point = new Point(1, 4) },
                    ],
                    IsClosed = false
                },
                new PathFigure()
                {
                    StartPoint = new Point(6, 3),
                    Segments =
                    [
                        new LineSegment() { Point = new Point(8, 5) },
                    ],
                    IsClosed = false
                },
                new PathFigure()
                {
                    StartPoint = new Point(6, 5),
                    Segments =
                    [
                        new LineSegment() { Point = new Point(8, 3) },
                    ],
                    IsClosed = false
                },
            ]
        };

    // LeftArrow
    //     H=10 W=10
    //     Data="M2,5 L4,1 M2,5 L4,9 M2,5 L9,5"
    //

}