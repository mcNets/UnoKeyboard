using UnoKeyboard.Models;

namespace UnoKeyboard.Controls;

public sealed partial class KeyboardControl
{
    private int _currentPage = 0;

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

    /// <summary>
    /// Current page of the current keyboard
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
}
