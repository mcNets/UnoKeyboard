using Microsoft.UI;
using Microsoft.UI.Xaml.Data;
using Windows.Foundation;

namespace UnoKeyboard.Controls;

public sealed partial class KeyControl : Panel
{
    private Border ControlBorder { get; set; }
    private KeyboardControl Keyboard { get; set; }

    public KeyControl(KeyboardControl keyboard)
    {
        Keyboard = keyboard;

        Background = new SolidColorBrush(Colors.Transparent);

        Children.Add(
            ControlBorder = new Border()
            {
                Margin = new Thickness(2),
                Background = Keyboard.KeyBackground,
                BorderBrush = Keyboard.KeyBorderBrush,
                BorderThickness = Keyboard.KeyBorderThickness,
                CornerRadius = this.CornerRadius,
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
    }

    private void InvalidateKey()
    {
        ControlBorder.Child = null;

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
        var tb = new TextBlock()
        {
            Foreground = Keyboard.KeyForeground,
            FontFamily = this.FontFamily,
            FontSize = this.FontSize,
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
        };

        // binding tb.Text to KeyText
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
        // Measure the height of a text block with a single character to set the size of the path
        var textBlock = new TextBlock
        {
            Text = "A",
            FontFamily = this.FontFamily,
            FontSize = this.FontSize,
        };

        textBlock.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
        var textBlockHeight = textBlock.DesiredSize.Height;

        var path = new Microsoft.UI.Xaml.Shapes.Path()
        {
            Stroke = Keyboard.KeyForeground,
            StrokeThickness = 1,
            Stretch = Stretch.Uniform,
            Height = 10,
            Width = 10,
            Data = KeyPathGeometry.Shift,
        };

        // Binds path.Stroke to Keyboard.KeyForeground
        BindingOperations.SetBinding(path, Microsoft.UI.Xaml.Shapes.Path.StrokeProperty, new Binding()
        {
            Source = Keyboard,
            Path = new PropertyPath("KeyForeground"),
            Mode = BindingMode.OneWay,
        });

        ControlBorder.Child = new Viewbox()
        {
            Height = textBlockHeight,
            Child = path
        };
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
        if (ControlBorder.Child is Viewbox viewBox)
        {
            //viewBox.Child?.Arrange(new Rect(0, 0, finalSize.Width, finalSize.Height));
        }
        return base.ArrangeOverride(finalSize);
    }
 

}