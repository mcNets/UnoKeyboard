using Microsoft.UI.Xaml.Input;

namespace UnoKeyboard;

public sealed partial class KeyboardControl
{
    /// <summary>
    /// Represents the current page of the keyboard.
    /// </summary>
    private int _currentPage = 0;

    /// <summary>
    /// Represents the TextBox control assigned to the keyboard.
    /// </summary>
    private TextBox? _textControl;

    /// <summary>
    /// Gets or sets the current page of the keyboard.
    /// </summary>
    public int CurrentPage
    {
        get => _currentPage;
        set
        {
            if (_currentPage != value)
            {
                _currentPage = value;
                InvalidateKeyboard();
            }
        }
    }

    /// <summary>
    /// Gets or sets the TextBox control assigned to the keyboard.
    /// </summary>
    public TextBox? TextControl
    {
        get => _textControl;
        set => _textControl = value;
    }

    /// <summary>
    /// Gets or sets the KeyboardModel assigned to the control.
    /// </summary>
    public KeyboardModel? Keyboard
    {
        get { return (KeyboardModel)GetValue(KeyboardProperty); }
        set { SetValue(KeyboardProperty, value); }
    }

    /// <summary>
    /// Identifies the Keyboard dependency property.
    /// </summary>
    public static readonly DependencyProperty KeyboardProperty =
        DependencyProperty.Register(nameof(Keyboard),
                                    typeof(KeyboardModel),
                                    typeof(KeyboardControl),
                                    new PropertyMetadata(null, OnKeyboardChanged));

