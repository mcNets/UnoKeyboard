﻿using Microsoft.UI.Xaml.Input;

namespace UnoKeyboard.Controls;

public sealed partial class KeyboardControl
{
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
                if (Keyboard is not null && Keyboard.Pages > CurrentPage + 1)
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
                // TODO: What to do with the Enter key?
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

    private void OnLosingFocus(object? sender, LosingFocusEventArgs args)
    {
        // THAT DOESN'T WORK FOR WINDOWS

        // When a KeyControl gets the focus, the event has to be canceled so the TextBox doesn't lose the focus.
        if ((args.NewFocusedElement is null || args.NewFocusedElement is KeyControl)
            && args.OldFocusedElement is TextBox)
        {
            args.Cancel = true;
            return;
        }

        if (Visibility == Visibility.Visible)
        {
            DispatcherQueue?.TryEnqueue(() => Visibility = Visibility.Collapsed);
        }
    }

    private void OnGettingFocus(object? sender, GettingFocusEventArgs args)
    {
        if (args.NewFocusedElement is TextBox textBox)
        {
            DispatcherQueue?.TryEnqueue(() =>
            {
                // Gets the keyboard type from the attached property.
                var kbrIdProp = textBox.GetValue(McWindowEx.KeyboardIdProperty);

                if (kbrIdProp is string keyboardId)
                {
                    if (keyboardId == "None")
                    {
                        if (Keyboard is null || Keyboard.Id != Keyboards.Keyboard.First().Key)
                        {
                            Keyboard = Keyboards.Keyboard.First().Value;
                        }
                    }
                    else if (Keyboard is null || Keyboard.Id != keyboardId)
                    {
                        var k = Keyboards.Keyboard[keyboardId];
                        Keyboard = k;
                    }
                }

                TextControl = textBox;

                Visibility = Visibility.Visible;
            });
        }
    }
}