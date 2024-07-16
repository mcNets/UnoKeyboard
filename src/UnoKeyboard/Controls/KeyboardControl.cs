using Windows.Foundation;

namespace UnoKeyboard.Controls;

public sealed partial class KeyboardControl : Panel
{
    // Used to center every row of keys
    private List<double> _rowWidth = [];

    private double _padding = 15;

    public KeyboardControl()
    {
        Background = (Brush)Application.Current.Resources["SystemControlBackgroundBaseLowBrush"];
        IsTabStop = true;

        // By default, the control will use the first keyboard of the "en" language
        Keyboard = Keyboards.Keyboard["en"][0];
        CurrentPage = 0;
    }

    protected override Size MeasureOverride(Size availableSize)
    {
        double keyWidth = (availableSize.Width - (_padding * 2)) / Keyboard.NKeys;
        double keyHeight = (availableSize.Height - (_padding * 2)) / Keyboard.NLines;

        _rowWidth.Clear();

        for (int i = 0; i < Keyboard.NLines; i++)
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
            Children.Add(new KeyControl() { Key = Keyboard.Keys[x] });
        }
    }
}
