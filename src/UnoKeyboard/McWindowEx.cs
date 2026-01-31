namespace UnoKeyboard;

using KeyboardId = System.String;

/// <summary>
/// Extension methods for the Window class.
/// </summary>
public static class McWindowEx
{
    private static KeyboardControl _keyboard = new();
    private static ScrollViewer? _scrollViewer;

    public static KeyboardControl Keyboard => _keyboard;

    // Once the keyboard is added to the window, users should use RootFrame to add new content.
    public static Frame RootFrame = new();

    /// <summary>
    /// UIElements for the keyboard.
    /// </summary>
    /// <param name="window"></param>
    public static void AddKeyboard(this Window window, double height, FontFamily? fontFamily = null, double fontSize = 0)
    {
        Grid mainGrid = new()
        {
            RowDefinitions =
            {
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) }
            }
        };

        // Row 0 = ScrollViewer wrapping the RootFrame.
        // ScrollViewer is only enabled when keyboard is visible to prevent scroll issues
        _scrollViewer = new ScrollViewer
        {
            VerticalScrollBarVisibility = ScrollBarVisibility.Disabled,
            HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled,
            Content = RootFrame
        };
        Grid.SetRow(_scrollViewer, 0);

        // Row 1 = Keyboard
        _keyboard.Visibility = Visibility.Collapsed;
        _keyboard.HandleFocusManager = true;
        _keyboard.Height = height;
        if (fontFamily != null) { _keyboard.KeyFontFamily = fontFamily; }
        if (fontSize > 0) { _keyboard.KeyFontSize = fontSize; }
        Grid.SetRow(_keyboard, 1);

        // Subscribe to keyboard visibility changes to enable/disable scrolling
        _keyboard.RegisterPropertyChangedCallback(UIElement.VisibilityProperty, OnKeyboardVisibilityChanged);

        mainGrid.Children.Add(_scrollViewer);
        mainGrid.Children.Add(_keyboard);

        window.Content = mainGrid;
    }

    private static void OnKeyboardVisibilityChanged(DependencyObject sender, DependencyProperty dp)
    {
        if (_scrollViewer == null) return;

        // Enable vertical scrolling only when keyboard is visible
        _scrollViewer.VerticalScrollBarVisibility = _keyboard.Visibility == Visibility.Visible
            ? ScrollBarVisibility.Auto
            : ScrollBarVisibility.Disabled;
    }

    /// <summary>
    /// Attached property to set the keyboard type.
    /// </summary>
    public static readonly DependencyProperty KeyboardIdProperty = DependencyProperty.RegisterAttached(
        nameof(KeyboardId),
        typeof(string),
        typeof(McWindowEx),
        new PropertyMetadata("None"));

    public static void SetKeyboardType(DependencyObject element, string value)
    {
        element.SetValue(KeyboardIdProperty, value);
    }

    public static string GetKeyboardType(DependencyObject element)
    {
        return (string)element.GetValue(KeyboardIdProperty);
    }
}
