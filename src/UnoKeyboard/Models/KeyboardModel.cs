namespace UnoKeyboard.Models;

public record KeyboardModel(string Id, KeyboardType Type, int Pages, int Rows, int MaxKeys, List<KeyModel> Keys);
