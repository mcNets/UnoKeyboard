using UnoKeyboard.Models;

namespace UnoKeyboard;

/// <summary>
/// Represents a collection of keyboards.
/// </summary>
public static class Keyboards
{
    public static Dictionary<string, KeyboardModel> Keyboard = new()
    {
        {
            "en-alfa",
            new KeyboardModel(
                "en-alfa",
                2,  // Pages
                5,  // Rows
                10, // Max. keys per line
                [
                    // new KeyModel(Page, Row, Column, ColumnSpan, VirtualKey)
                    new KeyModel(0, 0, 0, 1, VirtualKeys.Get("N1")),
                    new KeyModel(0, 0, 1, 1, VirtualKeys.Get("N2")),
                    new KeyModel(0, 0, 2, 1, VirtualKeys.Get("N3")),
                    new KeyModel(0, 0, 3, 1, VirtualKeys.Get("N4")),
                    new KeyModel(0, 0, 4, 1, VirtualKeys.Get("N5")),
                    new KeyModel(0, 0, 5, 1, VirtualKeys.Get("N6")),
                    new KeyModel(0, 0, 6, 1, VirtualKeys.Get("N7")),
                    new KeyModel(0, 0, 7, 1, VirtualKeys.Get("N8")),
                    new KeyModel(0, 0, 8, 1, VirtualKeys.Get("N9")),
                    new KeyModel(0, 0, 9, 1, VirtualKeys.Get("N0")),

                    new KeyModel(0, 1, 0, 1, VirtualKeys.Get("Q")),
                    new KeyModel(0, 1, 1, 1, VirtualKeys.Get("W")),
                    new KeyModel(0, 1, 2, 1, VirtualKeys.Get("E")),
                    new KeyModel(0, 1, 3, 1, VirtualKeys.Get("R")),
                    new KeyModel(0, 1, 4, 1, VirtualKeys.Get("T")),
                    new KeyModel(0, 1, 5, 1, VirtualKeys.Get("Y")),
                    new KeyModel(0, 1, 6, 1, VirtualKeys.Get("U")),
                    new KeyModel(0, 1, 7, 1, VirtualKeys.Get("I")),
                    new KeyModel(0, 1, 8, 1, VirtualKeys.Get("O")),
                    new KeyModel(0, 1, 9, 1, VirtualKeys.Get("P")),

                    new KeyModel(0, 2, 0, 1, VirtualKeys.Get("A")),
                    new KeyModel(0, 2, 1, 1, VirtualKeys.Get("S")),
                    new KeyModel(0, 2, 2, 1, VirtualKeys.Get("D")),
                    new KeyModel(0, 2, 3, 1, VirtualKeys.Get("F")),
                    new KeyModel(0, 2, 4, 1, VirtualKeys.Get("G")),
                    new KeyModel(0, 2, 5, 1, VirtualKeys.Get("H")),
                    new KeyModel(0, 2, 6, 1, VirtualKeys.Get("J")),
                    new KeyModel(0, 2, 7, 1, VirtualKeys.Get("K")),
                    new KeyModel(0, 2, 8, 1, VirtualKeys.Get("L")),

                    new KeyModel(0, 3, 0, 1, VirtualKeys.Get("Shift")),
                    new KeyModel(0, 3, 1, 1, VirtualKeys.Get("Z")),
                    new KeyModel(0, 3, 2, 1, VirtualKeys.Get("X")),
                    new KeyModel(0, 3, 3, 1, VirtualKeys.Get("C")),
                    new KeyModel(0, 3, 4, 1, VirtualKeys.Get("V")),
                    new KeyModel(0, 3, 5, 1, VirtualKeys.Get("B")),
                    new KeyModel(0, 3, 6, 1, VirtualKeys.Get("N")),
                    new KeyModel(0, 3, 7, 1, VirtualKeys.Get("M")),
                    new KeyModel(0, 3, 8, 1, VirtualKeys.Get("Point")),
                    new KeyModel(0, 3, 9, 1, VirtualKeys.Get("Back")),

                    new KeyModel(0, 4, 0, 2, VirtualKeys.Get("Symbols")),
                    new KeyModel(0, 4, 1, 5, VirtualKeys.Get("Space")),
                    new KeyModel(0, 4, 2, 1, VirtualKeys.Get("Comma")),
                    new KeyModel(0, 4, 3, 2, VirtualKeys.Get("Enter")),

                    new KeyModel(1, 0, 0, 1, VirtualKeys.Get("N1")),
                    new KeyModel(1, 0, 1, 1, VirtualKeys.Get("N2")),
                    new KeyModel(1, 0, 2, 1, VirtualKeys.Get("N3")),
                    new KeyModel(1, 0, 3, 1, VirtualKeys.Get("N4")),
                    new KeyModel(1, 0, 4, 1, VirtualKeys.Get("N5")),
                    new KeyModel(1, 0, 5, 1, VirtualKeys.Get("N6")),
                    new KeyModel(1, 0, 6, 1, VirtualKeys.Get("N7")),
                    new KeyModel(1, 0, 7, 1, VirtualKeys.Get("N8")),
                    new KeyModel(1, 0, 8, 1, VirtualKeys.Get("N9")),
                    new KeyModel(1, 0, 9, 1, VirtualKeys.Get("N0")),

                    new KeyModel(1, 1, 0, 1, VirtualKeys.Get("At")),
                    new KeyModel(1, 1, 1, 1, VirtualKeys.Get("Hash")),
                    new KeyModel(1, 1, 2, 1, VirtualKeys.Get("Dollar")),
                    new KeyModel(1, 1, 3, 1, VirtualKeys.Get("Pound")),
                    new KeyModel(1, 1, 4, 1, VirtualKeys.Get("Euro")),
                    new KeyModel(1, 1, 5, 1, VirtualKeys.Get("Plus")),
                    new KeyModel(1, 1, 6, 1, VirtualKeys.Get("Dash")),
                    new KeyModel(1, 1, 7, 1, VirtualKeys.Get("Asterisk")),
                    new KeyModel(1, 1, 8, 1, VirtualKeys.Get("Slash")),
                    
                    new KeyModel(1, 2, 0, 1, VirtualKeys.Get("Underscore")),
                    new KeyModel(1, 2, 1, 1, VirtualKeys.Get("LParenthesis")),
                    new KeyModel(1, 2, 2, 1, VirtualKeys.Get("RParenthesis")),
                    new KeyModel(1, 2, 3, 1, VirtualKeys.Get("Ampersand")),
                    new KeyModel(1, 2, 4, 1, VirtualKeys.Get("Backslash")),
                    new KeyModel(1, 2, 5, 1, VirtualKeys.Get("SingleQuote")),
                    new KeyModel(1, 2, 6, 1, VirtualKeys.Get("Colon")),
                    new KeyModel(1, 2, 7, 1, VirtualKeys.Get("Semicolon")),
                    new KeyModel(1, 2, 8, 1, VirtualKeys.Get("Exclamation")),

                    new KeyModel(1, 3, 0, 1, VirtualKeys.Get("Equal")),
                    new KeyModel(1, 3, 1, 1, VirtualKeys.Get("LCurly")),
                    new KeyModel(1, 3, 2, 1, VirtualKeys.Get("RCurly")),
                    new KeyModel(1, 3, 3, 1, VirtualKeys.Get("LSquare")),
                    new KeyModel(1, 3, 4, 1, VirtualKeys.Get("RSquare")),
                    new KeyModel(1, 3, 5, 1, VirtualKeys.Get("Percent")),
                    new KeyModel(1, 3, 6, 1, VirtualKeys.Get("Question")), 
                    new KeyModel(1, 3, 7, 1, VirtualKeys.Get("Back")),

                    new KeyModel(1, 4, 0, 2, VirtualKeys.Get("Alfa")),
                    new KeyModel(1, 4, 1, 5, VirtualKeys.Get("Space")),
                    new KeyModel(1, 4, 2, 1, VirtualKeys.Get("Comma")),
                    new KeyModel(1, 4, 3, 2, VirtualKeys.Get("Enter")),
                ]
            )
        },
        {
            "numeric",
            new KeyboardModel(
                "numeric",
                1,  // Pages
                4,  // Rows
                9,  // Max. keys per line
                [
                    // new KeyModel(Page, Row, Column, ColumnSpan, VirtualKey)
                    new KeyModel(0, 0, 0, 1, VirtualKeys.Get("Plus")),
                    new KeyModel(0, 0, 1, 2, VirtualKeys.Get("N1")),
                    new KeyModel(0, 0, 2, 2, VirtualKeys.Get("N2")),
                    new KeyModel(0, 0, 3, 2, VirtualKeys.Get("N3")),
                    new KeyModel(0, 0, 4, 1, VirtualKeys.Get("Percent")),
                    
                    new KeyModel(0, 1, 0, 1, VirtualKeys.Get("Dash")),
                    new KeyModel(0, 1, 1, 2, VirtualKeys.Get("N4")),
                    new KeyModel(0, 1, 2, 2, VirtualKeys.Get("N5")),
                    new KeyModel(0, 1, 3, 2, VirtualKeys.Get("N6")),
                    new KeyModel(0, 1, 4, 1, VirtualKeys.Get("Space")),

                    new KeyModel(0, 2, 0, 1, VirtualKeys.Get("Asterisk")),
                    new KeyModel(0, 2, 1, 2, VirtualKeys.Get("N7")),
                    new KeyModel(0, 2, 2, 2, VirtualKeys.Get("N8")),
                    new KeyModel(0, 2, 3, 2, VirtualKeys.Get("N9")),
                    new KeyModel(0, 2, 4, 1, VirtualKeys.Get("Back")),

                    new KeyModel(0, 3, 0, 1, VirtualKeys.Get("Slash")),
                    new KeyModel(0, 3, 1, 2, VirtualKeys.Get("Point")),
                    new KeyModel(0, 3, 2, 2, VirtualKeys.Get("N0")),
                    new KeyModel(0, 3, 3, 2, VirtualKeys.Get("Comma")),
                    new KeyModel(0, 3, 4, 1, VirtualKeys.Get("Enter")),
                ]
            )
        },
    };
}
