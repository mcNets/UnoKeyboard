namespace UnoKeyboard.Models;

public record KeyModel(int Page, 
                       int Row, 
                       int Col, 
                       double WithFactor,
                       VirtualKeyModel VKey);