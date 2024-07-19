using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Windows.Foundation;

namespace UnoKeyboard.Controls;

public sealed partial class KeyboardControl : Panel
{
    // Used to center every row of keys
    private List<double> _rowWidth = [];

    public KeyboardControl()
    {
        Visibility = Visibility.Collapsed;

        ApplyThemedResources();

        ActualThemeChanged += (s, e) => { ApplyThemedResources(); };

        Keyboard = Keyboards.Keyboard["en-alfa"];
    }

    private void ApplyThemedResources()
    {
        Background = (Brush)Application.Current.Resources["ControlSolidFillColorDefaultBrush"];
        KeyBackground = (Brush)Application.Current.Resources["ControlFillColorDefaultBrush"];
        KeyForeground = (Brush)Application.Current.Resources["TextFillColorPrimaryBrush"];
        KeyBorderBrush = (Brush)Application.Current.Resources["ControlStrokeColorSecondaryBrush"];
        KeySpecialKeyBackground = (Brush)Application.Current.Resources["AccentFillColorTertiaryBrush"];
    }

    protected override Size MeasureOverride(Size availableSize)
    {
        if (Keyboard == null)
        {
            return base.MeasureOverride(availableSize);
        }

        double keyWidth = (availableSize.Width - (Padding * 2)) / Keyboard.MaxKeys;
        double keyHeight = (availableSize.Height - (Padding * 2)) / Keyboard.Lines;

        // Create and initialize the row width list
        _rowWidth.Clear();
        for (int i = 0; i < Keyboard.Lines; i++)
        {
            _rowWidth.Add(0);
        }

        for (int i = 0; i < Children.Count; i++)
        {
            if (Children[i] is KeyControl key)
            {
                key.Width = keyWidth * key.Key.WithFactor;
                key.Height = keyHeight;

                _rowWidth[key.Key.Row] += key.Width;

                key.Measure(new Size(key.Width, key.Height));
            }
        }

        return base.MeasureOverride(availableSize);
    }

    protected override Size ArrangeOverride(Size finalSize)
    {
        if (Keyboard == null || Children.Count == 0 )
        {
            return base.ArrangeOverride(finalSize);
        }

        double innerWidth = finalSize.Width - (Padding * 2);

        // get an ordered list of KeyControl children
        var childs = Children
                        .Where(c => c is KeyControl)
                        .OrderBy(c => (c as KeyControl)?.Key.Row)
                        .ThenBy(c => (c as KeyControl)?.Key.Col)
                        .ToList();


        double posX = 0;
        double posY = Padding;

        for (int i = 0; i < childs.Count; i++)
        {
            if (childs[i] is KeyControl key)
            {
                if (key.Key.Col == 0)
                {
                    posX = Padding + ((innerWidth - _rowWidth[key.Key.Row]) / 2.0);
                    posY = Padding + (key.Height * key.Key.Row);
                }

                // double x = (key.Width * key.Key.Col) + Padding + ((innerWidth - _rowWidth[key.Key.Row]) / 2.0);
                // double y = (key.Height * key.Key.Row) + Padding;
                // key.Arrange(new Rect(x, y, key.Width, key.Height));
                key.Arrange(new Rect(posX, posY, key.Width, key.Height));
                posX += key.Width;
            }
        }

        return base.ArrangeOverride(finalSize);
    }

    private void InvalidateKeyboard()
    {
        if (Keyboard == null)
        {
            return;
        }

        // Unregister the event to avoid memory leaks
        if (Children.Count > 0)
        {
            for (int i = 0; i < Children.Count; i++)
            {
                if (Children[i] is KeyControl key)
                {
                    key.KeyClicked -= OnKeyClicked;
                }
            }
        }

        Children.Clear();

        var keys = Keyboard.Keys
            .Where(k => k.Page == CurrentPage)
            .OrderBy(k => k.Row)
            .ThenBy(k => k.Col)
            .ToList();

        for (int x = 0; x < keys.Count; x++)
        {
            var key = new KeyControl(this)
            {
                Key = keys[x],
            };
            key.KeyClicked += OnKeyClicked;
            Children.Add(key);
        }

        // Forces InvalidateMeasure and InvalidateArrange.
        UpdateLayout();
    }
}
