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

    private static void OnKeyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is KeyControl ctl && e.NewValue != null)
        {
            ctl.KeyText = ctl.IsShiftActive ? ctl.Key.VKey.UValue : ctl.Key.VKey.LValue;
            ctl.InvalidateKey();
        }
    }

    /// <summary>
    /// Value represented in the key
    /// </summary>    
    public string KeyText
    {
        get { return (string)GetValue(KeyTextProperty); }
        set { SetValue(KeyTextProperty, value); }
    }

    public static readonly DependencyProperty KeyTextProperty =
        DependencyProperty.Register(nameof(KeyText), 
                                    typeof(string), 
                                    typeof(KeyControl), 
                                    new PropertyMetadata(string.Empty));

    /// <summary>
    /// IsShiftActive is a flag to indicate wheather use UCode or LCode of the KeyModel.
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
                                    new PropertyMetadata(false, OnShiftChanged));

    private static void OnShiftChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is KeyControl ctl && e.NewValue != null)
        {
            if (ctl.Key == null || ctl.Key.VKey.KType != KeyType.Text)
            {
                return;
            }

            ctl.KeyText = ctl.IsShiftActive ? ctl.Key.VKey.UValue : ctl.Key.VKey.LValue;
        }
    }
}
