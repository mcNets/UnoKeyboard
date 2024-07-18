using Windows.Foundation;

namespace UnoKeyboard.Controls;

public sealed partial class KeyboardControl : Panel
{
    // Used to center every row of keys
    private List<double> _rowWidth = [];

    // Padding between the keys and the border of the control
    private double _padding = 15;

    public KeyboardControl()
    {
        ApplyThemedResources();
        
        // By default, the control will use the first keyboard of the dictionary
        Keyboard = Keyboards.Keyboard["en"][0];
        
        ActualThemeChanged += (s,e) => { ApplyThemedResources(); };
    }

    private void ApplyThemedResources()
    {
        Background = (Brush)Application.Current.Resources["ControlSolidFillColorDefaultBrush"];
        KeyBackground = (Brush)Application.Current.Resources["ControlFillColorDefaultBrush"];
        KeyForeground = (Brush)Application.Current.Resources["TextFillColorPrimaryBrush"];
        KeyBorderBrush = (Brush)Application.Current.Resources["ControlStrokeColorSecondaryBrush"];
    }

    protected override Size MeasureOverride(Size availableSize)
    {
        double keyWidth = (availableSize.Width - (_padding * 2)) / Keyboard.MaxKeys;
        double keyHeight = (availableSize.Height - (_padding * 2)) / Keyboard.Lines;

        _rowWidth.Clear();

        for (int i = 0; i < Keyboard.Lines; i++)
        {
            _rowWidth.Add(0);
        }

        for (int i = 0; i < Children.Count; i++)
        {
            if (Children[i] is KeyControl key )
            {
                key.Width = keyWidth;
                key.Height = keyHeight;

                _rowWidth[key.Key.Row] += key.Width;

                key.Measure(new Size(keyWidth, keyHeight));
            }
        }

        return base.MeasureOverride(availableSize);
    }

    protected override Size ArrangeOverride(Size finalSize)
    {
        double realWidth = finalSize.Width - (_padding * 2);

        for (int i = 0; i < Children.Count; i++)
        {
            if (Children[i] is KeyControl key)
            {
                double x = (key.Width * key.Key.Col) + _padding + ((realWidth - _rowWidth[key.Key.Row]) / 2.0);
                double y = (key.Height * key.Key.Row) + _padding;
                key.Arrange(new Rect(x, y, key.Width, key.Height));
            }
        }

        return base.ArrangeOverride(finalSize);
    }

    private void InvalidateKeyboard()
    {
        if (Keyboard == null)
        { return; }

        Children.Clear();

        switch (Keyboard.Type)
        {
            case KeyboardType.Numeric:
                BuildNumericKeyboard();
                break;

            default:
                BuildAlfanumericKeyboard();
                break;
        }

        // Forces InvalidateMeasure and InvalidateArrange.
        UpdateLayout();
    }

    private void BuildNumericKeyboard()
    {
        throw new NotImplementedException();
    }

    private void BuildAlfanumericKeyboard()
    {
        for (int x = 0; x < Keyboard.Keys.Count; x++)
        {
            Children.Add(new KeyControl(this) { Key = Keyboard.Keys[x] });
        }
    }
}
