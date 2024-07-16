using Microsoft.UI.Xaml.Input;

namespace UnoKeyboard;

public static class McWindowEx
{
    private static Border _keyboard = new();

    /// <summary>
    /// Once the keyboard is added to the window users should use RootFrame to navigate.
    /// </summary>
    public static Frame RootFrame = new();

    /// <summary>
    /// UIElements for the keyboard.
    /// </summary>
    /// <param name="window"></param>
    public static void AddKeyboard(this Window window)
    {
        Grid mainGrid = new()
        {
            RowDefinitions =
            {
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) }
            }
        };
        mainGrid.GettingFocus += OnGettingFocus;
        mainGrid.LosingFocus += OnLosingFocus;

        // Row 0 = ScrollViewer warpping the original content.
        ScrollViewer scrollViewer = new()
        {
            VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
            Content = RootFrame
        };
        Grid.SetRow(scrollViewer, 0);

        // Row 1 = Keyboard
        _keyboard = new Border
        {
            Name = "MyKeyboard",
            Background = new SolidColorBrush(Microsoft.UI.Colors.DarkGray),
            Height = 300,
            BorderThickness = new Thickness(5),
            BorderBrush = new SolidColorBrush(Microsoft.UI.Colors.Violet),
            Visibility = Visibility.Collapsed,
            CornerRadius = new CornerRadius(5),
        };
        Grid.SetRow(_keyboard, 1);

        mainGrid.Children.Add(scrollViewer);
        mainGrid.Children.Add(_keyboard);

        window.Content = mainGrid;
    }

    /// <summary>
    /// Hides the keyboard when the focus is lost.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    private static void OnLosingFocus(UIElement sender, LosingFocusEventArgs args)
    {
        if (_keyboard != null
            && _keyboard.Visibility == Visibility.Visible)
        {
            _keyboard.Visibility = Visibility.Collapsed;
        }
    }

    /// <summary>
    /// Shows the keyboard when the focus is gained and the focused element is a TextBox.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    private static void OnGettingFocus(UIElement sender, GettingFocusEventArgs args)
    {
        if (args.NewFocusedElement is TextBox textBox
            && _keyboard != null 
            && _keyboard.Visibility == Visibility.Collapsed)
        {
            var kbrType = textBox.GetValue(KeyboardTypeProperty);

            _keyboard.Visibility = Visibility.Visible;
        }
    }

    /// <summary>
    /// Represents the type of keyboard to be used.
    /// </summary>
    public static readonly DependencyProperty KeyboardTypeProperty = DependencyProperty.RegisterAttached(
        "KeyboardType",
        typeof(KeyboardType),
        typeof(McWindowEx),
        new PropertyMetadata("Alfanumeric"));

    public static void SetKeyboardType(DependencyObject element, KeyboardType value)
    {
        element.SetValue(KeyboardTypeProperty, value);
    }

    public static KeyboardType GetKeyboardType(DependencyObject element)
    {
        return (KeyboardType)element.GetValue(KeyboardTypeProperty);
    }
}
