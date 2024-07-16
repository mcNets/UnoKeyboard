namespace UnoKeyboard.Models;

public record KeyModel(KeyType KeyType, int Page, int Row, int Col, double WithFactor, string UChar, string LChar, int UCode, int LCode);
