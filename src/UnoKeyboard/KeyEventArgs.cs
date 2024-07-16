using UnoKeyboard.Models;

namespace UnoKeyboard;

public class KeyEventArgs : RoutedEventArgs
{
    public KeyEventArgs(KeyModel key, bool isShiftActive)
    {
        Key = key;
        IsShiftActive = isShiftActive;
    }

    public KeyModel Key { get; }
    public bool IsShiftActive { get; }
}
