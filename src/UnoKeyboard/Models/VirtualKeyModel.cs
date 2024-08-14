using UnoKeyboard;

/// <summary>
/// Represents a model for a virtual key.
/// </summary>
/// <param name="KeyId">The unique identifier of the key.</param>
/// <param name="KType">The type of the key.</param>
/// <param name="UChar">The uppercase character representation of the key.</param>
/// <param name="LChar">The lowercase character representation of the key.</param>
/// <param name="UCode">The Unicode value of the uppercase character.</param>
/// <param name="LCode">The Unicode value of the lowercase character.</param>
/// <param name="GetPath">A Func that returns a Path</param>
public record VirtualKeyModel(string KeyId, 
                              KeyType KType,
                              string UChar, 
                              string LChar, 
                              int UCode, 
                              int LCode,
                              Func<Microsoft.UI.Xaml.Shapes.Path>? GetPath)
{
    /// <summary>
    /// Gets the uppercase character value of the key.
    /// </summary>
    public string UValue => char.ConvertFromUtf32(UCode);
    
    /// <summary>
    /// Gets the lowercase character value of the key.
    /// </summary>
    public string LValue => char.ConvertFromUtf32(LCode);

    /// <summary>
    /// Gets the character value of the key depending on the shift state.
    /// </summary>
    public string Value(bool isShifted) => isShifted ? UValue : LValue;
}
