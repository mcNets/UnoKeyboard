using UnoKeyboard.Controls;

namespace UnoKeyboard;

using KeyboardId = System.String;

public static class McWindowEx
{
    private static KeyboardControl _keyboard = new();

    public static KeyboardControl Keyboard => _keyboard;

    /// <summary>
    /// Once the keyboard is added to the window users should use RootFrame to navigate.
    /// </summary>
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

        // Row 0 = ScrollViewer warpping the RootFram.
        ScrollViewer scrollViewer = new()
        {
            VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
            HorizontalScrollBarVisibility = ScrollBarVisibility.Auto,
            Content = RootFrame
        };
        Grid.SetRow(scrollViewer, 0);

        // Row 1 = Keyboard
        _keyboard.Visibility = Visibility.Collapsed;
        _keyboard.HandleFocusManager = true;
        _keyboard.Height = height;
        if (fontFamily != null) { _keyboard.KeyFontFamily = fontFamily; }
        if (fontSize > 0) { _keyboard.KeyFontSize = fontSize; }
        Grid.SetRow(_keyboard, 1);

        mainGrid.Children.Add(scrollViewer);
        mainGrid.Children.Add(_keyboard);

        window.Content = mainGrid;
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
