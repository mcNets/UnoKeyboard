using Microsoft.UI;
using Microsoft.UI.Xaml.Input;
using Windows.Data.Text;

namespace UnoKeyboard.Controls;

public sealed partial class KeyboardControl
{
    //public void OnLosingFocus(UIElement sender, LosingFocusEventArgs args)
    //{
    //    if ((args.NewFocusedElement is KeyControl)
    //        && Visibility == Visibility.Visible)
    //    {
    //        args.Cancel = true;
    //        return;
    //    }

    //    if (Visibility == Visibility.Visible)
    //    {
    //        TextControl = null;

    //        Visibility = Visibility.Collapsed;
    //    }
    //}

    //public void OnGettingFocus(UIElement sender, GettingFocusEventArgs args)
    //{
    //    if (args.NewFocusedElement is TextBox textBox
    //        && Visibility == Visibility.Collapsed)
    //    {
    //        TextControl = textBox;

    //        var kbrType = textBox.GetValue(McWindowEx.KeyboardIdProperty);
    //        if (kbrType != null)
    //        {

    //        }

    //        Visibility = Visibility.Visible;
    //    }
    //}

    private void OnKeyClicked(object? sender, KeyEventArgs e)
    {
        int currentPos;

        if (TextControl == null || e.Key == null)
        {
            return;
        }

        switch (e.Key.VKey.KType)
        {
            case KeyType.Left:
                currentPos = TextControl.SelectionStart;
                if (currentPos > 0)
                {
                    TextControl.SelectionStart = currentPos - 1;
                    TextControl.SelectionLength = 0;
                }
                break;

            case KeyType.Right:
                currentPos = TextControl.SelectionStart;
                if (currentPos < TextControl.Text.Length)
                {
                    TextControl.SelectionStart = currentPos + 1;
                    TextControl.SelectionLength = 0;
                }
                break;

            case KeyType.Shift:
                IsShiftActive = !IsShiftActive;
                break;

            case KeyType.Back:
                currentPos = TextControl.SelectionStart;
                if (currentPos > 0)
                {
                    TextControl.Text = TextControl.Text.Remove(currentPos - 1, 1);
                    TextControl.SelectionStart = currentPos - 1;
                }
                break;

            case KeyType.Symbols:
                if (Keyboard.Pages > CurrentPage + 1)
                {
                    CurrentPage++;
                }
                break;

            case KeyType.Alfa:
                if (CurrentPage > 0)
                {
                    CurrentPage--;
                }
                break;

            case KeyType.Enter:
                // TODO: Close the keyboard and focus next control.
                break;

            case KeyType.Space:
            case KeyType.Text:
                currentPos = TextControl.SelectionStart;
                TextControl.Text = TextControl.Text.Insert(currentPos, IsShiftActive ? e.Key.VKey.UValue : e.Key.VKey.LValue);
                TextControl.SelectionStart = currentPos + 1;
                
                if (IsShiftActive)
                {
                    IsShiftActive = false;
                }
                break;

            default:
                throw new NotImplementedException();
        }

    }
}
