using Microsoft.UI;
using Microsoft.UI.Xaml.Data;
using UnoKeyboard.Models;
using Windows.Foundation;

namespace UnoKeyboard.Controls;

public sealed partial class KeyControl : Panel
{
    private Border ControlBorder { get; set; }

    private KeyboardControl Keyboard { get; set; }

    public Action<object, KeyEventArgs>? KeyPressed;

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

        // Change key background when the key is pressed
        this.PointerPressed += (s, e) =>
        {
            //ControlBorder.Background = new SolidColorBrush(Colors.DimGray);
            if (ControlBorder.Background is SolidColorBrush originalBrush)
            {
                // Obtener el color original
                var originalColor = originalBrush.Color;

                // Modificar el canal alfa, por ejemplo, al 50%
                var newColor = Windows.UI.Color.FromArgb(50, originalColor.R, originalColor.G, originalColor.B);

                // Aplicar el nuevo color al fondo
                ControlBorder.Background = new SolidColorBrush(newColor);
            }
        };

        this.PointerReleased += (s, e) =>
        {
            ControlBorder.Background = Keyboard.KeyBackground;

            e.Handled = true;

            KeyPressed?.Invoke(this, new KeyEventArgs(Key, IsShiftActive));
        };
    }

    private void InvalidateKey()
    {
        if (Key.VKey.KType == KeyType.Text)
        {
            SetKeyContentText();
        }
        else if (Key.VKey.KType == KeyType.Symbols
                 || Key.VKey.KType == KeyType.Alfa)
        {
            SetKeyContentText(Key.VKey.UChar);
        }
        else
        {
            SetKeyContentPath(Key);
        }
    }

    private void SetKeyContentText(string? text = null)
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

    private void SetKeyContentPath(KeyModel key)
    {
        var size = CalculateFontSize();

        ControlBorder.Child = null;

        Microsoft.UI.Xaml.Shapes.Path? path = (key.VKey.GetPath?.Invoke()) ?? throw new Exception($"Path not found for key '{key.VKey.KeyId}'.");

        path.Stroke = Keyboard.KeyForeground;

        // Binds path.Stroke to Keyboard.KeyForeground
        BindingOperations.SetBinding(path, Microsoft.UI.Xaml.Shapes.Path.StrokeProperty, new Binding()
        {
            Source = Keyboard,
            Path = new PropertyPath("KeyForeground"),
            Mode = BindingMode.OneWay,
        });

        // Content resized by the Viewbox
        ControlBorder.Child = new Viewbox()
        {
            Height = size.Height,
            Stretch = Stretch.Uniform,
            Child = path,
        };
    }

    /// <summary>
    /// Calculates the font size for the 'A' or 'a' character.
    /// It will be used to set the size of the path.
    /// </summary>
    /// <returns></returns>
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

    /// <inheritdoc />
    protected override Size MeasureOverride(Size availableSize)
    {
        ControlBorder.Measure(availableSize);
        ControlBorder.Child?.Measure(availableSize);
        return base.MeasureOverride(availableSize);
    }

    /// <inheritdoc />
    protected override Size ArrangeOverride(Size finalSize)
    {
        ControlBorder.Arrange(new Rect(0, 0, finalSize.Width, finalSize.Height));
        ControlBorder.Child?.Arrange(new Rect(0, 0, finalSize.Width, finalSize.Height));
        return base.ArrangeOverride(finalSize);
    }
}