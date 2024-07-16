using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Controls;
using UnoKeyboard.Models;

namespace UnoKeyboard.Controls;

public sealed partial class KeyControl : Control
{
    private Grid? _root;
    private Border? _border;
    private TextBlock? _keyText;
    private FontIcon? _icon;

    public KeyControl()
    {
        DefaultStyleKey = typeof(KeyControl);

        Key = new KeyModel(KeyType.Text, 0, 0, 0, 1, "Q", "q", 0x0051, 0x0071);
        IsShiftActive = true;
        //IsTabStop = true;
    }

    public event EventHandler<KeyEventArgs>? Click;

    override protected void OnApplyTemplate()
    {
        base.OnApplyTemplate();

        _root = GetTemplateChild("PART_Root") as Grid;
        ArgumentNullException.ThrowIfNull(_root, nameof(_root));

        _root.Tapped += (s, e) =>
        {
            Focus(FocusState.Programmatic);
            Click?.Invoke(this, new KeyEventArgs(Key, IsShiftActive));
        };

        _root.PointerPressed += (s, e) =>
        {
            Focus(FocusState.Programmatic);
            Click?.Invoke(this, new KeyEventArgs(Key, IsShiftActive));
        };

        _border = GetTemplateChild("PART_Border") as Border;
        ArgumentNullException.ThrowIfNull(_border, nameof(_border));

        _keyText = GetTemplateChild("PART_Text") as TextBlock;
        ArgumentNullException.ThrowIfNull(_keyText, nameof(_keyText));

        var bindText = new Binding()
        {
            Source = this,
            Path = new PropertyPath("KeyText"),
            Mode = BindingMode.OneWay
        };

        _keyText.SetBinding(TextBlock.TextProperty, bindText);

        _icon = GetTemplateChild("PART_Icon") as FontIcon;
        ArgumentNullException.ThrowIfNull(_icon, nameof(_icon));

        var bindIcon = new Binding()
        {
            Source = this,
            Path = new PropertyPath("Glyph"),
            Mode = BindingMode.OneWay
        };

        _icon.SetBinding(FontIcon.GlyphProperty, bindIcon);

        if (Key.KeyType == KeyType.Text)
        {
            _keyText.Visibility = Visibility.Visible;
            _icon.Visibility = Visibility.Collapsed;
        }
        else
        {
            _keyText.Visibility = Visibility.Collapsed;
            _icon.Visibility = Visibility.Visible;
        }
    }
}
