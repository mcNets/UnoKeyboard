using UnoKeyboard.Models;

namespace UnoKeyboard.Controls;

public sealed partial class KeyControl
{
    /// <summary>
    /// Read-only property that returns the current text of the key.
    /// </summary>
    //public string KeyText => IsShiftActive ? char.ConvertFromUtf32(Key.LCode) : char.ConvertFromUtf32(Key.UCode);



    public string KeyText
    {
        get { return (string)GetValue(KeyTextProperty); }
        set { SetValue(KeyTextProperty, value); }
    }

    // Using a DependencyProperty as the backing store for KeyText.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty KeyTextProperty =
        DependencyProperty.Register("KeyText", typeof(string), typeof(KeyControl), new PropertyMetadata(string.Empty));



    /// <summary>
    /// KeyModel assigned to the control
    /// </summary>
    public KeyModel Key
    {
        get { return (KeyModel)GetValue(KeyProperty); }
        set { SetValue(KeyProperty, value); }
    }

    public static readonly DependencyProperty KeyProperty =
        DependencyProperty.Register(nameof(Key),
                                    typeof(KeyModel),
                                    typeof(KeyControl),
                                    new PropertyMetadata(null, OnKeyChanged));

    private static void OnKeyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is KeyControl ctl && e.NewValue != null)
        {
            ctl.KeyText = ctl.IsShiftActive ? char.ConvertFromUtf32(ctl.Key.UCode) : char.ConvertFromUtf32(ctl.Key.LCode);
            ctl.InvalidateKey();
        }
    }

    /// <summary>
    /// IsShiftActive is a flag to indicate wheather use UCode or LCode of the KeyModel.
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
                                    new PropertyMetadata(false, OnShiftChanged));

    private static void OnShiftChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is KeyControl ctl && e.NewValue != null)
        {
            if (ctl.Key == null || ctl.Key.KeyType != KeyType.Text)
            {
                return;
            }

            if (ctl.ControlBorder.Child is TextBox textBox)
            {
                ctl.KeyText = ctl.IsShiftActive ? char.ConvertFromUtf32(ctl.Key.UCode) : char.ConvertFromUtf32(ctl.Key.LCode);
                //textBox.Text = ctl.KeyText;
            }
        }
    }

    public Brush BorderBrush
    {
        get { return (Brush)GetValue(BorderBrushProperty); }
        set { SetValue(BorderBrushProperty, value); }
    }

    public Brush Foreground
    {
        get { return (Brush)GetValue(ForegroundProperty); }
        set { SetValue(ForegroundProperty, value); }
    }

    public static readonly DependencyProperty ForegroundProperty =
        DependencyProperty.Register(nameof(Foreground), 
                                    typeof(Brush), 
                                    typeof(KeyControl), 
                                    new PropertyMetadata(null));

    public static readonly DependencyProperty BorderBrushProperty =
        DependencyProperty.Register(nameof(BorderBrush), 
                                    typeof(Brush), 
                                    typeof(KeyControl), 
                                    new PropertyMetadata(null));

    public Thickness BorderThickness
    {
        get { return (Thickness)GetValue(BorderStrokeThickness); }
        set { SetValue(BorderStrokeThickness, value); }
    }

    public static readonly DependencyProperty BorderStrokeThickness =
        DependencyProperty.Register(nameof(BorderThickness), 
                                    typeof(Thickness), 
                                    typeof(KeyControl), 
                                    new PropertyMetadata(new Thickness(0)));

    public CornerRadius CornerRadius
    {
        get { return (CornerRadius)GetValue(CornerRadiusProperty); }
        set { SetValue(CornerRadiusProperty, value); }
    }

    public static readonly DependencyProperty CornerRadiusProperty =
        DependencyProperty.Register(nameof(CornerRadius), 
                                    typeof(CornerRadius), 
                                    typeof(KeyControl), 
                                    new PropertyMetadata(new CornerRadius(5)));

    public FontFamily FontFamily
    {
        get { return (FontFamily)GetValue(FontFamilyProperty); }
        set { SetValue(FontFamilyProperty, value); }
    }

    public static readonly DependencyProperty FontFamilyProperty =
        DependencyProperty.Register(nameof(FontFamily), 
                                    typeof(FontFamily), 
                                    typeof(KeyControl), 
                                    new PropertyMetadata(new FontFamily("Segoe UI")));

    public double FontSize
    {
        get { return (double)GetValue(FontSizeProperty); }
        set { SetValue(FontSizeProperty, value); }
    }

    public static readonly DependencyProperty FontSizeProperty =
        DependencyProperty.Register(nameof(FontSize), 
                                    typeof(double), 
                                    typeof(KeyControl), 
                                    new PropertyMetadata(14.0));

    public Brush KeyBackground
    {
        get { return (Brush)GetValue(KeyBackgroundProperty); }
        set { SetValue(KeyBackgroundProperty, value); }
    }

    public static readonly DependencyProperty KeyBackgroundProperty =
        DependencyProperty.Register(nameof(KeyBackground), 
                                    typeof(Brush), 
                                    typeof(KeyControl), 
                                    new PropertyMetadata(null));



}
