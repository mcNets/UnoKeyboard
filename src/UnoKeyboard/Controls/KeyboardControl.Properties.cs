using UnoKeyboard.Models;

namespace UnoKeyboard.Controls;

public sealed partial class KeyboardControl
{
    private int _currentPage = 0;

    /// <summary>
    /// Current page of the keyboard
    /// </summary>
    public int CurrentPage 
    { 
        get => _currentPage;
        set
        {
            _currentPage = value;
            InvalidateKeyboard();
        }
    }

    /// <summary>
    /// KeyboardModel assigned to the control
    /// </summary>
    public KeyboardModel Keyboard
    {
        get { return (KeyboardModel)GetValue(KeyboardProperty); }
        set { SetValue(KeyboardProperty, value); }
    }

    public static readonly DependencyProperty KeyboardProperty =
        DependencyProperty.Register(nameof(Keyboard), 
                                    typeof(KeyboardModel), 
                                    typeof(KeyboardControl), 
                                    new PropertyMetadata(null, OnKeyboardChanged));

    /// <summary>
    /// When the keyboard changes, the whole control is updated.
    /// </summary>
    /// <param name="d"></param>
    /// <param name="e"></param>
    private static void OnKeyboardChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is KeyboardControl key && e.NewValue != null)
        {
            key.CurrentPage = 0;
            key.InvalidateKeyboard();
        }
    }

    public bool IsShiftActive
    {
        get { return (bool)GetValue(IsShiftActiveProperty); }
        set { SetValue(IsShiftActiveProperty, value); }
    }

    public static readonly DependencyProperty IsShiftActiveProperty =
        DependencyProperty.Register(nameof(IsShiftActive), 
                                    typeof(bool), 
                                    typeof(KeyboardControl), 
                                    new PropertyMetadata(false));

    public Brush KeyBackground
    {
        get { return (Brush)GetValue(KeyBackgroundProperty); }
        set { SetValue(KeyBackgroundProperty, value); }
    }

    public static readonly DependencyProperty KeyBackgroundProperty =
        DependencyProperty.Register(nameof(KeyBackground), 
                                    typeof(Brush), 
                                    typeof(KeyboardControl), 
                                    new PropertyMetadata(null));

    public Brush KeyForeground
    {
        get { return (Brush)GetValue(KeyForegroundProperty); }
        set { SetValue(KeyForegroundProperty, value); }
    }

    public static readonly DependencyProperty KeyForegroundProperty =
        DependencyProperty.Register(nameof(KeyForeground), 
                                    typeof(Brush), 
                                    typeof(KeyboardControl), 
                                    new PropertyMetadata(null));

    public Brush KeyBorderBrush
    {
        get { return (Brush)GetValue(KeyBorderBrushProperty); }
        set { SetValue(KeyBorderBrushProperty, value); }
    }

    public static readonly DependencyProperty KeyBorderBrushProperty =
        DependencyProperty.Register(nameof(KeyBorderBrush), 
                                    typeof(Brush), 
                                    typeof(KeyboardControl), 
                                    new PropertyMetadata(null));

    public Thickness KeyBorderThickness
    {
        get { return (Thickness)GetValue(KeyBorderThicknessProperty); }
        set { SetValue(KeyBorderThicknessProperty, value); }
    }

    public static readonly DependencyProperty KeyBorderThicknessProperty =
        DependencyProperty.Register(nameof(KeyBorderThickness), 
                                    typeof(Thickness), 
                                    typeof(KeyboardControl), 
                                    new PropertyMetadata(new Thickness(1)));

    public FontFamily KeyFontFamily
    {
        get { return (FontFamily)GetValue(KeyFontFamilyProperty); }
        set { SetValue(KeyFontFamilyProperty, value); }
    }

    public static readonly DependencyProperty KeyFontFamilyProperty =
        DependencyProperty.Register(nameof(KeyFontFamily),
                                    typeof(FontFamily),
                                    typeof(KeyboardControl),
                                    new PropertyMetadata(new FontFamily("Segoe UI")));

    public double KeyFontSize
    {
        get { return (double)GetValue(KeyFontSizeProperty); }
        set { SetValue(KeyFontSizeProperty, value); }
    }

    public static readonly DependencyProperty KeyFontSizeProperty =
        DependencyProperty.Register(nameof(KeyFontSize),
                                    typeof(double),
                                    typeof(KeyboardControl),
                                    new PropertyMetadata(14.0));
}
