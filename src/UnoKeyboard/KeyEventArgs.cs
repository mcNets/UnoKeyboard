namespace UnoKeyboard;

public class KeyEventArgs : RoutedEventArgs
{
    public KeyEventArgs(string keyId, string keyText, bool isShiftActive)
    {
        KeyId = keyId;
        KeyText = keyText;
        IsShiftActive = isShiftActive;
    }

    public string KeyId { get; }
    public string KeyText { get; }
    public bool IsShiftActive { get; }
}
