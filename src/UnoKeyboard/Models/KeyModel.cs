namespace UnoKeyboard.Models;

public record KeyModel(int Page, 
                       int Row, 
                       int Column, 
                       double ColumnSpan,
                       VirtualKeyModel VKey);