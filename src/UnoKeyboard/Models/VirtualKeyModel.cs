namespace UnoKeyboard.Models;

public record VirtualKeyModel(string KeyId, 
                              KeyType KType,
                              string UChar, 
                              string LChar, 
                              int UCode, 
                              int LCode, 
                              PathGeometry? Geometry, 
                              double GeometryWidth, 
                              double GeometryHeight)
{
    public string UValue => char.ConvertFromUtf32(UCode);
    public string LValue => char.ConvertFromUtf32(LCode);
}
