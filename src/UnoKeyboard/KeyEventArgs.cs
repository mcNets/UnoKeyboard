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
        Cancel = false;
    }

    /// <summary>
    /// Key that was pressed.
    /// </summary>
    public KeyModel Key { get; }

    /// <summary>
    /// Indicates whether the shift key is active.
    /// </summary>
    public bool IsShiftActive { get; }

    /// <summary>
    /// Indicates whether the event should be canceled.
    /// </summary>
    public bool Cancel { get; set; }
}
