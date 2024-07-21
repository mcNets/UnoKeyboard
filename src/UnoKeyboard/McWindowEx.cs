using Microsoft.UI.Xaml.Input;
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
        //mainGrid.GettingFocus += _keyboard.OnGettingFocus;
        //mainGrid.LosingFocus += _keyboard.OnLosingFocus;
        mainGrid.GettingFocus += OnGettingFocus;
        mainGrid.LosingFocus += OnLosingFocus;

        // Row 0 = ScrollViewer warpping the original content.
        ScrollViewer scrollViewer = new()
        {
            VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
            HorizontalScrollBarVisibility = ScrollBarVisibility.Auto,
            Content = RootFrame
        };
        Grid.SetRow(scrollViewer, 0);

        // Row 1 = Keyboard
        _keyboard.Visibility = Visibility.Collapsed;
        _keyboard.Height = height;
        if (fontFamily != null) { _keyboard.KeyFontFamily = fontFamily; }
        if (fontSize > 0) { _keyboard.KeyFontSize = fontSize; }
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
            var kbrType = textBox.GetValue(KeyboardIdProperty);

            if (kbrType is string kbrId)
            {
                if (kbrId == "None")
                {
                    if (_keyboard.Keyboard.Id != Keyboards.Keyboard.First().Key) 
                    {
                        _keyboard.Keyboard = Keyboards.Keyboard.First().Value;
                    }
                }
                else if (_keyboard.Keyboard.Id != kbrId)
                {
                    _keyboard.Keyboard = Keyboards.Keyboard[kbrId];
                }
            }
            
            _keyboard.TextControl = textBox;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                _keyboard.IsShiftActive = true;
            }

            _keyboard.Visibility = Visibility.Visible;
        }
    }


    /// <summary>
    /// Represents the type of keyboard to be used.
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
