using UnoKeyboard.Models;

namespace UnoKeyboard.Controls;

public sealed partial class KeyboardControl
{
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
            key.InvalidateKeyboard();
        }
    }
}
