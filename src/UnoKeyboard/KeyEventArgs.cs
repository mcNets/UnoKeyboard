using UnoKeyboard.Models;

namespace UnoKeyboard;

/// <summary>
/// Represents the event arguments for a key event.
/// </summary>
public class KeyEventArgs : RoutedEventArgs
{
    public KeyEventArgs(KeyModel key, bool isShiftActive)
    {
        Key = key;
        IsShiftActive = isShiftActive;
    }

    /// <summary>
    /// Key that was pressed.
    /// </summary>
    public KeyModel Key { get; }

    /// <summary>
    /// Indicates whether the shift key is active.
    /// </summary>
    public bool IsShiftActive { get; }
}
