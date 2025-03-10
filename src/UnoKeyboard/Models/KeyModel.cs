namespace UnoKeyboard;

/// <summary>
/// Represents a key in the keyboard.
/// </summary>
/// <param name="Page">Page number.</param>
/// <param name="Row">Row number.</param>
/// <param name="Column">Column number</param>
/// <param name="ColumnSpan">The span of the key in terms of columns.</param>
/// <param name="VKey">The virtual key associated with the key.</param>
public record KeyModel(int Page, 
                       int Row, 
                       int Column, 
                       double ColumnSpan,
                       VirtualKeyModel VKey);