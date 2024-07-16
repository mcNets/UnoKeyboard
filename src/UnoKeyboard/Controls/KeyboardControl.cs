using UnoKeyboard.Models;
using Windows.Foundation;
using Windows.UI.Notifications;

namespace UnoKeyboard.Controls;

public sealed partial class KeyboardControl : Panel
{
    public KeyboardControl()
    {
        Background = (Brush)Application.Current.Resources["SystemControlBackgroundBaseLowBrush"];
        IsTabStop = true;

        // By default, the control will use the first keyboard of the "en" language
        Keyboard = Keyboards.Keyboard["en"][0];
    }

    protected override Size MeasureOverride(Size availableSize)
    {
        if (Children.Count > 0 && Children[0] is Grid board)
        {
            for (int i = 0; i < board.Children.Count; i++)
            {
                board.Children[i].Measure(availableSize);
            }
        }

        return base.MeasureOverride(availableSize);
    }

    protected override Size ArrangeOverride(Size finalSize)
    {
        if (Children.Count > 0 && Children[0] is Grid board)
        {
            board.Arrange(new Rect(0, 0, finalSize.Width, finalSize.Height));
        }

        return base.ArrangeOverride(finalSize);
    }

    private void InvalidateKeyboard()
    {
        Children.Clear();

        if (Keyboard == null) { return; }

        switch (Keyboard.Type)
        {
            case KeyboardType.Numeric:
                BuildNumericKeyboard();
                break;

            default:
                BuildAlfanumericKeyboard(0);
                break;
        }

        // Forces InvalidateMeasure and InvalidateArrange.
        UpdateLayout();
    }

    private void BuildNumericKeyboard()
    {
        throw new NotImplementedException();
    }

    private void BuildAlfanumericKeyboard(int page)
    {
        // Adds a 4 x 10 grid to the control
        var grid = new Grid();
        for (int i = 0; i < 4; i++)
        {
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
        };
        for (int i = 0; i < 10; i++)
        {
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
        };

        var keys = Keyboard.Keys.Where(k => k.Page == page).ToList();
        if (keys.Count == 0) { return; }

        for (int i = 0; i < keys.Count; i++)
        { 
            var k = new KeyControl() 
            { 
                Key = keys[i], 
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch
            };

            grid.Children.Add(k);
            Grid.SetRow(k, keys[i].Row);
            Grid.SetColumn(k, keys[i].Col);
        }

        Children.Add(grid);
    }
}
