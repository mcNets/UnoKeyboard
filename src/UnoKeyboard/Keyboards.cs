using Microsoft.UI.Xaml.Documents;
using UnoKeyboard.Models;

namespace UnoKeyboard;

public static class Keyboards
{
    public static Dictionary<string, KeyboardModel> Keyboard = new()
    {
        {
            "en-alfa",
            new KeyboardModel(
                "en-alfa",
                2,  // Pages
                5,  // Max. rows per page
                10, // Max. keys per line
                [
                    // Page, Row, Column, Width, Key
                    new KeyModel(0, 0, 0, 1, VirtualKeys.N1),
                    new KeyModel(0, 0, 1, 1, VirtualKeys.N2),
                    new KeyModel(0, 0, 2, 1, VirtualKeys.N3),
                    new KeyModel(0, 0, 3, 1, VirtualKeys.N4),
                    new KeyModel(0, 0, 4, 1, VirtualKeys.N5),
                    new KeyModel(0, 0, 5, 1, VirtualKeys.N6),
                    new KeyModel(0, 0, 6, 1, VirtualKeys.N7),
                    new KeyModel(0, 0, 7, 1, VirtualKeys.N8),
                    new KeyModel(0, 0, 8, 1, VirtualKeys.N9),
                    new KeyModel(0, 0, 9, 1, VirtualKeys.N0),

                    new KeyModel(0, 1, 0, 1, VirtualKeys.Q),
                    new KeyModel(0, 1, 1, 1, VirtualKeys.W),
                    new KeyModel(0, 1, 2, 1, VirtualKeys.E),
                    new KeyModel(0, 1, 3, 1, VirtualKeys.R),
                    new KeyModel(0, 1, 4, 1, VirtualKeys.T),
                    new KeyModel(0, 1, 5, 1, VirtualKeys.Y),
                    new KeyModel(0, 1, 6, 1, VirtualKeys.U),
                    new KeyModel(0, 1, 7, 1, VirtualKeys.I),
                    new KeyModel(0, 1, 8, 1, VirtualKeys.O),
                    new KeyModel(0, 1, 9, 1, VirtualKeys.P),

                    new KeyModel(0, 2, 0, 1, VirtualKeys.A),
                    new KeyModel(0, 2, 1, 1, VirtualKeys.S),
                    new KeyModel(0, 2, 2, 1, VirtualKeys.D),
                    new KeyModel(0, 2, 3, 1, VirtualKeys.F),
                    new KeyModel(0, 2, 4, 1, VirtualKeys.G),
                    new KeyModel(0, 2, 5, 1, VirtualKeys.H),
                    new KeyModel(0, 2, 6, 1, VirtualKeys.J),
                    new KeyModel(0, 2, 7, 1, VirtualKeys.K),
                    new KeyModel(0, 2, 8, 1, VirtualKeys.L),

                    new KeyModel(0, 3, 0, 1, VirtualKeys.Shift),
                    new KeyModel(0, 3, 1, 1, VirtualKeys.Z),
                    new KeyModel(0, 3, 2, 1, VirtualKeys.X),
                    new KeyModel(0, 3, 3, 1, VirtualKeys.C),
                    new KeyModel(0, 3, 4, 1, VirtualKeys.V),
                    new KeyModel(0, 3, 5, 1, VirtualKeys.B),
                    new KeyModel(0, 3, 6, 1, VirtualKeys.N),
                    new KeyModel(0, 3, 7, 1, VirtualKeys.M),
                    new KeyModel(0, 3, 8, 1, VirtualKeys.Point),
                    new KeyModel(0, 3, 9, 1, VirtualKeys.Back),

                    new KeyModel(0, 4, 0, 2, VirtualKeys.Symbols),
                    new KeyModel(0, 4, 1, 5, VirtualKeys.Space),
                    new KeyModel(0, 4, 2, 1, VirtualKeys.Comma),
                    new KeyModel(0, 4, 3, 2, VirtualKeys.Enter),

                    new KeyModel(1, 0, 0, 1, VirtualKeys.N1),
                    new KeyModel(1, 0, 1, 1, VirtualKeys.N2),
                    new KeyModel(1, 0, 2, 1, VirtualKeys.N3),
                    new KeyModel(1, 0, 3, 1, VirtualKeys.N4),
                    new KeyModel(1, 0, 4, 1, VirtualKeys.N5),
                    new KeyModel(1, 0, 5, 1, VirtualKeys.N6),
                    new KeyModel(1, 0, 6, 1, VirtualKeys.N7),
                    new KeyModel(1, 0, 7, 1, VirtualKeys.N8),
                    new KeyModel(1, 0, 8, 1, VirtualKeys.N9),
                    new KeyModel(1, 0, 9, 1, VirtualKeys.N0),

                    new KeyModel(1, 1, 0, 1, VirtualKeys.At),
                    new KeyModel(1, 1, 1, 1, VirtualKeys.Hash),
                    new KeyModel(1, 1, 2, 1, VirtualKeys.Dollar),
                    new KeyModel(1, 1, 3, 1, VirtualKeys.Underscore),
                    new KeyModel(1, 1, 4, 1, VirtualKeys.Ampersand),
                    new KeyModel(1, 1, 5, 1, VirtualKeys.Plus),
                    new KeyModel(1, 1, 6, 1, VirtualKeys.LParenthesis),
                    new KeyModel(1, 1, 7, 1, VirtualKeys.RPArenthesis),

                    new KeyModel(1, 2, 0, 1, VirtualKeys.Plus),
                    new KeyModel(1, 2, 1, 1, VirtualKeys.Backslash),
                    new KeyModel(1, 2, 2, 1, VirtualKeys.Euro),
                    new KeyModel(1, 2, 3, 1, VirtualKeys.SingleQuote),
                    new KeyModel(1, 2, 4, 1, VirtualKeys.Colon),
                    new KeyModel(1, 2, 5, 1, VirtualKeys.Semicolon),
                    new KeyModel(1, 2, 6, 1, VirtualKeys.Question), 
                    new KeyModel(1, 2, 7, 1, VirtualKeys.Dash),

                    new KeyModel(1, 3, 0, 1, VirtualKeys.Equal),
                    new KeyModel(1, 3, 1, 1, VirtualKeys.LCurly),
                    new KeyModel(1, 3, 2, 1, VirtualKeys.RCurly),
                    new KeyModel(1, 3, 3, 1, VirtualKeys.LSquare),
                    new KeyModel(1, 3, 4, 1, VirtualKeys.RSquare),
                    new KeyModel(1, 3, 5, 1, VirtualKeys.Percent),
                    new KeyModel(1, 3, 6, 1, VirtualKeys.Slash),
                    new KeyModel(1, 3, 7, 1, VirtualKeys.Back),

                    new KeyModel(1, 4, 0, 2, VirtualKeys.Alfa),
                    new KeyModel(1, 4, 1, 5, VirtualKeys.Space),
                    new KeyModel(1, 4, 2, 1, VirtualKeys.Comma),
                    new KeyModel(1, 4, 3, 2, VirtualKeys.Enter),
                ]
            )
        },
        {
            "numeric",
            new KeyboardModel(
                "numeric",
                1,  // Pages
                4,  // Max. rows per page
                9,  // Max. keys per line
                [
                    new KeyModel(0, 0, 0, 1, VirtualKeys.Plus),
                    new KeyModel(0, 0, 1, 2, VirtualKeys.N1),
                    new KeyModel(0, 0, 2, 2, VirtualKeys.N2),
                    new KeyModel(0, 0, 3, 2, VirtualKeys.N3),
                    new KeyModel(0, 0, 4, 1, VirtualKeys.Percent),
                    
                    new KeyModel(0, 1, 0, 1, VirtualKeys.Dash),
                    new KeyModel(0, 1, 1, 2, VirtualKeys.N4),
                    new KeyModel(0, 1, 2, 2, VirtualKeys.N5),
                    new KeyModel(0, 1, 3, 2, VirtualKeys.N6),
                    new KeyModel(0, 1, 4, 1, VirtualKeys.Space),

                    new KeyModel(0, 2, 0, 1, VirtualKeys.Asterisk),
                    new KeyModel(0, 2, 1, 2, VirtualKeys.N7),
                    new KeyModel(0, 2, 2, 2, VirtualKeys.N8),
                    new KeyModel(0, 2, 3, 2, VirtualKeys.N9),
                    new KeyModel(0, 2, 4, 1, VirtualKeys.Back),

                    new KeyModel(0, 3, 0, 1, VirtualKeys.Slash),
                    new KeyModel(0, 3, 1, 2, VirtualKeys.Point),
                    new KeyModel(0, 3, 2, 2, VirtualKeys.N0),
                    new KeyModel(0, 3, 3, 2, VirtualKeys.Comma),
                    new KeyModel(0, 3, 4, 1, VirtualKeys.Enter),
                ]
            )
        }
    };
}