    /// <summary>
    /// Called when the keyboard changes, updates the whole control.
    /// </summary>
    /// <param name="d">The dependency object.</param>
    /// <param name="e">The event arguments.</param>
    private static void OnKeyboardChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is not KeyboardControl ctl)
        {
            return;
        }

        ctl.Keyboard = e.NewValue as KeyboardModel;
        ctl.InvalidateKeyboard();
    }

    /// <summary>
    /// Gets or sets a value indicating whether the Shift key is active.
    /// </summary>
    public bool IsShiftActive
    {
        get { return (bool)GetValue(IsShiftActiveProperty); }
        set
        {
            SetValue(IsShiftActiveProperty, value);
            InvalidateKeyboard();
        }
    }

    /// <summary>
    /// Identifies the IsShiftActive dependency property.
    /// </summary>
    public static readonly DependencyProperty IsShiftActiveProperty =
        DependencyProperty.Register(nameof(IsShiftActive),
                                    typeof(bool),
                                    typeof(KeyboardControl),
                                    new PropertyMetadata(false));

    /// <summary>
    /// Gets or sets the brush used to fill the background of the keys.
    /// </summary>
    public Brush KeyBackground
    {
        get { return (Brush)GetValue(KeyBackgroundProperty); }
        set { SetValue(KeyBackgroundProperty, value); }
    }

    /// <summary>
    /// Identifies the KeyBackground dependency property.
    /// </summary>
    public static readonly DependencyProperty KeyBackgroundProperty =
        DependencyProperty.Register(nameof(KeyBackground),
                                    typeof(Brush),
                                    typeof(KeyboardControl),
                                    new PropertyMetadata(null, OnKeyBackgroundChanged));

    private static void OnKeyBackgroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is KeyboardControl ctl)
        {
            ctl.UpdateChildKeyBackgrounds();
        }
    }

    /// <summary>
    /// Gets or sets the brush used to draw the text of the keys.
    /// </summary>
    public Brush KeyForeground
    {
        get { return (Brush)GetValue(KeyForegroundProperty); }
        set { SetValue(KeyForegroundProperty, value); }
    }

    /// <summary>
    /// Identifies the KeyForeground dependency property.
    /// </summary>
    public static readonly DependencyProperty KeyForegroundProperty =
        DependencyProperty.Register(nameof(KeyForeground),
                                    typeof(Brush),
                                    typeof(KeyboardControl),
                                    new PropertyMetadata(null));

    /// <summary>
    /// Gets or sets the brush used to draw the border of the keys.
    /// </summary>
    public Brush KeyBorderBrush
    {
        get { return (Brush)GetValue(KeyBorderBrushProperty); }
        set { SetValue(KeyBorderBrushProperty, value); }
    }

    /// <summary>
    /// Identifies the KeyBorderBrush dependency property.
    /// </summary>
    public static readonly DependencyProperty KeyBorderBrushProperty =
        DependencyProperty.Register(nameof(KeyBorderBrush),
                                    typeof(Brush),
                                    typeof(KeyboardControl),
                                    new PropertyMetadata(null));

    /// <summary>
    /// Gets or sets the thickness of the border of the keys.
    /// </summary>
    public Thickness KeyBorderThickness
    {
        get { return (Thickness)GetValue(KeyBorderThicknessProperty); }
        set { SetValue(KeyBorderThicknessProperty, value); }
    }

    /// <summary>
    /// Identifies the KeyBorderThickness dependency property.
    /// </summary>
    public static readonly DependencyProperty KeyBorderThicknessProperty =
        DependencyProperty.Register(nameof(KeyBorderThickness),
                                    typeof(Thickness),
                                    typeof(KeyboardControl),
                                    new PropertyMetadata(new Thickness(1)));

    /// <summary>
    /// Gets or sets the margin of the keys.
    /// </summary>
    public Thickness KeyMargin
    {
        get { return (Thickness)GetValue(KeyMarginProperty); }
        set { SetValue(KeyMarginProperty, value); }
    }

    /// <summary>
    /// Identifies the KeyMargin dependency property.
    /// </summary>
    public static readonly DependencyProperty KeyMarginProperty =
        DependencyProperty.Register(nameof(KeyMargin),
                                    typeof(Thickness),
                                    typeof(KeyboardControl),
                                    new PropertyMetadata(new Thickness(2)));

    /// <summary>
    /// Gets or sets the font family used to draw the text of the keys.
    /// </summary>
    public FontFamily KeyFontFamily
    {
        get { return (FontFamily)GetValue(KeyFontFamilyProperty); }
        set { SetValue(KeyFontFamilyProperty, value); }
    }

    /// <summary>
    /// Identifies the KeyFontFamily dependency property.
    /// </summary>
    public static readonly DependencyProperty KeyFontFamilyProperty =
        DependencyProperty.Register(nameof(KeyFontFamily),
                                    typeof(FontFamily),
                                    typeof(KeyboardControl),
                                    new PropertyMetadata(new FontFamily("Segoe UI")));

    /// <summary>
    /// Gets or sets the font size used to draw the text of the keys.
    /// </summary>
    public double KeyFontSize
    {
        get { return (double)GetValue(KeyFontSizeProperty); }
        set { SetValue(KeyFontSizeProperty, value); }
    }

    /// <summary>
    /// Identifies the KeyFontSize dependency property.
    /// </summary>
    public static readonly DependencyProperty KeyFontSizeProperty =
        DependencyProperty.Register(nameof(KeyFontSize),
                                    typeof(double),
                                    typeof(KeyboardControl),
                                    new PropertyMetadata(14.0));

    /// <summary>
    /// Gets or sets the padding between the keys and the border of the control.
    /// </summary>
    public double Padding
    {
        get { return (double)GetValue(PaddingProperty); }
        set { SetValue(PaddingProperty, value); }
    }

    /// <summary>
    /// Identifies the Padding dependency property.
    /// </summary>
    public static readonly DependencyProperty PaddingProperty =
        DependencyProperty.Register(nameof(PaddingProperty),
                                    typeof(double),
                                    typeof(KeyboardControl),
                                    new PropertyMetadata(15.0));

    /// <summary>
    /// Gets or sets the background of the special keys.
    /// </summary>
    public Brush KeySpecialKeyBackground
    {
        get { return (Brush)GetValue(KeySpecialKeyBackgroumdProperty); }
        set { SetValue(KeySpecialKeyBackgroumdProperty, value); }
    }

    /// <summary>
    /// Identifies the KeySpecialKeyBackgroumd dependency property.
    /// </summary>
    public static readonly DependencyProperty KeySpecialKeyBackgroumdProperty =
        DependencyProperty.Register(nameof(KeySpecialKeyBackground),
                                    typeof(Brush),
                                    typeof(KeyboardControl),
                                    new PropertyMetadata(null, OnKeySpecialKeyBackgroundChanged));

    private static void OnKeySpecialKeyBackgroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is KeyboardControl ctl)
        {
            ctl.UpdateChildKeyBackgrounds();
        }
    }

    /// <summary>
    /// Gets or sets a value indicating whether to handle focus manager.
    /// </summary>
    public bool HandleFocusManager
    {
        get { return (bool)GetValue(HandleFocusManagerProperty); }
        set { SetValue(HandleFocusManagerProperty, value); }
    }

    /// <summary>
    /// Identifies the HandleFocusManager dependency property.
    /// </summary>
    public static readonly DependencyProperty HandleFocusManagerProperty =
        DependencyProperty.Register(nameof(HandleFocusManager),
                                    typeof(bool),
                                    typeof(KeyboardControl),
                                    new PropertyMetadata(false, OnHandleFocusManagerChanged));


    /// <summary>
    /// Called when the HandleFocusManager property changes.
    /// Subscribes or unsubscribes to the focus manager events.
    /// </summary>
    /// <param name="dependencyObject"></param>
    /// <param name="args"></param>
    private static void OnHandleFocusManagerChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
    {
        if (dependencyObject is not KeyboardControl ctl)
        { return; }

        if (ctl.HandleFocusManager)
        {
            FocusManager.GettingFocus += ctl.OnGettingFocus;
            FocusManager.LosingFocus += ctl.OnLosingFocus;
        }
        else
        {
            FocusManager.GettingFocus -= ctl.OnGettingFocus;
            FocusManager.LosingFocus -= ctl.OnLosingFocus;
        }
    }
}
