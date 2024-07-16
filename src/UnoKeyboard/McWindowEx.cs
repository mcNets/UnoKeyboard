using Microsoft.UI.Xaml.Input;
using UnoKeyboard.Controls;

namespace UnoKeyboard;

public static class McWindowEx
{
    private static KeyboardControl _keyboard = new();

    /// <summary>
    /// Once the keyboard is added to the window users should use RootFrame to navigate.
    /// </summary>
    public static Frame RootFrame = new();

    /// <summary>
    /// UIElements for the keyboard.
    /// </summary>
    /// <param name="window"></param>
    public static void AddKeyboard(this Window window, double height)
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
        _keyboard.Visibility = Visibility.Collapsed;
        _keyboard.Height = height;
        Grid.SetRow(_keyboard, 1);

        mainGrid.Children.Add(scrollViewer);
        mainGrid.Children.Add(_keyboard);

        window.Content = mainGrid;
    }

    private static void OnGettingFocus2(object? sender, GettingFocusEventArgs args)
    {
        if (args.NewFocusedElement is TextBox textBox
            && _keyboard != null
            && _keyboard.Visibility == Visibility.Collapsed)
        {
            var kbrType = textBox.GetValue(KeyboardTypeProperty);

            _keyboard.Visibility = Visibility.Visible;
        }
    }

    private static void OnLosingFocus2(object? sender, LosingFocusEventArgs args)
    {
        if (args.NewFocusedElement is KeyboardControl || args.NewFocusedElement is KeyControl)
        {
            args.Cancel = true;
            return;
        }

        if (_keyboard != null
            && _keyboard.Visibility == Visibility.Visible)
        {
            _keyboard.Visibility = Visibility.Collapsed;
        }
    }

    /// <summary>
    /// Hides the keyboard when the focus is lost.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    private static void OnLosingFocus(UIElement sender, LosingFocusEventArgs args)
    {
        if ((args.NewFocusedElement is null || args.NewFocusedElement is KeyControl) 
            && args.OldFocusedElement is TextBox)
        {
            args.Cancel = true;
            return;
        }

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
