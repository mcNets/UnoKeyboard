using Microsoft.UI;
using Microsoft.UI.Xaml.Input;
using Windows.Data.Text;

namespace UnoKeyboard.Controls;

public sealed partial class KeyboardControl
{
    public void OnLosingFocus(UIElement sender, LosingFocusEventArgs args)
    {
        if ((args.NewFocusedElement is KeyControl)
            && Visibility == Visibility.Visible)
        {
            args.Cancel = true;
            return;
        }

        if (Visibility == Visibility.Visible)
        {
            _currentTextBox = null;

            Visibility = Visibility.Collapsed;
        }
    }

    public void OnGettingFocus(UIElement sender, GettingFocusEventArgs args)
    {
        if (args.NewFocusedElement is TextBox textBox
            && Visibility == Visibility.Collapsed)
        {
            _currentTextBox = textBox;

            var kbrType = textBox.GetValue(McWindowEx.KeyboardTypeProperty);
            if (kbrType != null)
            {

            }


            Visibility = Visibility.Visible;
        }
    }

    private void OnKeyClicked(object? sender, KeyEventArgs e)
    {
        int index;

        if (_currentTextBox == null)
        {
            return;
        }

        switch (e.Key.KeyType )
        {
            case KeyType.Shift:
                IsShiftActive = !IsShiftActive;
                break;

            case KeyType.Backspace:
                index = _currentTextBox.SelectionStart;
                if (index > 0)
                {
                    _currentTextBox.Text = _currentTextBox.Text.Remove(index - 1, 1);
                    _currentTextBox.SelectionStart = index - 1;
                }
                break;

            case KeyType.Enter:
                break;

            case KeyType.Space:
                _currentTextBox.Text += " ";
                break;

            default:
                index = _currentTextBox.SelectionStart;
                _currentTextBox.Text = _currentTextBox.Text.Insert(index, IsShiftActive ? e.Key.UChar : e.Key.LChar);
                _currentTextBox.SelectionStart = index + 1; 
                break;
        }
        
    }
}
