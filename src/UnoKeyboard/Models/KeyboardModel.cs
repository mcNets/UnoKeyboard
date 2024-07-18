namespace UnoKeyboard.Models;

public record KeyboardModel(string Id, KeyboardType Type, int Pages, int Lines, int MaxKeys, List<KeyModel> Keys);
