namespace UnoKeyboard.Models;

public record KeyModel(KeyType Type, int Page, int Row, int Col, string UChar, string LChar, int UCode, int LCode);
