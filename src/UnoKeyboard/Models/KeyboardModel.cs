namespace UnoKeyboard.Models;

public record KeyboardModel(string Id, 
                            int Pages, 
                            int Rows, 
                            int MaxKeys, 
                            List<KeyModel> Keys);
