using Windows.Foundation;

namespace UnoKeyboard;

public static class KeyPathGeometry
{
    /// <summary>
    /// Space 
    /// 
    ///   Width  = 13
    ///   Height = 7 
    ///   
    ///   0123456789012
    ///   ............. 0
    ///   ............. 1
    ///   .*.........*. 2
    ///   .*.........*. 3
    ///   .***********. 4
    ///   ............. 5
    ///   ............. 6
    /// 
    /// </summary>
    public static Microsoft.UI.Xaml.Shapes.Path Space()
    {
        var path = new Microsoft.UI.Xaml.Shapes.Path();
        path.Width = 13;
        path.Height = 7;
        path.StrokeThickness = 1;
        path.HorizontalAlignment = HorizontalAlignment.Left;
        path.Data = new PathGeometry()
        {
            Figures =
            [
                new PathFigure()
                {
                    StartPoint = new Point(1, 2),
                    Segments =
                    [
                        new LineSegment() { Point = new Point(1, 4) },
                        new LineSegment() { Point = new Point(11, 4) },
                        new LineSegment() { Point = new Point(11, 2) },
                    ],
                    IsClosed = false
                },
            ]
        };
        return path;
    }

    /// <summary>
    /// Shift
    /// 
    ///   Width  = 9
    ///   Height = 10 
    ///   
    ///   012345678
    ///   ......... 0
    ///   ......... 1
    ///   ....*.... 2
    ///   ...***... 3
    ///   ..*.*.*.. 4
    ///   .*..*..*. 5
    ///   ....*.... 6
    ///   ....*.... 7
    ///   ....*.... 8
    ///   ......... 9
    ///   
    /// </summary>
    public static Microsoft.UI.Xaml.Shapes.Path Shift() 
    {
        var path = new Microsoft.UI.Xaml.Shapes.Path();
        path.Width = 9;
        path.Height = 10;
        path.StrokeThickness = 1;
        path.HorizontalAlignment = HorizontalAlignment.Left;
        path.Data = new PathGeometry()
        {
            Figures =
            [
                new PathFigure()
                {
                    StartPoint = new Point(4, 2),
                    Segments =
                    [
                        new LineSegment() { Point = new Point(1, 5) },
                    ],
                    IsClosed = false
                },
                new PathFigure()
                {
                    StartPoint = new Point(4, 2),
                    Segments =
                    [
                        new LineSegment() { Point = new Point(7, 5) },
                    ],
                    IsClosed = false
                },
                new PathFigure()
                {
                    StartPoint = new Point(4, 2),
                    Segments =
                    [
                        new LineSegment() { Point = new Point(4, 8) },
                    ],
                    IsClosed = false
                },
            ]
        };
        return path;
    }

    /// <summary>
    /// Enter 
    /// 
    ///   Width  = 13
    ///   Height = 9 
    ///   
    ///   0123456789012
    ///   ............. 0
    ///   ............. 1 
    ///   ...*.......*. 2
    ///   ..*........*. 3 
    ///   .***********. 4
    ///   ..*.......... 5 
    ///   ...*......... 6
    ///   ............. 7
    ///   ............. 8
    /// 
    /// </summary>
    public static Microsoft.UI.Xaml.Shapes.Path Enter ()
    {
        var path = new Microsoft.UI.Xaml.Shapes.Path();
        path.Width = 13;
        path.Height = 9;
        path.StrokeThickness = 1;
        path.HorizontalAlignment = HorizontalAlignment.Left;
        path.Data = new PathGeometry()
        {
            Figures =
            [
                new PathFigure()
                {
                    StartPoint = new Point(1, 4),
                    Segments =
                    [
                        new LineSegment() { Point = new Point(3, 2) },
                    ],
                    IsClosed = false
                },
                new PathFigure()
                {
                    StartPoint = new Point(1, 4),
                    Segments =
                    [
                        new LineSegment() { Point = new Point(3, 6) },
                    ],
                    IsClosed = false
                },
                new PathFigure()
                {
                    StartPoint = new Point(1, 4),
                    Segments =
                    [
                        new LineSegment() { Point = new Point(11, 4) },
                        new LineSegment() { Point = new Point(11, 2) },
                    ],
                    IsClosed = false
                },
            ]
        };
        return path;
    }

    /// <summary>
    /// Back 
    /// 
    ///   Width  = 14
    ///   Height = 9 
    ///   
    ///   01234567890123
    ///   .............. 0 
    ///   ....*********. 1
    ///   ...*........*. 2
    ///   ..*...*.*...*. 3 
    ///   .*.....*....*. 4
    ///   ..*...*.*...*. 5 
    ///   ...*........*. 6
    ///   ....*********. 7
    ///   .............. 8
    /// 
    /// </summary>
    public static Microsoft.UI.Xaml.Shapes.Path Back()
    {
        var path = new Microsoft.UI.Xaml.Shapes.Path();
        path.Width = 14;
        path.Height = 9;
        path.StrokeThickness = 1;
        path.HorizontalAlignment = HorizontalAlignment.Left;
        path.Data = new PathGeometry()
        {
            Figures =
            [
                new PathFigure()
                {
                    StartPoint = new Point(12, 1),
                    Segments =
                    [
                        new LineSegment() { Point = new Point(4, 1) },
                        new LineSegment() { Point = new Point(1, 4) },
                        new LineSegment() { Point = new Point(4, 7) },
                        new LineSegment() { Point = new Point(12, 7) },
                        new LineSegment() { Point = new Point(12, 1) },
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
                    StartPoint = new Point(8, 3),
                    Segments =
                    [
                        new LineSegment() { Point = new Point(6, 5) },
                    ],
                    IsClosed = false
                },
            ]
        };
        return path;
    }

    // LeftArrow
    //     H=10 W=10
    //     Data="M2,5 L4,1 M2,5 L4,9 M2,5 L9,5"
    //

}