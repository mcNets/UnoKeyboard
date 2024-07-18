using Microsoft.UI;
using Microsoft.UI.Xaml.Data;
using Windows.Foundation;

namespace UnoKeyboard.Controls;

public sealed partial class KeyControl : Panel
{
    private Border ControlBorder { get; set; }
    private KeyboardControl Keyboard { get; set; }

    public event EventHandler<KeyEventArgs>? KeyClicked;

    public KeyControl(KeyboardControl keyboard)
    {
        Keyboard = keyboard;
        IsTabStop = true;

        Background = new SolidColorBrush(Colors.Transparent);

        Children.Add(
            ControlBorder = new Border()
            {
                Margin = new Thickness(2),
                Background = Keyboard.KeyBackground,
                BorderBrush = Keyboard.KeyBorderBrush,
                BorderThickness = Keyboard.KeyBorderThickness,
                CornerRadius = new CornerRadius(5),
            });

        // Binds ControlBorder.Background to Keyboard.KeyBackground
        BindingOperations.SetBinding(ControlBorder, Border.BackgroundProperty, new Binding()
        {
            Source = Keyboard,
            Path = new PropertyPath("KeyBackground"),
            Mode = BindingMode.OneWay,
        });

        // Binds ControlBorder.BorderBrush to Keyboard.KeyBorderBrush
        BindingOperations.SetBinding(ControlBorder, Border.BorderBrushProperty, new Binding()
        {
            Source = Keyboard,
            Path = new PropertyPath("KeyBorderBrush"),
            Mode = BindingMode.OneWay,
        });

        // Binds ControlBorder.BorderThickness to keyboard.KeyBorderThickness
        BindingOperations.SetBinding(ControlBorder, Border.BorderThicknessProperty, new Binding()
        {
            Source = Keyboard,
            Path = new PropertyPath("KeyBorderThickness"),
            Mode = BindingMode.OneWay,
        });

        // Binds IsShiftActive to the Keyboard.IsShiftActive
        BindingOperations.SetBinding(this, KeyControl.IsShiftActiveProperty, new Binding()
        {
            Source = Keyboard,
            Path = new PropertyPath("IsShiftActive"),
            Mode = BindingMode.OneWay,
        });

        this.Tapped += (s, e) =>
        {
            Focus(FocusState.Programmatic);
            KeyClicked?.Invoke(this, new KeyEventArgs(Key, IsShiftActive));
        };
    }

    private void InvalidateKey()
    {
        if (Key.KeyType == KeyType.Text)
        {
            SetContentText();
        }
        else
        {
            SetContentPath();
        }

        UpdateLayout();
    }

    private void SetContentText()
    {
        ControlBorder.Child = null;

        var tb = new TextBlock()
        {
            Foreground = Keyboard.KeyForeground,
            FontFamily = Keyboard.KeyFontFamily,
            FontSize = Keyboard.KeyFontSize,
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
        };

        // Binds tb.Text to KeyText
        BindingOperations.SetBinding(tb, TextBlock.TextProperty, new Binding()
        {
            Source = this,
            Path = new PropertyPath("KeyText"),
            Mode = BindingMode.OneWay,
        });

        // Binds tb.Foreground to Keyboard.KeyForeground
        BindingOperations.SetBinding(tb, TextBlock.ForegroundProperty, new Binding()
        {
            Source = Keyboard,
            Path = new PropertyPath("KeyForeground"),
            Mode = BindingMode.OneWay,
        });

        ControlBorder.Child = tb;
    }

    private void SetContentPath()
    {
        ControlBorder.Child = null;

        PathGeometry pathGeometry = new();
        double with = 10;
        double height = 10;

        switch (Key.KeyType)
        {
            case  KeyType.Shift:
                with = 10;
                height = 10;
                pathGeometry = KeyPathGeometry.Shift;
                break;

            case KeyType.Backspace:
                with = 10;
                height = 16;
                pathGeometry = KeyPathGeometry.Backspace;
                break;

            case KeyType.Enter:
                with = 10;
                height = 12;
                pathGeometry = KeyPathGeometry.Enter;
                break;

            case KeyType.Space:
                with = 10;
                height = 10;
                break;
        }

        var path = new Microsoft.UI.Xaml.Shapes.Path()
        {
            Stroke = Keyboard.KeyForeground,
            StrokeThickness = 1,
            Height = with,
            Width = height,
            Data = pathGeometry,
        };

        // Binds path.Stroke to Keyboard.KeyForeground
        BindingOperations.SetBinding(path, Microsoft.UI.Xaml.Shapes.Path.StrokeProperty, new Binding()
        {
            Source = Keyboard,
            Path = new PropertyPath("KeyForeground"),
            Mode = BindingMode.OneWay,
        });

        var size = CalculateFontSize();

        ControlBorder.Child = new Viewbox()
        {
            VerticalAlignment = VerticalAlignment.Center,
            HorizontalAlignment = HorizontalAlignment.Center,
            Height = size.Height,
            Stretch = Stretch.Uniform,
            Child = path
        };
    }

    private Size CalculateFontSize()
    {
        // Measure the height of a text block with a single character to set the size of the path
        var textBlock = new TextBlock
        {
            Text = IsShiftActive ? "A" : "a",
            FontFamily = Keyboard.KeyFontFamily,
            FontSize = Keyboard.KeyFontSize,
        };

        textBlock.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
        return textBlock.DesiredSize;
    }

    protected override Size MeasureOverride(Size availableSize)
    {
        ControlBorder.Measure(availableSize);
        ControlBorder.Child?.Measure(availableSize);
        return base.MeasureOverride(availableSize);

    }

    protected override Size ArrangeOverride(Size finalSize)
    {
        ControlBorder.Arrange(new Rect(0, 0, finalSize.Width, finalSize.Height));
        ControlBorder.Child?.Arrange(new Rect(0, 0, finalSize.Width, finalSize.Height));
        return base.ArrangeOverride(finalSize);
    }
 

}