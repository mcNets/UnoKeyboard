using UnoKeyboard.Models;

namespace UnoKeyboard.Controls;

public sealed partial class KeyControl
{
    /// <summary>
    /// KeyModel assigned to the control
    /// </summary>
    public KeyModel Key
    {
        get { return (KeyModel)GetValue(KeyProperty); }
        set { SetValue(KeyProperty, value); }
    }

    public static readonly DependencyProperty KeyProperty =
        DependencyProperty.Register(nameof(Key), 
                                    typeof(KeyModel), 
                                    typeof(KeyControl), 
                                    new PropertyMetadata(null, OnKeyChanged));

    /// <summary>
    /// IsShiftActive is a flag to indicate if the shift key is active.
    /// </summary>
    public bool IsShiftActive
    {
        get { return (bool)GetValue(IsShiftActiveProperty); }
        set { SetValue(IsShiftActiveProperty, value); }
    }

    public static readonly DependencyProperty IsShiftActiveProperty =
        DependencyProperty.Register(nameof(IsShiftActive),
                                    typeof(bool),
                                    typeof(KeyControl),
                                    new PropertyMetadata(false, OnKeyChanged));


    /// <summary>
    /// When the key or the shift state changes, the text of the key is updated.
    /// </summary>
    /// <param name="d"></param>
    /// <param name="e"></param>
    private static void OnKeyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is KeyControl key && e.NewValue != null)
        {
            key.KeyText = key.IsShiftActive ? char.ConvertFromUtf32(key.Key.UCode) : char.ConvertFromUtf32(key.Key.LCode);
        }
    }

    /// <summary>
    /// Current text of the key.
    /// This property is read-only because it depends on IsShiftActive and KeyValues.
    /// </summary>
    public string KeyText
    {
        get { return (string)GetValue(TextProperty); }
        private set { SetValue(TextProperty, value); }
    }

    public static readonly DependencyProperty TextProperty =
        DependencyProperty.Register(nameof(KeyText),
                                    typeof(string),
                                    typeof(KeyControl),
                                    new PropertyMetadata(string.Empty));
}
