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
            TextControl = null;

            Visibility = Visibility.Collapsed;
        }
    }

    public void OnGettingFocus(UIElement sender, GettingFocusEventArgs args)
    {
        if (args.NewFocusedElement is TextBox textBox
            && Visibility == Visibility.Collapsed)
        {
            TextControl = textBox;

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

        if (TextControl == null || e.Key == null)
        {
            return;
        }

        switch (e.Key.KeyType )
        {
            case KeyType.Left:
                index = TextControl.SelectionStart;
                if (index > 0)
                {
                    TextControl.SelectionStart = index - 1;
                    TextControl.SelectionLength = 0;
                }
                break;

            case KeyType.Right:
                index = TextControl.SelectionStart;
                if (index < TextControl.Text.Length)
                {
                    TextControl.SelectionStart = index + 1;
                    TextControl.SelectionLength = 0;
                }
                break;

            case KeyType.Shift:
                IsShiftActive = !IsShiftActive;
                break;

            case KeyType.Backspace:
                index = TextControl.SelectionStart;
                if (index > 0)
                {
                    TextControl.Text = TextControl.Text.Remove(index - 1, 1);
                    TextControl.SelectionStart = index - 1;
                }
                break;

            case KeyType.NextPage:
                if (Keyboard.Pages > CurrentPage + 1)
                {
                    CurrentPage++;
                }
                break;

            case KeyType.PrevPage:
                if (CurrentPage > 0)
                {
                    CurrentPage--;
                }
                break;

            case KeyType.Enter:
                break;

            case KeyType.Text:
                index = TextControl.SelectionStart;
                TextControl.Text = TextControl.Text.Insert(index, IsShiftActive ? e.Key.UValue : e.Key.LValue);
                TextControl.SelectionStart = index + 1; 
                break;

            default:
                throw new NotImplementedException();
        }
        
    }
}
