using Microsoft.UI;
using Microsoft.UI.Xaml.Data;
using UnoKeyboard.Models;
using Windows.Foundation;

namespace UnoKeyboard.Controls;

public sealed partial class KeyControl : Panel
{
    private Border ControlBorder { get; set; }

    private KeyboardControl Keyboard { get; set; }

    public event EventHandler<KeyEventArgs>? KeyClicked;

    public KeyControl(KeyboardControl keyboard)
    {
        Background = new SolidColorBrush(Colors.Transparent);
        VerticalAlignment = VerticalAlignment.Center;
        HorizontalAlignment = HorizontalAlignment.Center;

        Keyboard = keyboard;

        Children.Add(
            ControlBorder = new Border()
            {
                Margin = Keyboard.KeyMargin,
                Background = Keyboard.KeyBackground,
                BorderBrush = Keyboard.KeyBorderBrush,
                BorderThickness = Keyboard.KeyBorderThickness,
                CornerRadius = new CornerRadius(5),
            });

        // Binds ControlBorder.Margin to Keyboard.KeyMargin
        BindingOperations.SetBinding(ControlBorder, Border.MarginProperty, new Binding()
        {
            Source = Keyboard,
            Path = new PropertyPath("KeyMargin"),
            Mode = BindingMode.OneWay,
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
        if (Key.VKey.KType == KeyType.Text)
        {
            SetContentText();
        }
        else if (Key.VKey.KType == KeyType.Symbols 
                || Key.VKey.KType == KeyType.Alfa)
        {
            SetContentText(Key.VKey.UChar);
        }
        else
        {
            SetContentPath(Key);
        }

        UpdateLayout();
    }

    private void SetContentText(string? text = null)
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

        if (Key.VKey.KType == KeyType.Text)
        {
            // Binds tb.Text to KeyText
            BindingOperations.SetBinding(tb, TextBlock.TextProperty, new Binding()
            {
                Source = this,
                Path = new PropertyPath("KeyText"),
                Mode = BindingMode.OneWay,
            });
        }
        else
        {
            tb.Text = text;
        }

        // Binds tb.Foreground to Keyboard.KeyForeground
        BindingOperations.SetBinding(tb, TextBlock.ForegroundProperty, new Binding()
        {
            Source = Keyboard,
            Path = new PropertyPath("KeyForeground"),
            Mode = BindingMode.OneWay,
        });

        ControlBorder.Child = tb;
    }

    private void SetContentPath(KeyModel key)
    {
        ControlBorder.Child = null;

        var path = new Microsoft.UI.Xaml.Shapes.Path()
        {
            Stroke = Keyboard.KeyForeground,
            StrokeThickness = 1,
            Height = key.VKey.GeometryHeight,
            Width = key.VKey.GeometryWidth,
            Data = key.VKey.Geometry,
        };

        // Binds path.Stroke to Keyboard.KeyForeground
        BindingOperations.SetBinding(path, Microsoft.UI.Xaml.Shapes.Path.StrokeProperty, new Binding()
        {
            Source = Keyboard,
            Path = new PropertyPath("KeyForeground"),
            Mode = BindingMode.OneWay,
        });

        var size =  CalculateFontSize();

        // Content resized by the Viewbox
        ControlBorder.Child = new Viewbox()
        {
            Height = size.Height,
            Stretch = Stretch.Uniform,
            Child = path
        };
    }

    private Size CalculateFontSize()
    {
        // Measure the height of a TextBlock with a single character to set the size of the path
        var textBlock = new TextBlock
        {
            Text = IsShiftActive ? "A" : "a",
            FontFamily = Keyboard.KeyFontFamily,
            FontSize = Keyboard.KeyFontSize,
            VerticalAlignment = VerticalAlignment.Center,
            HorizontalAlignment = HorizontalAlignment.Center,
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