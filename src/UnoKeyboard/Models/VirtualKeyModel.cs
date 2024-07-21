namespace UnoKeyboard;

public record VirtualKeyModel(string KeyId, KeyType KType, string UChar, string LChar, int UCode, int LCode, PathGeometry Geometry, double GeometryWidth, double GeometryHeight);
