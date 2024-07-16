using Microsoft.UI.Xaml.Data;

namespace UnoKeyboard.Controls;

public sealed partial class KeyControl : Control
{
    private Grid? _root;
    private Border? _border;
    private TextBlock? _keyText;

    public KeyControl()
    {
        DefaultStyleKey = typeof(KeyControl);

        KeyValues = ["A", "a"];
        IsShiftActive = true;
        KeyText = KeyValues[0];
    }

    public event EventHandler<KeyEventArgs>? Click;

    override protected void OnApplyTemplate()
    {
        base.OnApplyTemplate();

        _root = GetTemplateChild("PART_Root") as Grid;
        ArgumentNullException.ThrowIfNull(_root, nameof(_root));

        _root.Tapped += (s, e) => Click?.Invoke(this, new KeyEventArgs(KeyId, KeyText, IsShiftActive));

        _root.PointerPressed += (s, e) => Click?.Invoke(this, new KeyEventArgs(KeyId, KeyText, IsShiftActive));

        _border = GetTemplateChild("PART_Border") as Border;
        ArgumentNullException.ThrowIfNull(_border, nameof(_border));

        _keyText = GetTemplateChild("PART_Text") as TextBlock;
        ArgumentNullException.ThrowIfNull(_keyText, nameof(_keyText));

        var binding = new Binding()
        {
            Source = this,
            Path = new PropertyPath("KeyText"),
            Mode = BindingMode.OneWay
        };

        _keyText.SetBinding(TextBlock.TextProperty, binding);
    }

    /// <summary>
    /// KeyId is the identifier for the key.
    /// </summary>
    public string KeyId
    {
        get { return (string)GetValue(KeyIdProperty); }
        set { SetValue(KeyIdProperty, value); }
    }

    public static readonly DependencyProperty KeyIdProperty =
        DependencyProperty.Register(nameof(KeyId),
                                    typeof(string),
                                    typeof(KeyControl),
                                    new PropertyMetadata(string.Empty));

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
                                    new PropertyMetadata(false, OnKeyTextChanged));

    /// <summary>
    /// KeyValues is an array of strings that represent the possible key values.
    /// </summary>
    public string[] KeyValues
    {
        get { return (string[])GetValue(KeyValuesProperty); }
        set { SetValue(KeyValuesProperty, value); }
    }

    public static readonly DependencyProperty KeyValuesProperty =
        DependencyProperty.Register(nameof(KeyValues),
                                    typeof(string[]),
                                    typeof(KeyControl),
                                    new PropertyMetadata(new string[] { "A", "a" }, OnKeyTextChanged));

    private static void OnKeyTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is KeyControl key && e.NewValue != null)
        {
            key.KeyText = key.IsShiftActive ? key.KeyValues[0] : key.KeyValues[1];
        }
    }
}
