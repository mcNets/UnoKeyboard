namespace UnoKeyboard.Models;

public record KeyboardModel(string Id, KeyboardType Type, int NPages, int NLines, int NKeys, List<KeyModel> Keys);
